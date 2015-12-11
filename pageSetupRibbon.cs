using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace SetReportPageSettings
{
    public partial class pageSetupRibbon
    {
        private void pageSetupRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void setPageSetup_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.runInitialSetup();
        }
    }
}
