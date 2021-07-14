using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace ExcelReleaseTool
{
    public partial class Sheet1
    {
        //private ReleaseTool_Ribbon r2 = new ReleaseTool_Ribbon();
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
           
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.Sheet1_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);
            this.Change += new Microsoft.Office.Interop.Excel.DocEvents_ChangeEventHandler(this.Sheet1_Change);

        }

        #endregion

        private void Sheet1_Change(Excel.Range Target)
        {
            if (Target.Address == "B1")
            {
                Globals.Ribbons.Ribbon1.InputUPC_comboBox.Text = "sheetChanged";
            }
        }
    }
}
