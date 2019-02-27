namespace IFCExport
{
    partial class IFCExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BrowseRevitFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RevitFilesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseIFCFilesButton = new System.Windows.Forms.Button();
            this.IFCFilesTextBox = new System.Windows.Forms.TextBox();
            this.RevitListView = new System.Windows.Forms.ListView();
            this.colRevitFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportBaseQuantitiesCheckBox = new System.Windows.Forms.CheckBox();
            this.SplitWallsAndColumnsCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportInternalRevitPropertySetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportIFCCommonPropertySetsCheckBox = new System.Windows.Forms.CheckBox();
            this.Export2DElementsCheckBox = new System.Windows.Forms.CheckBox();
            this.VisibleElementsOfCurrentViewCheckBox = new System.Windows.Forms.CheckBox();
            this.Use2DRoomBoundaryForVolumeCheckBox = new System.Windows.Forms.CheckBox();
            this.UseFamilyAndTypeNameForReferenceCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportPartsAsBuildingElementsCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportSolidModelRepCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportSchedulesAsPsetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportUserDefinedPsetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportUserDefinedParameterMappingCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportBoundingBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.IncludeSiteElevationCheckBox = new System.Windows.Forms.CheckBox();
            this.UseActiveViewGeometryCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportSpecificSchedulesCheckBox = new System.Windows.Forms.CheckBox();
            this.UseOnlyTriangulationCheckBox = new System.Windows.Forms.CheckBox();
            this.StoreIFCGUIDCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportRoomsInViewCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportLinkedFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.ExcludeFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.IsBuiltInCheckBox = new System.Windows.Forms.CheckBox();
            this.IsInSessionCheckBox = new System.Windows.Forms.CheckBox();
            this.IFCVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IFCSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ActiveViewComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(550, 469);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Export";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(640, 469);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BrowseRevitFilesButton
            // 
            this.BrowseRevitFilesButton.Location = new System.Drawing.Point(12, 39);
            this.BrowseRevitFilesButton.Name = "BrowseRevitFilesButton";
            this.BrowseRevitFilesButton.Size = new System.Drawing.Size(100, 23);
            this.BrowseRevitFilesButton.TabIndex = 0;
            this.BrowseRevitFilesButton.Text = "Browse >>";
            this.BrowseRevitFilesButton.UseVisualStyleBackColor = true;
            this.BrowseRevitFilesButton.Click += new System.EventHandler(this.BrowseRevitFilesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder for Revit files:";
            // 
            // RevitFilesTextBox
            // 
            this.RevitFilesTextBox.Location = new System.Drawing.Point(118, 18);
            this.RevitFilesTextBox.Multiline = true;
            this.RevitFilesTextBox.Name = "RevitFilesTextBox";
            this.RevitFilesTextBox.ReadOnly = true;
            this.RevitFilesTextBox.Size = new System.Drawing.Size(222, 44);
            this.RevitFilesTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Folder for IFC Files:";
            // 
            // BrowseIFCFilesButton
            // 
            this.BrowseIFCFilesButton.Location = new System.Drawing.Point(13, 469);
            this.BrowseIFCFilesButton.Name = "BrowseIFCFilesButton";
            this.BrowseIFCFilesButton.Size = new System.Drawing.Size(97, 23);
            this.BrowseIFCFilesButton.TabIndex = 9;
            this.BrowseIFCFilesButton.Text = "Browse >>";
            this.BrowseIFCFilesButton.UseVisualStyleBackColor = true;
            this.BrowseIFCFilesButton.Click += new System.EventHandler(this.BrowseIFCFilesButton_Click);
            // 
            // IFCFilesTextBox
            // 
            this.IFCFilesTextBox.Location = new System.Drawing.Point(117, 448);
            this.IFCFilesTextBox.Multiline = true;
            this.IFCFilesTextBox.Name = "IFCFilesTextBox";
            this.IFCFilesTextBox.ReadOnly = true;
            this.IFCFilesTextBox.Size = new System.Drawing.Size(223, 44);
            this.IFCFilesTextBox.TabIndex = 10;
            // 
            // RevitListView
            // 
            this.RevitListView.BackColor = System.Drawing.SystemColors.Info;
            this.RevitListView.CheckBoxes = true;
            this.RevitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRevitFiles});
            this.RevitListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevitListView.GridLines = true;
            this.RevitListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.RevitListView.Location = new System.Drawing.Point(13, 111);
            this.RevitListView.Margin = new System.Windows.Forms.Padding(5);
            this.RevitListView.Name = "RevitListView";
            this.RevitListView.Size = new System.Drawing.Size(327, 313);
            this.RevitListView.TabIndex = 11;
            this.RevitListView.UseCompatibleStateImageBehavior = false;
            this.RevitListView.View = System.Windows.Forms.View.Details;
            // 
            // colRevitFiles
            // 
            this.colRevitFiles.Text = "Revit Files";
            this.colRevitFiles.Width = 300;
            // 
            // ExportBaseQuantitiesCheckBox
            // 
            this.ExportBaseQuantitiesCheckBox.AutoSize = true;
            this.ExportBaseQuantitiesCheckBox.Location = new System.Drawing.Point(399, 150);
            this.ExportBaseQuantitiesCheckBox.Name = "ExportBaseQuantitiesCheckBox";
            this.ExportBaseQuantitiesCheckBox.Size = new System.Drawing.Size(127, 17);
            this.ExportBaseQuantitiesCheckBox.TabIndex = 13;
            this.ExportBaseQuantitiesCheckBox.Text = "ExportBaseQuantities";
            this.ExportBaseQuantitiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // SplitWallsAndColumnsCheckBox
            // 
            this.SplitWallsAndColumnsCheckBox.AutoSize = true;
            this.SplitWallsAndColumnsCheckBox.Location = new System.Drawing.Point(399, 175);
            this.SplitWallsAndColumnsCheckBox.Name = "SplitWallsAndColumnsCheckBox";
            this.SplitWallsAndColumnsCheckBox.Size = new System.Drawing.Size(131, 17);
            this.SplitWallsAndColumnsCheckBox.TabIndex = 14;
            this.SplitWallsAndColumnsCheckBox.Text = "SplitWallsAndColumns";
            this.SplitWallsAndColumnsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportInternalRevitPropertySetsCheckBox
            // 
            this.ExportInternalRevitPropertySetsCheckBox.AutoSize = true;
            this.ExportInternalRevitPropertySetsCheckBox.Location = new System.Drawing.Point(399, 198);
            this.ExportInternalRevitPropertySetsCheckBox.Name = "ExportInternalRevitPropertySetsCheckBox";
            this.ExportInternalRevitPropertySetsCheckBox.Size = new System.Drawing.Size(176, 17);
            this.ExportInternalRevitPropertySetsCheckBox.TabIndex = 15;
            this.ExportInternalRevitPropertySetsCheckBox.Text = "ExportInternalRevitPropertySets";
            this.ExportInternalRevitPropertySetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportIFCCommonPropertySetsCheckBox
            // 
            this.ExportIFCCommonPropertySetsCheckBox.AutoSize = true;
            this.ExportIFCCommonPropertySetsCheckBox.Location = new System.Drawing.Point(399, 221);
            this.ExportIFCCommonPropertySetsCheckBox.Name = "ExportIFCCommonPropertySetsCheckBox";
            this.ExportIFCCommonPropertySetsCheckBox.Size = new System.Drawing.Size(173, 17);
            this.ExportIFCCommonPropertySetsCheckBox.TabIndex = 16;
            this.ExportIFCCommonPropertySetsCheckBox.Text = "ExportIFCCommonPropertySets";
            this.ExportIFCCommonPropertySetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Export2DElementsCheckBox
            // 
            this.Export2DElementsCheckBox.AutoSize = true;
            this.Export2DElementsCheckBox.Location = new System.Drawing.Point(399, 245);
            this.Export2DElementsCheckBox.Name = "Export2DElementsCheckBox";
            this.Export2DElementsCheckBox.Size = new System.Drawing.Size(113, 17);
            this.Export2DElementsCheckBox.TabIndex = 17;
            this.Export2DElementsCheckBox.Text = "Export2DElements";
            this.Export2DElementsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VisibleElementsOfCurrentViewCheckBox
            // 
            this.VisibleElementsOfCurrentViewCheckBox.AutoSize = true;
            this.VisibleElementsOfCurrentViewCheckBox.Location = new System.Drawing.Point(399, 269);
            this.VisibleElementsOfCurrentViewCheckBox.Name = "VisibleElementsOfCurrentViewCheckBox";
            this.VisibleElementsOfCurrentViewCheckBox.Size = new System.Drawing.Size(167, 17);
            this.VisibleElementsOfCurrentViewCheckBox.TabIndex = 18;
            this.VisibleElementsOfCurrentViewCheckBox.Text = "VisibleElementsOfCurrentView";
            this.VisibleElementsOfCurrentViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // Use2DRoomBoundaryForVolumeCheckBox
            // 
            this.Use2DRoomBoundaryForVolumeCheckBox.AutoSize = true;
            this.Use2DRoomBoundaryForVolumeCheckBox.Location = new System.Drawing.Point(399, 293);
            this.Use2DRoomBoundaryForVolumeCheckBox.Name = "Use2DRoomBoundaryForVolumeCheckBox";
            this.Use2DRoomBoundaryForVolumeCheckBox.Size = new System.Drawing.Size(182, 17);
            this.Use2DRoomBoundaryForVolumeCheckBox.TabIndex = 19;
            this.Use2DRoomBoundaryForVolumeCheckBox.Text = "Use2DRoomBoundaryForVolume";
            this.Use2DRoomBoundaryForVolumeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseFamilyAndTypeNameForReferenceCheckBox
            // 
            this.UseFamilyAndTypeNameForReferenceCheckBox.AutoSize = true;
            this.UseFamilyAndTypeNameForReferenceCheckBox.Location = new System.Drawing.Point(399, 317);
            this.UseFamilyAndTypeNameForReferenceCheckBox.Name = "UseFamilyAndTypeNameForReferenceCheckBox";
            this.UseFamilyAndTypeNameForReferenceCheckBox.Size = new System.Drawing.Size(210, 17);
            this.UseFamilyAndTypeNameForReferenceCheckBox.TabIndex = 20;
            this.UseFamilyAndTypeNameForReferenceCheckBox.Text = "UseFamilyAndTypeNameForReference";
            this.UseFamilyAndTypeNameForReferenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportPartsAsBuildingElementsCheckBox
            // 
            this.ExportPartsAsBuildingElementsCheckBox.AutoSize = true;
            this.ExportPartsAsBuildingElementsCheckBox.Location = new System.Drawing.Point(399, 341);
            this.ExportPartsAsBuildingElementsCheckBox.Name = "ExportPartsAsBuildingElementsCheckBox";
            this.ExportPartsAsBuildingElementsCheckBox.Size = new System.Drawing.Size(172, 17);
            this.ExportPartsAsBuildingElementsCheckBox.TabIndex = 21;
            this.ExportPartsAsBuildingElementsCheckBox.Text = "ExportPartsAsBuildingElements";
            this.ExportPartsAsBuildingElementsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportSolidModelRepCheckBox
            // 
            this.ExportSolidModelRepCheckBox.AutoSize = true;
            this.ExportSolidModelRepCheckBox.Location = new System.Drawing.Point(399, 365);
            this.ExportSolidModelRepCheckBox.Name = "ExportSolidModelRepCheckBox";
            this.ExportSolidModelRepCheckBox.Size = new System.Drawing.Size(128, 17);
            this.ExportSolidModelRepCheckBox.TabIndex = 22;
            this.ExportSolidModelRepCheckBox.Text = "ExportSolidModelRep";
            this.ExportSolidModelRepCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportSchedulesAsPsetsCheckBox
            // 
            this.ExportSchedulesAsPsetsCheckBox.AutoSize = true;
            this.ExportSchedulesAsPsetsCheckBox.Location = new System.Drawing.Point(399, 389);
            this.ExportSchedulesAsPsetsCheckBox.Name = "ExportSchedulesAsPsetsCheckBox";
            this.ExportSchedulesAsPsetsCheckBox.Size = new System.Drawing.Size(144, 17);
            this.ExportSchedulesAsPsetsCheckBox.TabIndex = 23;
            this.ExportSchedulesAsPsetsCheckBox.Text = "ExportSchedulesAsPsets";
            this.ExportSchedulesAsPsetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportUserDefinedPsetsCheckBox
            // 
            this.ExportUserDefinedPsetsCheckBox.AutoSize = true;
            this.ExportUserDefinedPsetsCheckBox.Location = new System.Drawing.Point(399, 412);
            this.ExportUserDefinedPsetsCheckBox.Name = "ExportUserDefinedPsetsCheckBox";
            this.ExportUserDefinedPsetsCheckBox.Size = new System.Drawing.Size(141, 17);
            this.ExportUserDefinedPsetsCheckBox.TabIndex = 24;
            this.ExportUserDefinedPsetsCheckBox.Text = "ExportUserDefinedPsets";
            this.ExportUserDefinedPsetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportUserDefinedParameterMappingCheckBox
            // 
            this.ExportUserDefinedParameterMappingCheckBox.AutoSize = true;
            this.ExportUserDefinedParameterMappingCheckBox.Location = new System.Drawing.Point(640, 412);
            this.ExportUserDefinedParameterMappingCheckBox.Name = "ExportUserDefinedParameterMappingCheckBox";
            this.ExportUserDefinedParameterMappingCheckBox.Size = new System.Drawing.Size(204, 17);
            this.ExportUserDefinedParameterMappingCheckBox.TabIndex = 26;
            this.ExportUserDefinedParameterMappingCheckBox.Text = "ExportUserDefinedParameterMapping";
            this.ExportUserDefinedParameterMappingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportBoundingBoxCheckBox
            // 
            this.ExportBoundingBoxCheckBox.AutoSize = true;
            this.ExportBoundingBoxCheckBox.Location = new System.Drawing.Point(640, 389);
            this.ExportBoundingBoxCheckBox.Name = "ExportBoundingBoxCheckBox";
            this.ExportBoundingBoxCheckBox.Size = new System.Drawing.Size(119, 17);
            this.ExportBoundingBoxCheckBox.TabIndex = 27;
            this.ExportBoundingBoxCheckBox.Text = "ExportBoundingBox";
            this.ExportBoundingBoxCheckBox.UseVisualStyleBackColor = true;
            // 
            // IncludeSiteElevationCheckBox
            // 
            this.IncludeSiteElevationCheckBox.AutoSize = true;
            this.IncludeSiteElevationCheckBox.Location = new System.Drawing.Point(640, 149);
            this.IncludeSiteElevationCheckBox.Name = "IncludeSiteElevationCheckBox";
            this.IncludeSiteElevationCheckBox.Size = new System.Drawing.Size(123, 17);
            this.IncludeSiteElevationCheckBox.TabIndex = 28;
            this.IncludeSiteElevationCheckBox.Text = "IncludeSiteElevation";
            this.IncludeSiteElevationCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseActiveViewGeometryCheckBox
            // 
            this.UseActiveViewGeometryCheckBox.AutoSize = true;
            this.UseActiveViewGeometryCheckBox.Location = new System.Drawing.Point(640, 173);
            this.UseActiveViewGeometryCheckBox.Name = "UseActiveViewGeometryCheckBox";
            this.UseActiveViewGeometryCheckBox.Size = new System.Drawing.Size(143, 17);
            this.UseActiveViewGeometryCheckBox.TabIndex = 29;
            this.UseActiveViewGeometryCheckBox.Text = "UseActiveViewGeometry";
            this.UseActiveViewGeometryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportSpecificSchedulesCheckBox
            // 
            this.ExportSpecificSchedulesCheckBox.AutoSize = true;
            this.ExportSpecificSchedulesCheckBox.Location = new System.Drawing.Point(640, 197);
            this.ExportSpecificSchedulesCheckBox.Name = "ExportSpecificSchedulesCheckBox";
            this.ExportSpecificSchedulesCheckBox.Size = new System.Drawing.Size(144, 17);
            this.ExportSpecificSchedulesCheckBox.TabIndex = 30;
            this.ExportSpecificSchedulesCheckBox.Text = "ExportSpecificSchedules";
            this.ExportSpecificSchedulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseOnlyTriangulationCheckBox
            // 
            this.UseOnlyTriangulationCheckBox.AutoSize = true;
            this.UseOnlyTriangulationCheckBox.Location = new System.Drawing.Point(640, 220);
            this.UseOnlyTriangulationCheckBox.Name = "UseOnlyTriangulationCheckBox";
            this.UseOnlyTriangulationCheckBox.Size = new System.Drawing.Size(127, 17);
            this.UseOnlyTriangulationCheckBox.TabIndex = 31;
            this.UseOnlyTriangulationCheckBox.Text = "UseOnlyTriangulation";
            this.UseOnlyTriangulationCheckBox.UseVisualStyleBackColor = true;
            // 
            // StoreIFCGUIDCheckBox
            // 
            this.StoreIFCGUIDCheckBox.AutoSize = true;
            this.StoreIFCGUIDCheckBox.Location = new System.Drawing.Point(640, 244);
            this.StoreIFCGUIDCheckBox.Name = "StoreIFCGUIDCheckBox";
            this.StoreIFCGUIDCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StoreIFCGUIDCheckBox.TabIndex = 32;
            this.StoreIFCGUIDCheckBox.Text = "StoreIFCGUID";
            this.StoreIFCGUIDCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportRoomsInViewCheckBox
            // 
            this.ExportRoomsInViewCheckBox.AutoSize = true;
            this.ExportRoomsInViewCheckBox.Location = new System.Drawing.Point(640, 269);
            this.ExportRoomsInViewCheckBox.Name = "ExportRoomsInViewCheckBox";
            this.ExportRoomsInViewCheckBox.Size = new System.Drawing.Size(121, 17);
            this.ExportRoomsInViewCheckBox.TabIndex = 33;
            this.ExportRoomsInViewCheckBox.Text = "ExportRoomsInView";
            this.ExportRoomsInViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportLinkedFilesCheckBox
            // 
            this.ExportLinkedFilesCheckBox.AutoSize = true;
            this.ExportLinkedFilesCheckBox.Location = new System.Drawing.Point(640, 293);
            this.ExportLinkedFilesCheckBox.Name = "ExportLinkedFilesCheckBox";
            this.ExportLinkedFilesCheckBox.Size = new System.Drawing.Size(109, 17);
            this.ExportLinkedFilesCheckBox.TabIndex = 34;
            this.ExportLinkedFilesCheckBox.Text = "ExportLinkedFiles";
            this.ExportLinkedFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExcludeFilterCheckBox
            // 
            this.ExcludeFilterCheckBox.AutoSize = true;
            this.ExcludeFilterCheckBox.Location = new System.Drawing.Point(640, 317);
            this.ExcludeFilterCheckBox.Name = "ExcludeFilterCheckBox";
            this.ExcludeFilterCheckBox.Size = new System.Drawing.Size(86, 17);
            this.ExcludeFilterCheckBox.TabIndex = 35;
            this.ExcludeFilterCheckBox.Text = "ExcludeFilter";
            this.ExcludeFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsBuiltInCheckBox
            // 
            this.IsBuiltInCheckBox.AutoSize = true;
            this.IsBuiltInCheckBox.Location = new System.Drawing.Point(640, 341);
            this.IsBuiltInCheckBox.Name = "IsBuiltInCheckBox";
            this.IsBuiltInCheckBox.Size = new System.Drawing.Size(63, 17);
            this.IsBuiltInCheckBox.TabIndex = 36;
            this.IsBuiltInCheckBox.Text = "IsBuiltIn";
            this.IsBuiltInCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsInSessionCheckBox
            // 
            this.IsInSessionCheckBox.AutoSize = true;
            this.IsInSessionCheckBox.Location = new System.Drawing.Point(640, 365);
            this.IsInSessionCheckBox.Name = "IsInSessionCheckBox";
            this.IsInSessionCheckBox.Size = new System.Drawing.Size(80, 17);
            this.IsInSessionCheckBox.TabIndex = 37;
            this.IsInSessionCheckBox.Text = "IsInSession";
            this.IsInSessionCheckBox.UseVisualStyleBackColor = true;
            // 
            // IFCVersionComboBox
            // 
            this.IFCVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFCVersionComboBox.FormattingEnabled = true;
            this.IFCVersionComboBox.Location = new System.Drawing.Point(468, 61);
            this.IFCVersionComboBox.Name = "IFCVersionComboBox";
            this.IFCVersionComboBox.Size = new System.Drawing.Size(182, 21);
            this.IFCVersionComboBox.TabIndex = 38;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "IFC Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "IFC Settings:";
            // 
            // IFCSettingsComboBox
            // 
            this.IFCSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFCSettingsComboBox.FormattingEnabled = true;
            this.IFCSettingsComboBox.Location = new System.Drawing.Point(468, 18);
            this.IFCSettingsComboBox.Name = "IFCSettingsComboBox";
            this.IFCSettingsComboBox.Size = new System.Drawing.Size(316, 21);
            this.IFCSettingsComboBox.TabIndex = 40;
            this.IFCSettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.IFCSettingsComboBox_SelectedIndexChanged);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(264, 81);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(75, 23);
            this.SelectAllButton.TabIndex = 41;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Active View";
            // 
            // ActiveViewComboBox
            // 
            this.ActiveViewComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveViewComboBox.FormattingEnabled = true;
            this.ActiveViewComboBox.Location = new System.Drawing.Point(468, 104);
            this.ActiveViewComboBox.Name = "ActiveViewComboBox";
            this.ActiveViewComboBox.Size = new System.Drawing.Size(182, 21);
            this.ActiveViewComboBox.TabIndex = 43;
            this.ActiveViewComboBox.SelectedIndexChanged += new System.EventHandler(this.ActiveViewComboBox_SelectedIndexChanged);
            // 
            // IFCExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 520);
            this.ControlBox = false;
            this.Controls.Add(this.ActiveViewComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.IFCSettingsComboBox);
            this.Controls.Add(this.IFCVersionComboBox);
            this.Controls.Add(this.IsInSessionCheckBox);
            this.Controls.Add(this.RevitListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IFCFilesTextBox);
            this.Controls.Add(this.IsBuiltInCheckBox);
            this.Controls.Add(this.BrowseIFCFilesButton);
            this.Controls.Add(this.ExportBaseQuantitiesCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExcludeFilterCheckBox);
            this.Controls.Add(this.RevitFilesTextBox);
            this.Controls.Add(this.SplitWallsAndColumnsCheckBox);
            this.Controls.Add(this.ExportLinkedFilesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportInternalRevitPropertySetsCheckBox);
            this.Controls.Add(this.BrowseRevitFilesButton);
            this.Controls.Add(this.ExportRoomsInViewCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.IncludeSiteElevationCheckBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StoreIFCGUIDCheckBox);
            this.Controls.Add(this.ExportPartsAsBuildingElementsCheckBox);
            this.Controls.Add(this.UseActiveViewGeometryCheckBox);
            this.Controls.Add(this.UseFamilyAndTypeNameForReferenceCheckBox);
            this.Controls.Add(this.UseOnlyTriangulationCheckBox);
            this.Controls.Add(this.ExportSolidModelRepCheckBox);
            this.Controls.Add(this.ExportSpecificSchedulesCheckBox);
            this.Controls.Add(this.Use2DRoomBoundaryForVolumeCheckBox);
            this.Controls.Add(this.ExportBoundingBoxCheckBox);
            this.Controls.Add(this.ExportSchedulesAsPsetsCheckBox);
            this.Controls.Add(this.ExportIFCCommonPropertySetsCheckBox);
            this.Controls.Add(this.VisibleElementsOfCurrentViewCheckBox);
            this.Controls.Add(this.ExportUserDefinedParameterMappingCheckBox);
            this.Controls.Add(this.ExportUserDefinedPsetsCheckBox);
            this.Controls.Add(this.Export2DElementsCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IFCExportForm";
            this.Text = "IFC Export Form";
            this.Load += new System.EventHandler(this.IFCExportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BrowseRevitFilesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RevitFilesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseIFCFilesButton;
        private System.Windows.Forms.TextBox IFCFilesTextBox;
        private System.Windows.Forms.ListView RevitListView;
        private System.Windows.Forms.CheckBox ExportBaseQuantitiesCheckBox;
        private System.Windows.Forms.CheckBox SplitWallsAndColumnsCheckBox;
        private System.Windows.Forms.CheckBox ExportInternalRevitPropertySetsCheckBox;
        private System.Windows.Forms.CheckBox ExportIFCCommonPropertySetsCheckBox;
        private System.Windows.Forms.CheckBox Export2DElementsCheckBox;
        private System.Windows.Forms.CheckBox VisibleElementsOfCurrentViewCheckBox;
        private System.Windows.Forms.CheckBox Use2DRoomBoundaryForVolumeCheckBox;
        private System.Windows.Forms.CheckBox UseFamilyAndTypeNameForReferenceCheckBox;
        private System.Windows.Forms.CheckBox ExportPartsAsBuildingElementsCheckBox;
        private System.Windows.Forms.CheckBox ExportSolidModelRepCheckBox;
        private System.Windows.Forms.CheckBox ExportSchedulesAsPsetsCheckBox;
        private System.Windows.Forms.CheckBox ExportUserDefinedPsetsCheckBox;
        private System.Windows.Forms.CheckBox ExportUserDefinedParameterMappingCheckBox;
        private System.Windows.Forms.CheckBox ExportBoundingBoxCheckBox;
        private System.Windows.Forms.CheckBox IncludeSiteElevationCheckBox;
        private System.Windows.Forms.CheckBox UseActiveViewGeometryCheckBox;
        private System.Windows.Forms.CheckBox ExportSpecificSchedulesCheckBox;
        private System.Windows.Forms.CheckBox UseOnlyTriangulationCheckBox;
        private System.Windows.Forms.CheckBox StoreIFCGUIDCheckBox;
        private System.Windows.Forms.CheckBox ExportRoomsInViewCheckBox;
        private System.Windows.Forms.CheckBox ExportLinkedFilesCheckBox;
        private System.Windows.Forms.CheckBox ExcludeFilterCheckBox;
        private System.Windows.Forms.CheckBox IsBuiltInCheckBox;
        private System.Windows.Forms.CheckBox IsInSessionCheckBox;
        private System.Windows.Forms.ComboBox IFCVersionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IFCSettingsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ActiveViewComboBox;
        private System.Windows.Forms.ColumnHeader colRevitFiles;
    }
}