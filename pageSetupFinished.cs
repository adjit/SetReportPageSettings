using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetReportPageSettings
{
    public partial class pageSetupFinished : Form
    {
        public pageSetupFinished()
        {
            InitializeComponent();
        }

        private void saveHeader_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.saveHeader(customHeaderList.Text);
        }

        private void deleteHeader_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.deleteHeader(customHeaderList.Text);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.ThisAddIn.motivateAlan();
        }

        private void setThisWorksheet_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.setWorksheet();
        }
    }
}
