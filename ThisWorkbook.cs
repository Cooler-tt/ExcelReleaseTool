using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;


namespace ExcelReleaseTool
{
    public partial class ThisWorkbook
    {
        private ActionsPaneControl_MessageInfo apc_MI = new ActionsPaneControl_MessageInfo();
        //private ReleaseTool_Ribbon r1 = new ReleaseTool_Ribbon();


        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            ActionsPane.Clear();
            this.ActionsPane.Controls.Add(apc_MI);
            Excel.Worksheet wst;
            wst = Application.ActiveSheet;
            
            //string[] daysOfWeek = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //r1.InputUPC_comboBox.Text = daysOfWeek[0];
            //r1.
            //apc_MI.SetPPCFile("K228 S&O.xlsx", "D:\\K228\\system release\\");
            //InitActionsPane();
            //this.ActionsPane.Visible = true;
            //Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
        }
        

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {

        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

        //private void InitActionsPane()
        //{
        //    Globals.ThisWorkbook.ActionsPane.Clear();
        //    Globals.ThisWorkbook.ActionsPane.Visible = true;
        //    Globals.ThisWorkbook.ActionsPane.AutoRecover = true;
        //    Globals.ThisWorkbook.ActionsPane.OrientationChanged +=
        //        new EventHandler(ActionsPane_OrientationChanged);
        //    ResetStackOrder();

        //    // Create the button that will update the stack order.
        //    Button button1 = new Button();
        //    button1.Text = "Change stack order";
        //    button1.Click += new EventHandler(button1_Click);

        //    // Create two more buttons that do nothing.
        //    Button button2 = new Button();
        //    button2.Text = "Button 2";
        //    Button button3 = new Button();
        //    button3.Text = "Button 3";

        //    Globals.ThisWorkbook.ActionsPane.Controls.AddRange(
        //        new Control[] { button1, button2, button3 });
        //}

        //// Switch the stack order according to the current orientation.
        //void button1_Click(object sender, EventArgs e)
        //{
        //    if (Globals.ThisWorkbook.ActionsPane.Orientation ==
        //        Orientation.Horizontal)
        //    {
        //        if (Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //            Microsoft.Office.Tools.StackStyle.FromLeft)
        //        {
        //            Globals.ThisWorkbook.ActionsPane.StackOrder =
        //                Microsoft.Office.Tools.StackStyle.FromRight;
        //        }
        //        else
        //        {
        //            Globals.ThisWorkbook.ActionsPane.StackOrder =
        //                Microsoft.Office.Tools.StackStyle.FromLeft;
        //        }
        //    }
        //    else
        //    {
        //        if (Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //            Microsoft.Office.Tools.StackStyle.FromTop)
        //        {
        //            Globals.ThisWorkbook.ActionsPane.StackOrder =
        //                Microsoft.Office.Tools.StackStyle.FromBottom;
        //        }
        //        else
        //        {
        //            Globals.ThisWorkbook.ActionsPane.StackOrder =
        //                Microsoft.Office.Tools.StackStyle.FromTop;
        //        }
        //    }
        //}

        //void ActionsPane_OrientationChanged(object sender, EventArgs e )
        //{
        //    ResetStackOrder();
        //}

        //// Readjust the stack order so that it matches the current orientation.
        //void ResetStackOrder()
        //{
        //    if (Globals.ThisWorkbook.ActionsPane.Orientation ==
        //        Orientation.Horizontal &&
        //       (Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //           Microsoft.Office.Tools.StackStyle.FromTop ||
        //        Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //           Microsoft.Office.Tools.StackStyle.FromBottom))
        //    {
        //        Globals.ThisWorkbook.ActionsPane.StackOrder =
        //            Microsoft.Office.Tools.StackStyle.FromLeft;
        //    }

        //    if (Globals.ThisWorkbook.ActionsPane.Orientation ==
        //        Orientation.Vertical &&
        //       (Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //           Microsoft.Office.Tools.StackStyle.FromLeft ||
        //        Globals.ThisWorkbook.ActionsPane.StackOrder ==
        //           Microsoft.Office.Tools.StackStyle.FromRight))
        //    {
        //        Globals.ThisWorkbook.ActionsPane.StackOrder =
        //            Microsoft.Office.Tools.StackStyle.FromTop;
        //    }
        //}

    }
}
