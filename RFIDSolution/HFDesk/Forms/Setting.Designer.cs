namespace HFDesk
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCSV = new System.Windows.Forms.TabPage();
            this.btnCVSSelect = new System.Windows.Forms.Button();
            this.txtCSVPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccess = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCsv = new System.Windows.Forms.RadioButton();
            this.rdbAccess = new System.Windows.Forms.RadioButton();
            this.btnAccessSelect = new System.Windows.Forms.Button();
            this.txtAccessPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabCSV.SuspendLayout();
            this.tabAccess.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(816, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据源配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabCSV);
            this.tabControl2.Controls.Add(this.tabAccess);
            this.tabControl2.Location = new System.Drawing.Point(8, 71);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(799, 292);
            this.tabControl2.TabIndex = 1;
            // 
            // tabCSV
            // 
            this.tabCSV.Controls.Add(this.btnCVSSelect);
            this.tabCSV.Controls.Add(this.txtCSVPath);
            this.tabCSV.Controls.Add(this.label1);
            this.tabCSV.Location = new System.Drawing.Point(4, 25);
            this.tabCSV.Name = "tabCSV";
            this.tabCSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabCSV.Size = new System.Drawing.Size(791, 263);
            this.tabCSV.TabIndex = 0;
            this.tabCSV.Text = "CSV";
            this.tabCSV.UseVisualStyleBackColor = true;
            // 
            // btnCVSSelect
            // 
            this.btnCVSSelect.Location = new System.Drawing.Point(453, 72);
            this.btnCVSSelect.Name = "btnCVSSelect";
            this.btnCVSSelect.Size = new System.Drawing.Size(75, 25);
            this.btnCVSSelect.TabIndex = 2;
            this.btnCVSSelect.Text = "选择";
            this.btnCVSSelect.UseVisualStyleBackColor = true;
            this.btnCVSSelect.Click += new System.EventHandler(this.btnCVSSelect_Click);
            // 
            // txtCSVPath
            // 
            this.txtCSVPath.Location = new System.Drawing.Point(54, 72);
            this.txtCSVPath.Name = "txtCSVPath";
            this.txtCSVPath.Size = new System.Drawing.Size(384, 25);
            this.txtCSVPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSV文件路径：";
            // 
            // tabAccess
            // 
            this.tabAccess.Controls.Add(this.btnAccessSelect);
            this.tabAccess.Controls.Add(this.txtAccessPath);
            this.tabAccess.Controls.Add(this.label2);
            this.tabAccess.Location = new System.Drawing.Point(4, 25);
            this.tabAccess.Name = "tabAccess";
            this.tabAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccess.Size = new System.Drawing.Size(791, 263);
            this.tabAccess.TabIndex = 1;
            this.tabAccess.Text = "Access";
            this.tabAccess.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAccess);
            this.groupBox1.Controls.Add(this.rdbCsv);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码数据来源";
            // 
            // rdbCsv
            // 
            this.rdbCsv.AutoSize = true;
            this.rdbCsv.Location = new System.Drawing.Point(87, 24);
            this.rdbCsv.Name = "rdbCsv";
            this.rdbCsv.Size = new System.Drawing.Size(52, 19);
            this.rdbCsv.TabIndex = 0;
            this.rdbCsv.TabStop = true;
            this.rdbCsv.Text = "csv";
            this.rdbCsv.UseVisualStyleBackColor = true;
            this.rdbCsv.Click += new System.EventHandler(this.rdbCsv_Click);
            // 
            // rdbAccess
            // 
            this.rdbAccess.AutoSize = true;
            this.rdbAccess.Location = new System.Drawing.Point(145, 24);
            this.rdbAccess.Name = "rdbAccess";
            this.rdbAccess.Size = new System.Drawing.Size(76, 19);
            this.rdbAccess.TabIndex = 1;
            this.rdbAccess.TabStop = true;
            this.rdbAccess.Text = "Access";
            this.rdbAccess.UseVisualStyleBackColor = true;
            
            this.rdbAccess.Click += new System.EventHandler(this.rdbAccess_Click);
            // 
            // btnAccessSelect
            // 
            this.btnAccessSelect.Location = new System.Drawing.Point(463, 77);
            this.btnAccessSelect.Name = "btnAccessSelect";
            this.btnAccessSelect.Size = new System.Drawing.Size(75, 25);
            this.btnAccessSelect.TabIndex = 5;
            this.btnAccessSelect.Text = "选择";
            this.btnAccessSelect.UseVisualStyleBackColor = true;
            this.btnAccessSelect.Click += new System.EventHandler(this.btnAccessSelect_Click);
            // 
            // txtAccessPath
            // 
            this.txtAccessPath.Location = new System.Drawing.Point(64, 77);
            this.txtAccessPath.Name = "txtAccessPath";
            this.txtAccessPath.Size = new System.Drawing.Size(384, 25);
            this.txtAccessPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Access文件路径：";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 406);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabCSV.ResumeLayout(false);
            this.tabCSV.PerformLayout();
            this.tabAccess.ResumeLayout(false);
            this.tabAccess.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabCSV;
        private System.Windows.Forms.Button btnCVSSelect;
        private System.Windows.Forms.TextBox txtCSVPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCsv;
        private System.Windows.Forms.RadioButton rdbAccess;
        private System.Windows.Forms.Button btnAccessSelect;
        private System.Windows.Forms.TextBox txtAccessPath;
        private System.Windows.Forms.Label label2;
    }
}