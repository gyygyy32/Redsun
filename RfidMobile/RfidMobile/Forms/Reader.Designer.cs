namespace RfidMobile
{
    partial class Reader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBasicInfo = new System.Windows.Forms.Button();
            this.btnCurves = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelBasicInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCellCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISO14000Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtISO14000Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISO9000Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISO9000Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPolarity = new System.Windows.Forms.TextBox();
            this.txtCellDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCellSource = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPIVF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModuleDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.txtIecCertificateLab = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIecCertificateDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModuleCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelCurves = new System.Windows.Forms.Panel();
            this.ivCurves1 = new RfidControl.IVCurves();
            this.lblCurvesHeader = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPmax = new System.Windows.Forms.Label();
            this.lblVpm = new System.Windows.Forms.Label();
            this.lblVoc = new System.Windows.Forms.Label();
            this.lblIpm = new System.Windows.Forms.Label();
            this.lblIsc = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.panelBasicInfo.SuspendLayout();
            this.panelCurves.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBasicInfo
            // 
            this.btnBasicInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnBasicInfo.Location = new System.Drawing.Point(3, 3);
            this.btnBasicInfo.Name = "btnBasicInfo";
            this.btnBasicInfo.Size = new System.Drawing.Size(70, 22);
            this.btnBasicInfo.TabIndex = 71;
            this.btnBasicInfo.Text = "Basis Info";
            this.btnBasicInfo.Click += new System.EventHandler(this.OnChangePanel);
            // 
            // btnCurves
            // 
            this.btnCurves.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCurves.Location = new System.Drawing.Point(79, 3);
            this.btnCurves.Name = "btnCurves";
            this.btnCurves.Size = new System.Drawing.Size(67, 22);
            this.btnCurves.TabIndex = 72;
            this.btnCurves.Text = "I-V Curve";
            this.btnCurves.Click += new System.EventHandler(this.OnChangePanel);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnReset.Location = new System.Drawing.Point(149, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 22);
            this.btnReset.TabIndex = 73;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnExit.Location = new System.Drawing.Point(193, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 22);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelBasicInfo
            // 
            this.panelBasicInfo.AutoScroll = true;
            this.panelBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelBasicInfo.Controls.Add(this.label5);
            this.panelBasicInfo.Controls.Add(this.label8);
            this.panelBasicInfo.Controls.Add(this.txtCellCountry);
            this.panelBasicInfo.Controls.Add(this.label7);
            this.panelBasicInfo.Controls.Add(this.txtMaxPower);
            this.panelBasicInfo.Controls.Add(this.label4);
            this.panelBasicInfo.Controls.Add(this.txtISO14000Name);
            this.panelBasicInfo.Controls.Add(this.label6);
            this.panelBasicInfo.Controls.Add(this.txtISO14000Date);
            this.panelBasicInfo.Controls.Add(this.label3);
            this.panelBasicInfo.Controls.Add(this.txtISO9000Name);
            this.panelBasicInfo.Controls.Add(this.label2);
            this.panelBasicInfo.Controls.Add(this.txtISO9000Date);
            this.panelBasicInfo.Controls.Add(this.label1);
            this.panelBasicInfo.Controls.Add(this.txtPolarity);
            this.panelBasicInfo.Controls.Add(this.txtCellDate);
            this.panelBasicInfo.Controls.Add(this.label20);
            this.panelBasicInfo.Controls.Add(this.txtCellSource);
            this.panelBasicInfo.Controls.Add(this.txtSerialNo);
            this.panelBasicInfo.Controls.Add(this.label16);
            this.panelBasicInfo.Controls.Add(this.label14);
            this.panelBasicInfo.Controls.Add(this.txtPIVF);
            this.panelBasicInfo.Controls.Add(this.label11);
            this.panelBasicInfo.Controls.Add(this.txtModuleDate);
            this.panelBasicInfo.Controls.Add(this.label10);
            this.panelBasicInfo.Controls.Add(this.txtModelNumber);
            this.panelBasicInfo.Controls.Add(this.txtIecCertificateLab);
            this.panelBasicInfo.Controls.Add(this.label18);
            this.panelBasicInfo.Controls.Add(this.txtIecCertificateDate);
            this.panelBasicInfo.Controls.Add(this.label15);
            this.panelBasicInfo.Controls.Add(this.txtModuleCountry);
            this.panelBasicInfo.Controls.Add(this.label9);
            this.panelBasicInfo.Controls.Add(this.txtManufacturer);
            this.panelBasicInfo.Controls.Add(this.label12);
            this.panelBasicInfo.Location = new System.Drawing.Point(2, 29);
            this.panelBasicInfo.Name = "panelBasicInfo";
            this.panelBasicInfo.Size = new System.Drawing.Size(231, 253);
            this.panelBasicInfo.GotFocus += new System.EventHandler(this.panelBasicInfo_GotFocus);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(4, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.Text = "Cell Country Of Origh";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCellCountry
            // 
            this.txtCellCountry.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtCellCountry.Location = new System.Drawing.Point(91, 147);
            this.txtCellCountry.Multiline = true;
            this.txtCellCountry.Name = "txtCellCountry";
            this.txtCellCountry.Size = new System.Drawing.Size(116, 30);
            this.txtCellCountry.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(0, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 36);
            this.label7.Text = "Maximum Systen Voltage";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtMaxPower.Location = new System.Drawing.Point(91, 491);
            this.txtMaxPower.Multiline = true;
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(116, 36);
            this.txtMaxPower.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(15, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.Text = "Certificate Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtISO14000Name
            // 
            this.txtISO14000Name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtISO14000Name.Location = new System.Drawing.Point(91, 466);
            this.txtISO14000Name.Name = "txtISO14000Name";
            this.txtISO14000Name.Size = new System.Drawing.Size(116, 19);
            this.txtISO14000Name.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(15, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 37);
            this.label6.Text = "ISO14000 Certificate Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtISO14000Date
            // 
            this.txtISO14000Date.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtISO14000Date.Location = new System.Drawing.Point(91, 424);
            this.txtISO14000Date.Multiline = true;
            this.txtISO14000Date.Name = "txtISO14000Date";
            this.txtISO14000Date.Size = new System.Drawing.Size(116, 36);
            this.txtISO14000Date.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(4, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.Text = "Certificate Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtISO9000Name
            // 
            this.txtISO9000Name.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtISO9000Name.Location = new System.Drawing.Point(91, 399);
            this.txtISO9000Name.Name = "txtISO9000Name";
            this.txtISO9000Name.Size = new System.Drawing.Size(116, 19);
            this.txtISO9000Name.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(26, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 44);
            this.label2.Text = "ISO9000 Certificate Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtISO9000Date
            // 
            this.txtISO9000Date.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtISO9000Date.Location = new System.Drawing.Point(92, 358);
            this.txtISO9000Date.Multiline = true;
            this.txtISO9000Date.Name = "txtISO9000Date";
            this.txtISO9000Date.Size = new System.Drawing.Size(116, 35);
            this.txtISO9000Date.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.Text = "Polarity of Terminal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPolarity
            // 
            this.txtPolarity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtPolarity.Location = new System.Drawing.Point(92, 327);
            this.txtPolarity.Multiline = true;
            this.txtPolarity.Name = "txtPolarity";
            this.txtPolarity.Size = new System.Drawing.Size(116, 25);
            this.txtPolarity.TabIndex = 149;
            // 
            // txtCellDate
            // 
            this.txtCellDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtCellDate.Location = new System.Drawing.Point(92, 117);
            this.txtCellDate.Multiline = true;
            this.txtCellDate.Name = "txtCellDate";
            this.txtCellDate.Size = new System.Drawing.Size(116, 24);
            this.txtCellDate.TabIndex = 122;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label20.Location = new System.Drawing.Point(18, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 23);
            this.label20.Text = "Cell Manuf Date";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCellSource
            // 
            this.txtCellSource.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtCellSource.Location = new System.Drawing.Point(92, 34);
            this.txtCellSource.Name = "txtCellSource";
            this.txtCellSource.Size = new System.Drawing.Size(115, 19);
            this.txtCellSource.TabIndex = 121;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtSerialNo.Location = new System.Drawing.Point(92, 249);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(116, 19);
            this.txtSerialNo.TabIndex = 119;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 21);
            this.label16.Text = "Module Manuf";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label14.Location = new System.Drawing.Point(12, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 38);
            this.label14.Text = "Module Country Of Origh";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPIVF
            // 
            this.txtPIVF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtPIVF.Location = new System.Drawing.Point(91, 219);
            this.txtPIVF.Name = "txtPIVF";
            this.txtPIVF.Size = new System.Drawing.Size(116, 19);
            this.txtPIVF.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(3, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.Text = "Certificate Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtModuleDate
            // 
            this.txtModuleDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtModuleDate.Location = new System.Drawing.Point(92, 84);
            this.txtModuleDate.Multiline = true;
            this.txtModuleDate.Name = "txtModuleDate";
            this.txtModuleDate.Size = new System.Drawing.Size(116, 27);
            this.txtModuleDate.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(15, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 26);
            this.label10.Text = "Certificate Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtModelNumber.Location = new System.Drawing.Point(91, 59);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(116, 19);
            this.txtModelNumber.TabIndex = 116;
            // 
            // txtIecCertificateLab
            // 
            this.txtIecCertificateLab.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtIecCertificateLab.Location = new System.Drawing.Point(92, 299);
            this.txtIecCertificateLab.Name = "txtIecCertificateLab";
            this.txtIecCertificateLab.Size = new System.Drawing.Size(116, 19);
            this.txtIecCertificateLab.TabIndex = 113;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(-11, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 18);
            this.label18.Text = "Pmax,Im,Vm,FF";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIecCertificateDate
            // 
            this.txtIecCertificateDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtIecCertificateDate.Location = new System.Drawing.Point(92, 274);
            this.txtIecCertificateDate.Name = "txtIecCertificateDate";
            this.txtIecCertificateDate.Size = new System.Drawing.Size(116, 19);
            this.txtIecCertificateDate.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label15.Location = new System.Drawing.Point(-10, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 33);
            this.label15.Text = "Module Manuf Date";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtModuleCountry
            // 
            this.txtModuleCountry.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtModuleCountry.Location = new System.Drawing.Point(91, 183);
            this.txtModuleCountry.Multiline = true;
            this.txtModuleCountry.Name = "txtModuleCountry";
            this.txtModuleCountry.Size = new System.Drawing.Size(116, 30);
            this.txtModuleCountry.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(4, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.Text = "Serial No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtManufacturer.Location = new System.Drawing.Point(92, 9);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(115, 19);
            this.txtManufacturer.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(4, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.Text = "Module No";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelCurves
            // 
            this.panelCurves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCurves.Controls.Add(this.lblFF);
            this.panelCurves.Controls.Add(this.lblIsc);
            this.panelCurves.Controls.Add(this.lblIpm);
            this.panelCurves.Controls.Add(this.lblVoc);
            this.panelCurves.Controls.Add(this.lblVpm);
            this.panelCurves.Controls.Add(this.lblPmax);
            this.panelCurves.Controls.Add(this.ivCurves1);
            this.panelCurves.Controls.Add(this.lblCurvesHeader);
            this.panelCurves.Controls.Add(this.label28);
            this.panelCurves.Location = new System.Drawing.Point(263, 29);
            this.panelCurves.Name = "panelCurves";
            this.panelCurves.Size = new System.Drawing.Size(234, 238);
            this.panelCurves.Visible = false;
            // 
            // ivCurves1
            // 
            this.ivCurves1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ivCurves1.Location = new System.Drawing.Point(0, 53);
            this.ivCurves1.Name = "ivCurves1";
            this.ivCurves1.Size = new System.Drawing.Size(234, 185);
            this.ivCurves1.TabIndex = 2;
            // 
            // lblCurvesHeader
            // 
            this.lblCurvesHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblCurvesHeader.Location = new System.Drawing.Point(1, 9);
            this.lblCurvesHeader.Name = "lblCurvesHeader";
            this.lblCurvesHeader.Size = new System.Drawing.Size(232, 17);
            this.lblCurvesHeader.Text = "I-V Curves Of PV Module ";
            this.lblCurvesHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label28.Location = new System.Drawing.Point(140, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 17);
            this.label28.Text = "Cell Temp:25℃";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.Text = "Cell Manuf";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPmax
            // 
            this.lblPmax.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblPmax.Location = new System.Drawing.Point(3, 24);
            this.lblPmax.Name = "lblPmax";
            this.lblPmax.Size = new System.Drawing.Size(84, 20);
            this.lblPmax.Text = "Pmax:327.35w";
            // 
            // lblVpm
            // 
            this.lblVpm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblVpm.Location = new System.Drawing.Point(81, 24);
            this.lblVpm.Name = "lblVpm";
            this.lblVpm.Size = new System.Drawing.Size(65, 20);
            this.lblVpm.Text = "Vpm:37.35v";
            // 
            // lblVoc
            // 
            this.lblVoc.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblVoc.Location = new System.Drawing.Point(3, 37);
            this.lblVoc.Name = "lblVoc";
            this.lblVoc.Size = new System.Drawing.Size(72, 16);
            this.lblVoc.Text = "Voc:45.35v";
            // 
            // lblIpm
            // 
            this.lblIpm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblIpm.Location = new System.Drawing.Point(64, 37);
            this.lblIpm.Name = "lblIpm";
            this.lblIpm.Size = new System.Drawing.Size(57, 16);
            this.lblIpm.Text = "Ipm:8.83A";
            // 
            // lblIsc
            // 
            this.lblIsc.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblIsc.Location = new System.Drawing.Point(118, 37);
            this.lblIsc.Name = "lblIsc";
            this.lblIsc.Size = new System.Drawing.Size(56, 16);
            this.lblIsc.Text = "Isc:9.83A";
            // 
            // lblFF
            // 
            this.lblFF.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lblFF.Location = new System.Drawing.Point(174, 37);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(61, 16);
            this.lblFF.Text = "FF:77.45%";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(638, 593);
            this.ControlBox = false;
            this.Controls.Add(this.panelCurves);
            this.Controls.Add(this.panelBasicInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCurves);
            this.Controls.Add(this.btnBasicInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reader";
            this.Text = "Read Tag Data";
            this.Deactivate += new System.EventHandler(this.Reader_Deactivate);
            this.Load += new System.EventHandler(this.Reader_Load);
            this.Activated += new System.EventHandler(this.Reader_Activated);
            this.panelBasicInfo.ResumeLayout(false);
            this.panelCurves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasicInfo;
        private System.Windows.Forms.Button btnCurves;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelBasicInfo;
        private System.Windows.Forms.TextBox txtCellDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPIVF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModuleDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.TextBox txtIecCertificateLab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIecCertificateDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModuleCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelCurves;
        private System.Windows.Forms.Label lblCurvesHeader;
        private System.Windows.Forms.Label label28;
        private RfidControl.IVCurves ivCurves1;
        private System.Windows.Forms.TextBox txtCellSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPolarity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISO9000Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISO14000Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtISO14000Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISO9000Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCellCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPmax;
        private System.Windows.Forms.Label lblVoc;
        private System.Windows.Forms.Label lblVpm;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.Label lblIsc;
        private System.Windows.Forms.Label lblIpm;
    }
}