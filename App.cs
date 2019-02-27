#region Namespaces
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
#endregion

namespace IFCExport
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            PushButton button;
            Uri uriImage;
            BitmapImage image;
            Autodesk.Revit.UI.RibbonPanel panel;

            string pathDll = Environment.ExpandEnvironmentVariables(@"%AppData%\Autodesk\Revit\Addins\2018\IFCExport.dll");

            //Create Panel
            panel = application.CreateRibbonPanel("IFC Utilities");

            //Create Trefoil PushButton
            button = panel.AddItem(new PushButtonData("Batch Export",
            "Batch Export", pathDll, "IFCExport.IFCExportCommand")) as PushButton;
            uriImage = new Uri($"pack://application:,,,/IFCExport;component/Resources/IFC_32x32.png", UriKind.Absolute);
            image = new BitmapImage(uriImage);
            button.LargeImage = image;

            
            

            return Result.Succeeded;
        }

       

        public Result OnShutdown(UIControlledApplication application)
        {
            
            return Result.Succeeded;
        }
    }
}
