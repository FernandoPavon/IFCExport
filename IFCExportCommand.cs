#region Copyright

/*
 *  Copyright 2018 Autodesk, Inc. All rights reserved.
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:

 *  The above copyright notice and this permission notice shall be included in all
 *  copies or substantial portions of the Software.

 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.

 *  Fernando Pavon
 *  fernando.pavon@autodesk.com
 *  Beta Version 0.0.0.1
 *  25 February 2019
 */

#endregion

#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;


using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

using Autodesk.Revit.DB.IFC;
using Autodesk.Revit.UI.Events;
#endregion

namespace IFCExport
{
    [Transaction(TransactionMode.Manual)]
    public class IFCExportCommand : IExternalCommand
    {
        private string m_revitPath = string.Empty;
        private string m_IFCPath = string.Empty;
        private string m_prevPath = string.Empty;
        private IList<string> m_revitFiles = new List<string>();
        private ElementId m_activeViewId = new ElementId(0);
        string m_activeView = string.Empty;

        UIApplication m_uiapp;
        UIDocument m_uidoc;
        Document m_doc;

        IFCExportOptions ifcOptions = new IFCExportOptions();

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            m_uiapp = commandData.Application;
            m_uidoc = m_uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = m_uiapp.Application;
            m_doc = m_uidoc.Document;

            m_uiapp.DialogBoxShowing += new EventHandler<DialogBoxShowingEventArgs>(IgnoreDialog);

            IFCExportForm form = new IFCExportForm();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return Result.Cancelled;
            }

            m_IFCPath = form.IFCPath;
            m_revitPath = form.RevitPath;
            m_revitFiles = form.RevitFiles;
            m_activeView = form.ActiveView;
            ifcOptions = form.IFCOptions;
           
            SaveOptions saveOptions = new SaveOptions();

            ExportFiles(ifcOptions);

            m_uiapp.DialogBoxShowing -= new EventHandler<DialogBoxShowingEventArgs>(IgnoreDialog);

            return Result.Succeeded;
        }

        private void ExportFiles(IFCExportOptions ifcOptions)
        {
            string mess = string.Empty;

            try
            {
                foreach (string fileName in m_revitFiles)
                {
                    string fullPath = string.Empty;


                    if (m_prevPath != fileName)
                    {
                        if (m_doc.PathName != fileName)
                        {
                            fullPath = Path.Combine(m_revitPath, fileName);
                            m_uiapp.OpenAndActivateDocument(fullPath);
                            m_doc.Close(true);
                            m_doc = m_uiapp.ActiveUIDocument.Document;

                            m_activeViewId = GetViewId(m_doc, m_activeView);

                            Transaction tx = new Transaction(m_doc, "Export IFC");
                            tx.Start();

                            if (m_activeViewId.IntegerValue < 0)
                            {
                                mess += "\nView '" + m_activeView + "' not found in " + fileName;
                            }
                            else
                            {
                                ifcOptions.AddOption("ActiveViewId", m_activeViewId.ToString());
                            }

                            m_prevPath = fileName;

                            m_doc.Export(m_IFCPath, fileName, ifcOptions);
                            tx.Commit();
                        }
                    }
                }
                MessageBox.Show(m_revitFiles.Count.ToString() + " x IFC files exported.\n" + mess, "IFC Export Complete");
            }
            catch
            {
                MessageBox.Show("Ensure that you have a saved blank project to begin IFC Batch Export", "IFC Batch Export");
            }
            
            
        }

        private ElementId GetViewId(Document doc, string viewName)
        {
            ElementId eId = null;

            ElementId bip_id = new ElementId(BuiltInParameter.VIEW_NAME);
            ParameterValueProvider provider = new ParameterValueProvider(bip_id);
            FilterStringEquals evaluator = new FilterStringEquals();
            FilterStringRule rule = new FilterStringRule(provider, evaluator, viewName, false);
            ElementParameterFilter filter = new ElementParameterFilter(rule);

            eId = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfCategory(BuiltInCategory.OST_Views)
                .WherePasses(filter)
                .FirstElementId();

            return eId;
        }

        private void IgnoreDialog(object o, DialogBoxShowingEventArgs e)
        {
            e.OverrideResult(1);
            e.Cancel();
        }
    }
}
