using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace SetReportPageSettings
{
    public partial class ThisAddIn
    {
        pageSetupFinished psf;

        List<Excel.Worksheet> myWorksheets;

        XDocument xmlFile;
        String xmlFilePath = @"C:\Excel Addins\customHeaders.xml";

        String headerText = "";

        public void runInitialSetup()
        {
            psf = new pageSetupFinished();
            myWorksheets = new List<Excel.Worksheet>();

            Excel.Application exApp = Application;
            Excel.PageSetup ps;

            /*
                Initializes XML file - if it doesn't exist, create otherwise get the file
            */

            FileInfo xmlFileInfo = new FileInfo(xmlFilePath);
            xmlFileInfo.Directory.Create();


            if (!File.Exists(xmlFilePath))
            {
                xmlFile = new XDocument(new XElement("root", new XElement("CustomHeaders")));
                xmlFile.Save(xmlFilePath);
            }
            else
            {
                xmlFile = XDocument.Load(xmlFilePath);
                
                foreach (XElement elem in xmlFile.Root.Element("CustomHeaders").Elements())
                {
                    psf.customHeaderList.Items.Add(elem.Value);
                }
            }


            /*
                Set page setup for all worksheets in the workbook
            */
            foreach (Excel.Worksheet ws in exApp.ActiveWorkbook.Worksheets)
            {
                myWorksheets.Add(ws);

                psf.headerWorksheetList.Items.Add(ws.Name);

                ps = ws.PageSetup;

                ps.FitToPagesWide = 1;
                ps.FitToPagesTall = 1;
                ps.LeftMargin = 0;
                ps.RightMargin = 0;
                ps.CenterHorizontally = true;
                ps.CenterVertically = false;
                ps.PrintGridlines = true;
                ps.CenterFooter = "Page &P of &N";
            }

            psf.Show();
        }
        
        public void saveHeader(string header)
        {
            xmlFile.Root.Element("CustomHeaders").Add(new XElement("header", header));
            xmlFile.Save(xmlFilePath);
            headerText = header;
            System.Windows.Forms.MessageBox.Show("Header saved.");
        }

        public void deleteHeader(string header)
        {
            header = header.Trim();
            xmlFile.Descendants("CustomHeaders")
                .Elements("header")
                .Where(x => x.Value == header)
                .Remove();
            xmlFile.Save(xmlFilePath);
            System.Windows.Forms.MessageBox.Show("Header deleted.");
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
