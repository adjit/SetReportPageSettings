namespace SetReportPageSettings
{
    partial class pageSetupRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public pageSetupRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customPageSetupTab = this.Factory.CreateRibbonTab();
            this.customPageSetupGroup = this.Factory.CreateRibbonGroup();
            this.setPageSetup = this.Factory.CreateRibbonButton();
            this.customPageSetupTab.SuspendLayout();
            this.customPageSetupGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPageSetupTab
            // 
            this.customPageSetupTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.customPageSetupTab.Groups.Add(this.customPageSetupGroup);
            this.customPageSetupTab.Label = "Custom Page Setup";
            this.customPageSetupTab.Name = "customPageSetupTab";
            // 
            // customPageSetupGroup
            // 
            this.customPageSetupGroup.Items.Add(this.setPageSetup);
            this.customPageSetupGroup.Label = "Custom Page Setup";
            this.customPageSetupGroup.Name = "customPageSetupGroup";
            // 
            // setPageSetup
            // 
            this.setPageSetup.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.setPageSetup.Image = global::SetReportPageSettings.Properties.Resources.Page_setup_icon;
            this.setPageSetup.Label = "Set Page Setup";
            this.setPageSetup.Name = "setPageSetup";
            this.setPageSetup.ShowImage = true;
            this.setPageSetup.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.setPageSetup_Click);
            // 
            // pageSetupRibbon
            // 
            this.Name = "pageSetupRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.customPageSetupTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.pageSetupRibbon_Load);
            this.customPageSetupTab.ResumeLayout(false);
            this.customPageSetupTab.PerformLayout();
            this.customPageSetupGroup.ResumeLayout(false);
            this.customPageSetupGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab customPageSetupTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup customPageSetupGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton setPageSetup;
    }

    partial class ThisRibbonCollection
    {
        internal pageSetupRibbon pageSetupRibbon
        {
            get { return this.GetRibbon<pageSetupRibbon>(); }
        }
    }
}
