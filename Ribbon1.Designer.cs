
namespace ExcelReleaseTool
{
    partial class ReleaseTool_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ReleaseTool_Ribbon()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseTool_Ribbon));
            this.ReleaseTool_tab = this.Factory.CreateRibbonTab();
            this.ImportFile_group = this.Factory.CreateRibbonGroup();
            this.ImportFileButton_box = this.Factory.CreateRibbonBox();
            this.ImportPPC_button = this.Factory.CreateRibbonButton();
            this.ImportUBom_button = this.Factory.CreateRibbonButton();
            this.ImportLMO_button = this.Factory.CreateRibbonButton();
            this.ImportPBom_button = this.Factory.CreateRibbonButton();
            this.Input_group = this.Factory.CreateRibbonGroup();
            this.InputButton_box = this.Factory.CreateRibbonBox();
            this.InputUPC_comboBox = this.Factory.CreateRibbonComboBox();
            this.InputFNA_comboBox = this.Factory.CreateRibbonComboBox();
            this.InputCode_comboBox = this.Factory.CreateRibbonComboBox();
            this.Function_group = this.Factory.CreateRibbonGroup();
            this.FunctionButton_box = this.Factory.CreateRibbonBox();
            this.releaseCheck_button = this.Factory.CreateRibbonButton();
            this.AutoRelease_button = this.Factory.CreateRibbonButton();
            this.BomCheck_button = this.Factory.CreateRibbonButton();
            this.AssistTool_group = this.Factory.CreateRibbonGroup();
            this.AssistToolButton_box = this.Factory.CreateRibbonBox();
            this.MessageInfoShow_toggleButton = this.Factory.CreateRibbonToggleButton();
            this.ExportResult_button = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.ReleaseTool_tab.SuspendLayout();
            this.ImportFile_group.SuspendLayout();
            this.ImportFileButton_box.SuspendLayout();
            this.Input_group.SuspendLayout();
            this.InputButton_box.SuspendLayout();
            this.Function_group.SuspendLayout();
            this.FunctionButton_box.SuspendLayout();
            this.AssistTool_group.SuspendLayout();
            this.AssistToolButton_box.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReleaseTool_tab
            // 
            this.ReleaseTool_tab.Groups.Add(this.ImportFile_group);
            this.ReleaseTool_tab.Groups.Add(this.Input_group);
            this.ReleaseTool_tab.Groups.Add(this.Function_group);
            this.ReleaseTool_tab.Groups.Add(this.AssistTool_group);
            this.ReleaseTool_tab.Groups.Add(this.group1);
            this.ReleaseTool_tab.Label = "ReleaseTool";
            this.ReleaseTool_tab.Name = "ReleaseTool_tab";
            // 
            // ImportFile_group
            // 
            this.ImportFile_group.Items.Add(this.ImportFileButton_box);
            this.ImportFile_group.Label = "Import File";
            this.ImportFile_group.Name = "ImportFile_group";
            // 
            // ImportFileButton_box
            // 
            this.ImportFileButton_box.Items.Add(this.ImportPPC_button);
            this.ImportFileButton_box.Items.Add(this.ImportUBom_button);
            this.ImportFileButton_box.Items.Add(this.ImportLMO_button);
            this.ImportFileButton_box.Items.Add(this.ImportPBom_button);
            this.ImportFileButton_box.Name = "ImportFileButton_box";
            // 
            // ImportPPC_button
            // 
            this.ImportPPC_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ImportPPC_button.Image = ((System.Drawing.Image)(resources.GetObject("ImportPPC_button.Image")));
            this.ImportPPC_button.Label = "PPC";
            this.ImportPPC_button.Name = "ImportPPC_button";
            this.ImportPPC_button.ShowImage = true;
            this.ImportPPC_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Import_button_Click);
            // 
            // ImportUBom_button
            // 
            this.ImportUBom_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ImportUBom_button.Image = ((System.Drawing.Image)(resources.GetObject("ImportUBom_button.Image")));
            this.ImportUBom_button.Label = "uBOM";
            this.ImportUBom_button.Name = "ImportUBom_button";
            this.ImportUBom_button.ShowImage = true;
            this.ImportUBom_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Import_button_Click);
            // 
            // ImportLMO_button
            // 
            this.ImportLMO_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ImportLMO_button.Image = ((System.Drawing.Image)(resources.GetObject("ImportLMO_button.Image")));
            this.ImportLMO_button.Label = "LMO";
            this.ImportLMO_button.Name = "ImportLMO_button";
            this.ImportLMO_button.ShowImage = true;
            this.ImportLMO_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Import_button_Click);
            // 
            // ImportPBom_button
            // 
            this.ImportPBom_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ImportPBom_button.Image = ((System.Drawing.Image)(resources.GetObject("ImportPBom_button.Image")));
            this.ImportPBom_button.Label = "pBOM";
            this.ImportPBom_button.Name = "ImportPBom_button";
            this.ImportPBom_button.ShowImage = true;
            this.ImportPBom_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Import_button_Click);
            // 
            // Input_group
            // 
            this.Input_group.Items.Add(this.InputButton_box);
            this.Input_group.Label = "Input Required";
            this.Input_group.Name = "Input_group";
            // 
            // InputButton_box
            // 
            this.InputButton_box.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.InputButton_box.Items.Add(this.InputUPC_comboBox);
            this.InputButton_box.Items.Add(this.InputFNA_comboBox);
            this.InputButton_box.Items.Add(this.InputCode_comboBox);
            this.InputButton_box.Name = "InputButton_box";
            // 
            // InputUPC_comboBox
            // 
            this.InputUPC_comboBox.Label = "UPC";
            this.InputUPC_comboBox.Name = "InputUPC_comboBox";
            this.InputUPC_comboBox.Text = null;
            // 
            // InputFNA_comboBox
            // 
            this.InputFNA_comboBox.Label = "FNA";
            this.InputFNA_comboBox.Name = "InputFNA_comboBox";
            this.InputFNA_comboBox.Text = null;
            this.InputFNA_comboBox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.comboBox2_TextChanged);
            // 
            // InputCode_comboBox
            // 
            this.InputCode_comboBox.Label = "Code";
            this.InputCode_comboBox.Name = "InputCode_comboBox";
            this.InputCode_comboBox.Text = null;
            // 
            // Function_group
            // 
            this.Function_group.Items.Add(this.FunctionButton_box);
            this.Function_group.Label = "Functions";
            this.Function_group.Name = "Function_group";
            // 
            // FunctionButton_box
            // 
            this.FunctionButton_box.Items.Add(this.releaseCheck_button);
            this.FunctionButton_box.Items.Add(this.AutoRelease_button);
            this.FunctionButton_box.Items.Add(this.BomCheck_button);
            this.FunctionButton_box.Name = "FunctionButton_box";
            // 
            // releaseCheck_button
            // 
            this.releaseCheck_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.releaseCheck_button.Image = ((System.Drawing.Image)(resources.GetObject("releaseCheck_button.Image")));
            this.releaseCheck_button.Label = "释放检查";
            this.releaseCheck_button.Name = "releaseCheck_button";
            this.releaseCheck_button.ShowImage = true;
            this.releaseCheck_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.releaseCheck_button_Click);
            // 
            // AutoRelease_button
            // 
            this.AutoRelease_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AutoRelease_button.Image = ((System.Drawing.Image)(resources.GetObject("AutoRelease_button.Image")));
            this.AutoRelease_button.Label = "自动释放";
            this.AutoRelease_button.Name = "AutoRelease_button";
            this.AutoRelease_button.ShowImage = true;
            // 
            // BomCheck_button
            // 
            this.BomCheck_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BomCheck_button.Image = ((System.Drawing.Image)(resources.GetObject("BomCheck_button.Image")));
            this.BomCheck_button.Label = "BOM检查";
            this.BomCheck_button.Name = "BomCheck_button";
            this.BomCheck_button.ShowImage = true;
            // 
            // AssistTool_group
            // 
            this.AssistTool_group.Items.Add(this.AssistToolButton_box);
            this.AssistTool_group.Label = "Assist Tool";
            this.AssistTool_group.Name = "AssistTool_group";
            // 
            // AssistToolButton_box
            // 
            this.AssistToolButton_box.Items.Add(this.MessageInfoShow_toggleButton);
            this.AssistToolButton_box.Items.Add(this.ExportResult_button);
            this.AssistToolButton_box.Name = "AssistToolButton_box";
            // 
            // MessageInfoShow_toggleButton
            // 
            this.MessageInfoShow_toggleButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.MessageInfoShow_toggleButton.Image = ((System.Drawing.Image)(resources.GetObject("MessageInfoShow_toggleButton.Image")));
            this.MessageInfoShow_toggleButton.Label = "显示/隐藏消息";
            this.MessageInfoShow_toggleButton.Name = "MessageInfoShow_toggleButton";
            this.MessageInfoShow_toggleButton.ShowImage = true;
            this.MessageInfoShow_toggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MessageInfoShow_toggleButton_Click);
            // 
            // ExportResult_button
            // 
            this.ExportResult_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ExportResult_button.Image = ((System.Drawing.Image)(resources.GetObject("ExportResult_button.Image")));
            this.ExportResult_button.Label = "导出结果";
            this.ExportResult_button.Name = "ExportResult_button";
            this.ExportResult_button.ShowImage = true;
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Label = "button2";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // ReleaseTool_Ribbon
            // 
            this.Name = "ReleaseTool_Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ReleaseTool_tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.ReleaseTool_tab.ResumeLayout(false);
            this.ReleaseTool_tab.PerformLayout();
            this.ImportFile_group.ResumeLayout(false);
            this.ImportFile_group.PerformLayout();
            this.ImportFileButton_box.ResumeLayout(false);
            this.ImportFileButton_box.PerformLayout();
            this.Input_group.ResumeLayout(false);
            this.Input_group.PerformLayout();
            this.InputButton_box.ResumeLayout(false);
            this.InputButton_box.PerformLayout();
            this.Function_group.ResumeLayout(false);
            this.Function_group.PerformLayout();
            this.FunctionButton_box.ResumeLayout(false);
            this.FunctionButton_box.PerformLayout();
            this.AssistTool_group.ResumeLayout(false);
            this.AssistTool_group.PerformLayout();
            this.AssistToolButton_box.ResumeLayout(false);
            this.AssistToolButton_box.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ReleaseTool_tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ImportFile_group;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox ImportFileButton_box;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportPPC_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportUBom_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportLMO_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Input_group;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox InputUPC_comboBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Function_group;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox InputButton_box;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox InputFNA_comboBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox InputCode_comboBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportPBom_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox FunctionButton_box;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton releaseCheck_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AutoRelease_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BomCheck_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AssistTool_group;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox AssistToolButton_box;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ExportResult_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton MessageInfoShow_toggleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
    }

    partial class ThisRibbonCollection
    {
        internal ReleaseTool_Ribbon Ribbon1
        {
            get { return this.GetRibbon<ReleaseTool_Ribbon>(); }
        }
    }
}
