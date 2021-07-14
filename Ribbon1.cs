using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.VisualStudio.Tools.Applications.Runtime;


namespace ExcelReleaseTool
{
    public partial class ReleaseTool_Ribbon
    {
        //private ImFile ppcFile;
        private PPCFile ppcFile;
        private UBomFile uBomFile;
        private PBomFile pBomFile;
        private LMOFile lmoFile;
        //private List<ImFile> imFiles;

        private void test()
        {
            if (ppcFile == null)
            {
                MessageBox.Show("未导入文件！");
            }
            else
            {
                MessageBox.Show(ppcFile.FileName);
            }
        }
        public void test1()
        {
            MessageBox.Show(InputUPC_comboBox.Label);
        }
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
            //this.MessageInfoShow_toggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MessageInfoShow_toggleButton_Click);

        }
        public PPCFile getPPCObj()
        {

            return ppcFile;
        }
        public LMOFile getLMOObj()
        {

            return lmoFile;
        }
        public PBomFile getPBomObj()
        {

            return pBomFile;
        }
        public UBomFile getUBomObj()
        {

            return uBomFile;
        }
        private void comboBox2_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void MessageInfoShow_toggleButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (MessageInfoShow_toggleButton.Checked == true)
            {
                Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
            }
            if(MessageInfoShow_toggleButton.Checked == false)
            {
                Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
            }
        }

        private void Import_button_Click(object sender, RibbonControlEventArgs e)
        {

            string fileDir = "", finalFileName = "";
            int fileNameIndex = 0;

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel文件|*.xls;*.xlsx;*.xlsm";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileDir = openDialog.FileName;
            }
            else
                return;
            //fileDir 文件路径+文件名 完全体
            //finalaFileName 仅文件名
            fileNameIndex = fileDir.LastIndexOf("\\") + 1;
            finalFileName = fileDir.Substring(fileNameIndex);
            Globals.Sheet1.Range["B1"].Value2 = fileDir;
            Globals.Sheet1.Range["B2"].Value2 = finalFileName;
            //MessageBox.Show(fileDir);
            //MessageBox.Show(finalFileName);
            string btnName = ((RibbonButton)sender).Id;
            //MessageBox.Show(btnName);
            switch (btnName)
            {
                case "ImportPPC_button":
                    ppcFile = new PPCFile();
                    //MessageBox.Show(ppcFile.GetType().ToString());
                    //MessageBox.Show(fileDir);
                    ppcFile.fileContentCheck();
                    ppcFile.FileName = finalFileName;
                    PPCFile.FileDir = fileDir;
                    Globals.Sheet1.Range["A5"].Value2 = "PPC文件名";
                    Globals.Sheet1.Range["B5"].Value2 = ppcFile.FileName;
                    break;
                case "ImportUBom_button":
                    uBomFile = new UBomFile();
                    uBomFile.fileContentCheck();
                    uBomFile.FileName = finalFileName;
                    UBomFile.FileDir = fileDir;
                    Globals.Sheet1.Range["A6"].Value2 = "UBom文件名";
                    Globals.Sheet1.Range["B6"].Value2 = uBomFile.FileName;
                    break;
                case "ImportPBom_button":
                    pBomFile = new PBomFile();
                    pBomFile.fileContentCheck();
                    pBomFile.FileName = finalFileName;
                    PBomFile.FileDir = fileDir;
                    Globals.Sheet1.Range["A7"].Value2 = "PBom文件名";
                    Globals.Sheet1.Range["B7"].Value2 = pBomFile.FileName;
                    break;
                case "ImportLMO_button":
                    lmoFile = new LMOFile();
                    lmoFile.fileContentCheck();
                    lmoFile.FileName = finalFileName;
                    LMOFile.FileDir = fileDir;
                    Globals.Sheet1.Range["A8"].Value2 = "LMO文件名";
                    Globals.Sheet1.Range["B8"].Value2 = lmoFile.FileName;
                    break;
            }
        }

        private void releaseCheck_button_Click(object sender, RibbonControlEventArgs e)
        {
            test();
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            this.InputUPC_comboBox.Text = "按键1点击";
            
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet wst;
            
            
        }
    }
    
}
