using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using RfidMobile.Classes;
using RfidControl;

namespace RfidMobile
{
    public partial class Reader : Form
    {
        private static System.Threading.Timer _ReadTimer = null;

        //Dictionary<string, RFIDConstants> dic_customer_RFID_constants = new Dictionary<string, RFIDConstants>();

        public static bool _read_tag_timer_enable = true;

        private string m_sLastReadTagId = "";

        private ModuleInfo m_objModuleInfo = null;

        public Reader()
        {
            InitializeComponent();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            m_sLastReadTagId = "";
            /*
             * read rfid tag every 2 second
             */
            _ReadTimer = null;
            _ReadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(ReadRfidTimerCallback), null, 2000, Timeout.Infinite);

        }

        private void OnChangePanel(object sender, EventArgs e)
        {
            if (sender == btnBasicInfo)
            {
                panelBasicInfo.Visible = true;
                panelBasicInfo.Left = 2;
                panelCurves.Visible = false;
            }
            else
            {
                panelBasicInfo.Visible = false;
                panelCurves.Visible = true;
                panelCurves.Left = 2;
            }
        }

        /*
         * timer callback function, read Tag every 2 seconds
         */
        private void ReadRfidTimerCallback(object sender)
        {

            if (_read_tag_timer_enable)
            {
                try
                {
                    string tagId = ReaderConfig._rfidReader.ReadTagID();

                    if (!string.IsNullOrEmpty(tagId))
                    {
                        if (m_sLastReadTagId != tagId)
                        {
                            m_sLastReadTagId = tagId;
                        }
                        else
                        {
                            _ReadTimer.Change(2000, Timeout.Infinite);
                            return;
                        }

                        System.Threading.Thread.Sleep(20);

                        byte[] buff = ReaderConfig._rfidReader.ReadTagBuff();

                        if (buff != null)
                        {
                            m_objModuleInfo = TagDataFormat.ParserTagData(buff);
                            //信息都从标签获取 modify by xue lei on 2018-7-11
                            //SetRFIDConstants(m_objModuleInfo.customer);

                            ChangeState(SystemState.ShowModuleInfo, m_objModuleInfo);

                            ReaderConfig._rfidReader.PlaySound();
                        }

                        //DataTable dt = new DataTable();
                        //dt.Columns.Add("Current");
                        //dt.Columns.Add("Voltage");
                        //dt.TableName = "dtPointsInfo";
                        //for (int i = 0; i < tag.PointArray.Length; i++)
                        //{
                        //    DataRow dr = dt.NewRow();
                        //    dr["Current"] = tag.PointArray[i].Current * 10000000;
                        //    dr["Voltage"] = tag.PointArray[i].Voltage * 10000000;
                        //    dt.Rows.Add(dr);
                        //}
                        //DataSet ds = new DataSet();
                        //ds.Tables.Add(dt);

                        //object[] args2 = new object[4];
                        //args2[0] = tagId;
                        //args2[1] = tag.SerialNo;
                        //args2[2] = tag.Profile;
                        //args2[3] = ds.GetXml();
                        //this.Invoke(new ReadLogDelegate(ReadLog), args2);
                        //dt = null; ds = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作异常，原因：" + ex.Message, "异常");
                    //FileLog.WriteError(ex.Message);
                }
            }
            

            _ReadTimer.Change(2000, Timeout.Infinite);
        }

        /// <summary>
        /// set rfid's constants by customer
        /// </summary>
        private void SetRFIDConstants(string customer)
        {
            if (ReaderConfig._dic_rfidConstants.ContainsKey(customer))
            {
                RFIDConstants rc = ReaderConfig._dic_rfidConstants[customer];

                m_objModuleInfo.mfg_name = rc.mfg_name;
                m_objModuleInfo.cell_supplier_country = rc.mfg_country;
                m_objModuleInfo.iec_date = rc.iec_date;
                m_objModuleInfo.iec_verfy = rc.iec_verfy;
                m_objModuleInfo.iso = rc.iso_desc;
                m_objModuleInfo.ProductType = rc.product_type;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_ReadTimer != null)
            {
                _ReadTimer.Change(Timeout.Infinite, Timeout.Infinite);
            }

            this.DialogResult = DialogResult.Cancel;
        }

        private void ShowIVCurves(double isc, double ipm, double vpm, double voc)
        {
            I_V_Point[] oriPointArray = new I_V_Point[3];
            I_V_Point ivp = new I_V_Point(isc, 0);
            oriPointArray[0] = ivp;
            ivp = new I_V_Point(ipm, vpm);
            oriPointArray[1] = ivp;
            ivp = new I_V_Point(0, voc);
            oriPointArray[2] = ivp;
            ivCurves1.SetOriginalPoints(oriPointArray, true);
        }


        private delegate void ChangeStateDlgt(SystemState ss, ModuleInfo o);
        private void ChangeState(SystemState ss, ModuleInfo o)
        {
            if (this.InvokeRequired)
            {
                ChangeStateDlgt InvokeChangeState = new ChangeStateDlgt(ChangeState);
                this.Invoke(InvokeChangeState, new object[] { ss, o });
            }
            else
            {
                switch (ss)
                {
                    case SystemState.ShowModuleInfo:
                        txtManufacturer.Text = string.IsNullOrEmpty(o.mfg_name) ? "" : o.mfg_name;       //组件厂商
                        txtCellSource.Text = string.IsNullOrEmpty(o.cell_mfg_name) ? "" : o.cell_mfg_name;//电池厂商
                        txtSerialNo.Text = string.IsNullOrEmpty(o.Module_ID) ? "" : o.Module_ID;          //组件序列号
                        txtModelNumber.Text = string.IsNullOrEmpty(o.ProductType) ? "" : o.ProductType;   //产品类型 
                        txtModuleDate.Text = string.IsNullOrEmpty(o.PackedDate) ? "" : o.PackedDate;          //组件生产日期
                        txtCellDate.Text = string.IsNullOrEmpty(o.cell_mfg_date) ? "" : o.cell_mfg_date;   //电池生产日期
                        txtPIVF.Text = o.Pmax + "W," + o.Ipm + "A," + o.Vpm + "V," + o.FF;
                        txtIecCertificateDate.Text = string.IsNullOrEmpty(o.iec_date) ? "" : o.iec_date;   //证书日期

                        txtIecCertificateLab.Text = string.IsNullOrEmpty(o.iec_verfy) ? "" : o.iec_verfy; //证书名称

                        //txtPolarity.Text = string.IsNullOrEmpty(o.polarity_of_terminal) ? "" : o.polarity_of_terminal;//终端极性
                        //txtISO9000Date.Text = string.IsNullOrEmpty(o.iso_9000_date) ? "" : o.iso_9000_date; //ISO9000证书的日期
                        //txtISO9000Name.Text = string.IsNullOrEmpty(o.iso_9000_name) ? "" : o.iso_9000_name;//ISO9000证书的名称
                        //txtISO14000Date.Text = string.IsNullOrEmpty(o.iso_14000_date) ? "" : o.iso_14000_date;//ISO14000证书的日期
                        //txtISO14000Name.Text = string.IsNullOrEmpty(o.iso_14000_name) ? "" : o.iso_14000_name;//ISO14000证书的名称

                        //txtMaxPower.Text = string.IsNullOrEmpty(o.max_system_voltage) ? "" : o.max_system_voltage;// 最大系统电压

                        txtModuleCountry.Text = string.IsNullOrEmpty(o.mfg_country) ? "" : o.mfg_country;//组件生产国家

                        //txtCellCountry.Text = string.IsNullOrEmpty(o.cell_supplier_country) ? "" : o.cell_supplier_country;//电池生产国家
                        //txt.Text = string.IsNullOrEmpty(o.cell_supplier_country) ? "" : o.cell_supplier_country;

                        ShowIVCurves(double.Parse(o.Isc), double.Parse(o.Ipm), double.Parse(o.Vpm), double.Parse(o.Voc));

                        //显示IV曲线参数 add by xue lei on 2018-7-11
                        lblPmax.Text = "Pmax:" + o.Pmax + "W";
                        lblVpm.Text = "Vpm:" + o.Vpm + "V";
                        lblVoc.Text = "Voc:" + o.Voc + "V";
                        lblIpm.Text = "Ipm:" + o.Ipm + "A";
                        lblIsc.Text = "Isc:" + o.Isc + "A";
                        lblFF.Text = "FF:" + o.FF+"%";

                        break;
                    case SystemState.ResetAll:
                        //txtManufacturer.Text = "";
                        //txtSerialNo.Text = "";
                        //txtModelNumber.Text = "";
                        //txtModuleDate.Text = "";
                        //txtCellSource.Text = "";
                        //txtCellDate.Text = "";
                        //txtPIVF.Text = "";
                        //txtIecCertificateDate.Text = "";
                        //txtIecCertificateOffer.Text = "";
                        //txtIecCertificateLab.Text = "";
                        //txtMadeIn.Text = "";
                        txtManufacturer.Text = "";//组件厂商
                        txtCellSource.Text = "";//电池厂商
                        txtSerialNo.Text = "";//序列号
                        txtModelNumber.Text = "";//产品类型
                        txtModuleDate.Text = "";
                        txtCellDate.Text = "";
                        txtPIVF.Text = "";
                        txtIecCertificateDate.Text = "";
                        txtIecCertificateLab.Text = "";
                        //txtPolarity.Text = "";
                        //txtISO9000Date.Text = "";
                        //txtISO9000Name.Text = "";
                        //txtISO14000Date.Text = "";
                        //txtISO14000Name.Text = "";
                        //txtMaxPower.Text = "";
                        txtModuleCountry.Text = "";//组件产地
                        //txtCellCountry.Text = "";
                        ivCurves1.SetOriginalPoints(null, true);
                        break;
                    default:
                        break;
                }


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ChangeState(SystemState.ResetAll, null);

            m_sLastReadTagId = "";
        }

        private void Reader_Deactivate(object sender, EventArgs e)
        {
            if (_ReadTimer != null)
            {
                _ReadTimer.Change(Timeout.Infinite, Timeout.Infinite);
            }

            this.DialogResult = DialogResult.Cancel;
        }

        private void Reader_Activated(object sender, EventArgs e)
        {
            _read_tag_timer_enable = true;
        }

        private void panelBasicInfo_GotFocus(object sender, EventArgs e)
        {

        }
    }
}