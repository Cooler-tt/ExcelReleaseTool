
namespace ExcelReleaseTool
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class ActionsPaneControl_MessageInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionsPaneControl_MessageInfo));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PPC_checkBox = new System.Windows.Forms.CheckBox();
            this.uBom_checkBox = new System.Windows.Forms.CheckBox();
            this.pBom_checkBox = new System.Windows.Forms.CheckBox();
            this.LMO_checkBox = new System.Windows.Forms.CheckBox();
            this.PPC_textBox = new System.Windows.Forms.TextBox();
            this.uBom_textBox = new System.Windows.Forms.TextBox();
            this.pBom_textBox = new System.Windows.Forms.TextBox();
            this.LMO_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PPC_checkBox
            // 
            resources.ApplyResources(this.PPC_checkBox, "PPC_checkBox");
            this.PPC_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PPC_checkBox.Name = "PPC_checkBox";
            this.PPC_checkBox.UseVisualStyleBackColor = true;
            // 
            // uBom_checkBox
            // 
            resources.ApplyResources(this.uBom_checkBox, "uBom_checkBox");
            this.uBom_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uBom_checkBox.Name = "uBom_checkBox";
            this.uBom_checkBox.UseVisualStyleBackColor = true;
            this.uBom_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pBom_checkBox
            // 
            resources.ApplyResources(this.pBom_checkBox, "pBom_checkBox");
            this.pBom_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBom_checkBox.Name = "pBom_checkBox";
            this.pBom_checkBox.UseVisualStyleBackColor = true;
            // 
            // LMO_checkBox
            // 
            resources.ApplyResources(this.LMO_checkBox, "LMO_checkBox");
            this.LMO_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LMO_checkBox.Name = "LMO_checkBox";
            this.LMO_checkBox.UseVisualStyleBackColor = true;
            // 
            // PPC_textBox
            // 
            this.PPC_textBox.AllowDrop = true;
            this.PPC_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPC_textBox.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.PPC_textBox, "PPC_textBox");
            this.PPC_textBox.Name = "PPC_textBox";
            this.PPC_textBox.ReadOnly = true;
            this.PPC_textBox.TextChanged += new System.EventHandler(this.PPC_textBox_TextChanged);
            // 
            // uBom_textBox
            // 
            resources.ApplyResources(this.uBom_textBox, "uBom_textBox");
            this.uBom_textBox.Name = "uBom_textBox";
            this.uBom_textBox.ReadOnly = true;
            // 
            // pBom_textBox
            // 
            resources.ApplyResources(this.pBom_textBox, "pBom_textBox");
            this.pBom_textBox.Name = "pBom_textBox";
            this.pBom_textBox.ReadOnly = true;
            // 
            // LMO_textBox
            // 
            resources.ApplyResources(this.LMO_textBox, "LMO_textBox");
            this.LMO_textBox.Name = "LMO_textBox";
            this.LMO_textBox.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ActionsPaneControl_MessageInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LMO_textBox);
            this.Controls.Add(this.pBom_textBox);
            this.Controls.Add(this.uBom_textBox);
            this.Controls.Add(this.PPC_textBox);
            this.Controls.Add(this.LMO_checkBox);
            this.Controls.Add(this.pBom_checkBox);
            this.Controls.Add(this.uBom_checkBox);
            this.Controls.Add(this.PPC_checkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ActionsPaneControl_MessageInfo";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.ActionsPaneControl_MessageInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PPC_checkBox;
        private System.Windows.Forms.CheckBox uBom_checkBox;
        private System.Windows.Forms.CheckBox pBom_checkBox;
        private System.Windows.Forms.CheckBox LMO_checkBox;
        private System.Windows.Forms.TextBox LMO_textBox;
        private System.Windows.Forms.TextBox pBom_textBox;
        private System.Windows.Forms.TextBox uBom_textBox;
        private System.Windows.Forms.TextBox PPC_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
