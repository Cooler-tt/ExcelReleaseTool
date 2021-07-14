using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace ExcelReleaseTool
{
    partial class ActionsPaneControl_MessageInfo : UserControl
    {
        //PPCDir ppcDir = null;
        public ActionsPaneControl_MessageInfo()
        {
            InitializeComponent();
            //this.addText_button.Click += new EventHandler(addText_button_Click);
        }
        private void ActionsPaneControl_MessageInfo_Load(object sender, EventArgs e)
        {
            //ppcDir = new PPCDir("K228 S&O.xlsm  D:\\K228\\");
            //PPC_textBox.DataBindings.Add(new Binding("Text", ppcDir, "FileDir", false, DataSourceUpdateMode.Never));
            //ppcDir.FileDir= "K229 S&O.xlsm  D:\\K229\\";
        }
        public void SetPPCFile(PPCFile ppcFile)
        {
            PPC_textBox.DataBindings.Add(new Binding("Text", ppcFile, "FileDir", false, DataSourceUpdateMode.Never));
            //this.PPC_checkBox.Enabled = false;
            //this.PPC_textBox.ReadOnly = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PPC_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
