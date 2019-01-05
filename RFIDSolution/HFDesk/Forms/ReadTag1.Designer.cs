namespace HFDesk
{
    partial class ReadTag1
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
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btn_readTag = new System.Windows.Forms.Button();
            this.ivCurves1 = new CustomControl.IVCurves();
            this.tbx_SerialWrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_prodtype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_ff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_celldate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_packdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_ipm = new System.Windows.Forms.TextBox();
            this.tbx_vpm = new System.Windows.Forms.TextBox();
            this.tbx_pmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCellName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMFGName = new System.Windows.Forms.TextBox();
            this.dddd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lrtxtLog.Location = new System.Drawing.Point(0, 700);
            this.lrtxtLog.Margin = new System.Windows.Forms.Padding(4);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1695, 164);
            this.lrtxtLog.TabIndex = 3;
            this.lrtxtLog.Text = "";
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(108, 663);
            this.ckClearOperationRec.Margin = new System.Windows.Forms.Padding(4);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(89, 19);
            this.ckClearOperationRec.TabIndex = 23;
            this.ckClearOperationRec.Text = "自动清空";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(16, 664);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 15);
            this.label35.TabIndex = 22;
            this.label35.Text = "操作记录:";
            // 
            // btn_readTag
            // 
            this.btn_readTag.Location = new System.Drawing.Point(711, 15);
            this.btn_readTag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_readTag.Name = "btn_readTag";
            this.btn_readTag.Size = new System.Drawing.Size(100, 29);
            this.btn_readTag.TabIndex = 31;
            this.btn_readTag.Text = "读取";
            this.btn_readTag.UseVisualStyleBackColor = true;
            this.btn_readTag.Visible = false;
            this.btn_readTag.Click += new System.EventHandler(this.btn_readTag_Click);
            // 
            // ivCurves1
            // 
            this.ivCurves1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ivCurves1.Location = new System.Drawing.Point(215, 124);
            this.ivCurves1.Margin = new System.Windows.Forms.Padding(4);
            this.ivCurves1.Name = "ivCurves1";
            this.ivCurves1.Size = new System.Drawing.Size(440, 292);
            this.ivCurves1.TabIndex = 37;
            this.ivCurves1.Text = "ivCurves1";
            // 
            // tbx_SerialWrite
            // 
            this.tbx_SerialWrite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_SerialWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbx_SerialWrite.Font = new System.Drawing.Font("宋体", 20F);
            this.tbx_SerialWrite.Location = new System.Drawing.Point(215, 65);
            this.tbx_SerialWrite.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_SerialWrite.Name = "tbx_SerialWrite";
            this.tbx_SerialWrite.ReadOnly = true;
            this.tbx_SerialWrite.Size = new System.Drawing.Size(439, 46);
            this.tbx_SerialWrite.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 35;
            this.label3.Text = "组件序列号";
            // 
            // tbx_prodtype
            // 
            this.tbx_prodtype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_prodtype.BackColor = System.Drawing.Color.White;
            this.tbx_prodtype.Font = new System.Drawing.Font("微软雅黑", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_prodtype.Location = new System.Drawing.Point(216, 444);
            this.tbx_prodtype.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_prodtype.Name = "tbx_prodtype";
            this.tbx_prodtype.ReadOnly = true;
            this.tbx_prodtype.Size = new System.Drawing.Size(1344, 139);
            this.tbx_prodtype.TabIndex = 40;
            this.tbx_prodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 558);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 35);
            this.label7.TabIndex = 39;
            this.label7.Text = "ProductType";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.txtMFGName);
            this.groupBox1.Controls.Add(this.dddd);
            this.groupBox1.Controls.Add(this.txtCellName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbx_ff);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbx_celldate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbx_packdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_ipm);
            this.groupBox1.Controls.Add(this.tbx_vpm);
            this.groupBox1.Controls.Add(this.tbx_pmax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(873, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(687, 407);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textBox5.Location = new System.Drawing.Point(532, 123);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(145, 27);
            this.textBox5.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label15.Location = new System.Drawing.Point(439, 127);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "组件产地";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textBox3.Location = new System.Drawing.Point(532, 166);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 27);
            this.textBox3.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label13.Location = new System.Drawing.Point(439, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "证书名称";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textBox1.Location = new System.Drawing.Point(165, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label11.Location = new System.Drawing.Point(83, 214);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "证书日期";
            // 
            // tbx_ff
            // 
            this.tbx_ff.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_ff.Location = new System.Drawing.Point(165, 166);
            this.tbx_ff.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ff.Name = "tbx_ff";
            this.tbx_ff.ReadOnly = true;
            this.tbx_ff.Size = new System.Drawing.Size(145, 27);
            this.tbx_ff.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label10.Location = new System.Drawing.Point(105, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "FF(%)";
            // 
            // tbx_celldate
            // 
            this.tbx_celldate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_celldate.Location = new System.Drawing.Point(532, 78);
            this.tbx_celldate.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_celldate.Name = "tbx_celldate";
            this.tbx_celldate.ReadOnly = true;
            this.tbx_celldate.Size = new System.Drawing.Size(145, 27);
            this.tbx_celldate.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.Location = new System.Drawing.Point(407, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "电池生产日期";
            // 
            // tbx_packdate
            // 
            this.tbx_packdate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_packdate.Location = new System.Drawing.Point(532, 33);
            this.tbx_packdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_packdate.Name = "tbx_packdate";
            this.tbx_packdate.ReadOnly = true;
            this.tbx_packdate.Size = new System.Drawing.Size(145, 27);
            this.tbx_packdate.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.Location = new System.Drawing.Point(407, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "组件生产日期";
            // 
            // tbx_ipm
            // 
            this.tbx_ipm.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_ipm.Location = new System.Drawing.Point(165, 121);
            this.tbx_ipm.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ipm.Name = "tbx_ipm";
            this.tbx_ipm.ReadOnly = true;
            this.tbx_ipm.Size = new System.Drawing.Size(145, 27);
            this.tbx_ipm.TabIndex = 32;
            // 
            // tbx_vpm
            // 
            this.tbx_vpm.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_vpm.Location = new System.Drawing.Point(165, 76);
            this.tbx_vpm.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_vpm.Name = "tbx_vpm";
            this.tbx_vpm.ReadOnly = true;
            this.tbx_vpm.Size = new System.Drawing.Size(145, 27);
            this.tbx_vpm.TabIndex = 31;
            // 
            // tbx_pmax
            // 
            this.tbx_pmax.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_pmax.Location = new System.Drawing.Point(165, 31);
            this.tbx_pmax.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_pmax.Name = "tbx_pmax";
            this.tbx_pmax.ReadOnly = true;
            this.tbx_pmax.Size = new System.Drawing.Size(145, 27);
            this.tbx_pmax.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(88, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Imax(A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(83, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vmax(V)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pmax(W)";
            // 
            // txtCellName
            // 
            this.txtCellName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtCellName.Location = new System.Drawing.Point(166, 250);
            this.txtCellName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellName.Name = "txtCellName";
            this.txtCellName.ReadOnly = true;
            this.txtCellName.Size = new System.Drawing.Size(145, 27);
            this.txtCellName.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(84, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "电池厂商";
            // 
            // txtMFGName
            // 
            this.txtMFGName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtMFGName.Location = new System.Drawing.Point(532, 208);
            this.txtMFGName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFGName.Name = "txtMFGName";
            this.txtMFGName.ReadOnly = true;
            this.txtMFGName.Size = new System.Drawing.Size(145, 27);
            this.txtMFGName.TabIndex = 54;
            // 
            // dddd
            // 
            this.dddd.AutoSize = true;
            this.dddd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dddd.Location = new System.Drawing.Point(437, 211);
            this.dddd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dddd.Name = "dddd";
            this.dddd.Size = new System.Drawing.Size(69, 20);
            this.dddd.TabIndex = 53;
            this.dddd.Text = "组件厂商";
            // 
            // ReadTag1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 864);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ivCurves1);
            this.Controls.Add(this.tbx_SerialWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_prodtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_readTag);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.lrtxtLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadTag1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读标签";
            this.Activated += new System.EventHandler(this.ReadTag1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadTag1_FormClosing);
            this.Load += new System.EventHandler(this.ReadTag1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btn_readTag;
        private CustomControl.IVCurves ivCurves1;
        private System.Windows.Forms.TextBox tbx_SerialWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_prodtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_ff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_celldate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_packdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ipm;
        private System.Windows.Forms.TextBox tbx_vpm;
        private System.Windows.Forms.TextBox tbx_pmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMFGName;
        private System.Windows.Forms.Label dddd;
        private System.Windows.Forms.TextBox txtCellName;
        private System.Windows.Forms.Label label2;
    }
}