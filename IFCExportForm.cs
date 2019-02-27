using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Autodesk.Revit.DB;
using Autodesk.Revit.DB.IFC;

namespace IFCExport
{
    public partial class IFCExportForm : System.Windows.Forms.Form
    {
        private string m_revitPath = string.Empty;
        private string m_IFCPath = string.Empty;
        private IList<string> m_revitFiles = new List<string>();
        private IFCExportOptions m_ifcOptions = new IFCExportOptions();
        private IFCVersion m_ifcVersion;
        private string m_activeView;

        public string RevitPath { get { return m_revitPath; } }

        public string IFCPath { get { return m_IFCPath; } }

        public IList<string> RevitFiles { get { return m_revitFiles; } }

        public IFCExportOptions IFCOptions { get { return m_ifcOptions; } }

        public IFCVersion IFCVersion { get { return m_ifcVersion; } }

        public IList<IFCVersionClass> m_ifcVerList = new List<IFCVersionClass>();

        public string ActiveView { get { return m_activeView; } }

        public IFCExportForm()
        {
            InitializeComponent();
        }

        private void IFCExportForm_Load(object sender, EventArgs e)
        {

            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC2x2));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC2x3));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC2x3BFM));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC2x3CV2));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC2x3FM));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC4));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC4DTV));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFC4RV));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFCBCA));
            m_ifcVerList.Add(new IFCVersionClass(IFCVersion.IFCCOBIE));

            IFCVersionComboBox.DataSource = m_ifcVerList;
            IFCVersionComboBox.DisplayMember = "Description"; // "IFCVersionString";

            IFCVersionComboBox.SelectedIndex = 3;

            IFCSettingsComboBox.Items.Add("DBEC_IFC2x3-Export_KaBa");
            IFCSettingsComboBox.Items.Add("DBEC_IFC2x3-Export_KaBa_IB");

            IFCSettingsComboBox.SelectedIndex = 0;

            ActiveViewComboBox.Items.Add("{3D}");
            ActiveViewComboBox.Items.Add("Navis 3D Startansicht");

            ActiveViewComboBox.SelectedIndex = 0;

            /*
            TessellationLevelOfDetail = 0.5;
            ExcludeFilter = "";
            COBieCompanyInfo = "";
            COBieProjectInfo = "";
            FileVersionDescription": "IFC 2x3 Coordination View 2.0"
            ExportUserDefinedPsetsFileName = "";
            ExportUserDefinedParameterMappingFileName = "";
            */
        }

        private void BrowseRevitFilesButton_Click(object sender, EventArgs e)
        {
            string[] revitFiles;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            m_revitPath = fbd.SelectedPath;

            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(m_revitPath))
            {
                RevitFilesTextBox.Text = fbd.SelectedPath;

                revitFiles = Directory.GetFiles(fbd.SelectedPath);

                foreach ( string file in revitFiles)
                {
                    string fileName = Path.GetFileName(file);
                    string fileExt = Path.GetExtension(file);

                    if (fileExt == ".rvt")
                    {
                        RevitListView.Items.Add(fileName);
                    }
                }
            }
        }

        private void BrowseIFCFilesButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            m_IFCPath = fbd.SelectedPath;

            IFCFilesTextBox.Text = m_IFCPath;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            IFCVersionClass ifc = IFCVersionComboBox.SelectedItem as IFCVersionClass;
            m_ifcVersion = ifc.IFCVersion;

            m_revitFiles.Clear();

            m_ifcOptions.FileVersion = m_ifcVersion;
            m_ifcOptions.ExportBaseQuantities = ExportBaseQuantitiesCheckBox.Checked;
            m_ifcOptions.AddOption("SplitWallsAndColumns", SplitWallsAndColumnsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportInternalRevitPropertySets", ExportInternalRevitPropertySetsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportIFCCommonPropertySets", ExportIFCCommonPropertySetsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("Export2DElements", Export2DElementsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("VisibleElementsOfCurrentView", VisibleElementsOfCurrentViewCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("Use2DRoomBoundaryForVolume", Use2DRoomBoundaryForVolumeCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("UseFamilyAndTypeNameForReference", UseFamilyAndTypeNameForReferenceCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportPartsAsBuildingElements", ExportPartsAsBuildingElementsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportSolidModelRep", ExportSolidModelRepCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportSchedulesAsPsets", ExportSchedulesAsPsetsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportUserDefinedPsets", ExportUserDefinedPsetsCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportUserDefinedParameterMapping", ExportUserDefinedParameterMappingCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportBoundingBox", ExportBoundingBoxCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("IncludeSiteElevation", IncludeSiteElevationCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("UseActiveViewGeometryCheckBox", UseActiveViewGeometryCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportSpecificSchedules", ExportSpecificSchedulesCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("UseOnlyTriangulation", UseOnlyTriangulationCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("StoreIFCGUID", StoreIFCGUIDCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("ExportRoomsInView", ExportRoomsInViewCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("xportLinkedFiles", ExportLinkedFilesCheckBox.Checked.ToString());
            m_ifcOptions.AddOption("IsBuiltIn", IsBuiltInCheckBox.Checked.ToString()); 
            m_ifcOptions.AddOption("IsInSession", IsInSessionCheckBox.Checked.ToString());

            foreach (ListViewItem item in RevitListView.Items)
            {
                if (item.Checked)
                {
                    m_revitFiles.Add(item.Text);
                }
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in RevitListView.Items)
            {
                item.Checked = true;
            }
        }

        private void IFCSettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IFCSettingsComboBox.SelectedItem.ToString() == "DBEC_IFC2x3-Export_KaBa")
            {
                
                ExportBaseQuantitiesCheckBox.Checked = false;
                SplitWallsAndColumnsCheckBox.Checked = false;
                ExportInternalRevitPropertySetsCheckBox.Checked = false;
                ExportIFCCommonPropertySetsCheckBox.Checked = false;
                Export2DElementsCheckBox.Checked = false;
                VisibleElementsOfCurrentViewCheckBox.Checked = false;
                Use2DRoomBoundaryForVolumeCheckBox.Checked = false;
                UseFamilyAndTypeNameForReferenceCheckBox.Checked = false;
                ExportPartsAsBuildingElementsCheckBox.Checked = false;
                ExportSolidModelRepCheckBox.Checked = false;
                ExportSchedulesAsPsetsCheckBox.Checked = true;
                ExportUserDefinedPsetsCheckBox.Checked = false;
                ExportUserDefinedParameterMappingCheckBox.Checked = false;
                ExportBoundingBoxCheckBox.Checked = false;
                IncludeSiteElevationCheckBox.Checked = false;
                UseActiveViewGeometryCheckBox.Checked = false;
                ExportSpecificSchedulesCheckBox.Checked = true;
                UseOnlyTriangulationCheckBox.Checked = false;
                StoreIFCGUIDCheckBox.Checked = false;
                ExportRoomsInViewCheckBox.Checked = false;
                ExportLinkedFilesCheckBox.Checked = false;
                IsBuiltInCheckBox.Checked = false;
                IsInSessionCheckBox.Checked = false;

            }
            else if (IFCSettingsComboBox.SelectedItem.ToString() == "DBEC_IFC2x3-Export_KaBa_IB")
            {
               
                ExportBaseQuantitiesCheckBox.Checked = false;
                SplitWallsAndColumnsCheckBox.Checked = false;
                ExportInternalRevitPropertySetsCheckBox.Checked = true;
                ExportIFCCommonPropertySetsCheckBox.Checked = false;
                Export2DElementsCheckBox.Checked = false;
                VisibleElementsOfCurrentViewCheckBox.Checked = false;
                Use2DRoomBoundaryForVolumeCheckBox.Checked = false;
                UseFamilyAndTypeNameForReferenceCheckBox.Checked = false;
                ExportPartsAsBuildingElementsCheckBox.Checked = false;
                ExportSolidModelRepCheckBox.Checked = false;
                ExportSchedulesAsPsetsCheckBox.Checked = false;
                ExportUserDefinedPsetsCheckBox.Checked = false;
                ExportUserDefinedParameterMappingCheckBox.Checked = false;
                ExportBoundingBoxCheckBox.Checked = false;
                IncludeSiteElevationCheckBox.Checked = false;
                UseActiveViewGeometryCheckBox.Checked = false;
                ExportSpecificSchedulesCheckBox.Checked = true;
                UseOnlyTriangulationCheckBox.Checked = false;
                StoreIFCGUIDCheckBox.Checked = false;
                ExportRoomsInViewCheckBox.Checked = false;
                ExportLinkedFilesCheckBox.Checked = false;
                IsBuiltInCheckBox.Checked = false;
                IsInSessionCheckBox.Checked = false;
            }

            IFCVersionComboBox.SelectedIndex = 3;
        }

        private void ActiveViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_activeView = ActiveViewComboBox.SelectedItem.ToString();
        }
    }


    public class IFCVersionClass
    {
        private IFCVersion m_ifcVersion;

        public IFCVersionClass(IFCVersion version)
        {
            m_ifcVersion = version;
        }

        public IFCVersion IFCVersion { get { return m_ifcVersion; } }

        public string IFCVersionString { get { return m_ifcVersion.ToString(); } }

        public string Description
        {
            get
            {
                string desc = string.Empty;

                switch (IFCVersion)
                {
                    case IFCVersion.IFC2x2:
                        desc = "IFC 2x2";
                        break;

                    case IFCVersion.IFC2x3:
                        desc = "IFC 2x3";
                        break;

                    case IFCVersion.IFC2x3BFM:
                        desc = "IFC 2x3 Basic FM";
                        break;

                    case IFCVersion.IFC2x3CV2:
                        desc = "IFC 2x3 Coordination View 2.0";
                        break;

                    case IFCVersion.IFC2x3FM:
                        desc = "IFC 2x3 FM";
                        break;

                    case IFCVersion.IFC4:
                        desc = "IFC 4";
                        break;

                    case IFCVersion.IFC4DTV:
                        desc = "IFC 4 DTV";
                        break;

                    case IFCVersion.IFC4RV:
                        desc = "IFC 4 RV";
                        break;

                    case IFCVersion.IFCBCA:
                        desc = "IFC BCA";
                        break;

                    case IFCVersion.IFCCOBIE:
                        desc = "IFC Cobie";
                        break;

                    default:
                        desc = "-";
                        break;
                }

                return desc;
            }
        }
    } 
}
