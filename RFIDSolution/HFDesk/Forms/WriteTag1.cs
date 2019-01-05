using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HFDesk.helpClass;
using HFDesk.Properties;
using System.Threading;
using System.Speech.Synthesis;
using CustomControl;
using RFIDService.ClientData;
using System.Data.Odbc;


namespace HFDesk
{
    public partial class WriteTag1 : Form
    {
        private byte[] m_btTagUID = new byte[8];
        //private byte[] m_btReadBuffer = null;

        //const string _China = "China";
        //const string _IEC_Date = "March 2016";
        //const string _IEC_Verfy = "TUV SUD Product Service GmbH";
        //const string _ISO = "IEC TUV";
        //const string _Producer = "RISEN ENERGYCO.,LTD";


        Dictionary<string, RFIDConstants> dic_customer_RFID_constants = new Dictionary<string, RFIDConstants>();

        private Int16 st;

        private string m_sTagUIDstring = "";
        private string m_sSerialNumber = "";
        private string m_sBasicInfo = "";


        RFIDConstants const_parameters = null;
        //private string ms_cfg_mfg_name = "";
        //private string ms_cfg_mfg_country = "";
        //private string ms_iec_date = "";
        //private string ms_iec_verfy = "";
        //private string ms_iso = "";
        //private string ms_producttype = "";
        //private string ms_cell_mfg = "";
        //private string ms_cellsource_country = "";
        //private string ms_polarity_of_terminal = "";
        //private string ms_iso9000_date = "";
        //private string ms_iso9000_name = "";
        //private string ms_iso14000_date = "";
        //private string ms_iso14000_name = "";
        //private string ms_max_sys_vol = "";
        //private string ms_cell_mfg_date = "";


        private ModuleInfo oModuleInfo = null;

        private System.Threading.Timer timer = null;


        public WriteTag1()
        {
            InitializeComponent();

            timer = new System.Threading.Timer(TimerCallback, null, Timeout.Infinite, Timeout.Infinite);

        }

        private void TimerCallback(object state)
        {
            //set color back to transparent
            paintBackgroundColor(statusType.START);
            //timer.Change(15000, Timeout.Infinite);
        }

        private void WriteTag1_Load(object sender, EventArgs e)
        {
            /*
             * open reader if not connected
             */

            //ms_cfg_mfg_name = System.Configuration.ConfigurationManager.AppSettings["mfg_name"];
            //ms_cfg_mfg_country = System.Configuration.ConfigurationManager.AppSettings["mfg_country"];
            //ms_iec_date = System.Configuration.ConfigurationManager.AppSettings["iec_date"];
            //ms_iec_verfy = System.Configuration.ConfigurationManager.AppSettings["iec_verfy"];
            //ms_iso = System.Configuration.ConfigurationManager.AppSettings["iso"];
            //ms_producttype = System.Configuration.ConfigurationManager.AppSettings["producttype"];
            //QueryCSVToOdbc();
            InitRFIDConstants();


            SetLabelStatus(statusType.START);

            if (!ReaderInfo.readerConnerted)
            {
                Int16 iUsbPort = 100;
                ReaderInfo.icdev = common.rf_init(iUsbPort, 0);

                if (ReaderInfo.icdev > 0)
                {
                    common.rf_beep(ReaderInfo.icdev, 10);

                    string strLog = "读写器连接成功！";
                    WriteLog(lrtxtLog, strLog, 0);

                    ReaderInfo.readerConnerted = true;

                    //byte[] status = new byte[30];
                    //st = common.rf_get_status(icdev, status);
                    //lbHardVer.Text = System.Text.Encoding.ASCII.GetString(status);
                }
                else
                {
                    string strLog = "读写器连接失败";
                    WriteLog(lrtxtLog, strLog, 1);

                    return;
                }
            }

            chkbox_burningTag.Checked = true;


            InitRFIDConstants();

        }

        /// <summary>
        /// get rfid constants from config file
        /// </summary>
        private void InitRFIDConstants()
        {
            try
            {
                dic_customer_RFID_constants.Clear();

                string valid_cusomers = DealINI.IniReadValue("CUSTOMERS", "valid_customer");
                string valid_cusomer_displayname = DealINI.IniReadValue("CUSTOMERS", "customer_displayname");

                string[] customers = valid_cusomers.Split('|');
                string[] customer_displayname = valid_cusomer_displayname.Split('|');

                IList<CustomerInfo> infoList = new List<CustomerInfo>();

                //if (customers.Count()>0)
                //{
                //    cbx_customer.DataSource = 
                //}

                for (int i = 0; i < customers.Length; i++)
                {
                    CustomerInfo customerinfo = new CustomerInfo() { Id = customers[i], Name = customer_displayname[i] };
                    infoList.Add(customerinfo);

                    string mfg_country = DealINI.IniReadValue(customers[i], "mfg_country");
                    string mfg_name = DealINI.IniReadValue(customers[i], "mfg_name");
                    string iec_date = DealINI.IniReadValue(customers[i], "iec_date");
                    string iec_verfy = DealINI.IniReadValue(customers[i], "iec_verfy");
                    string iso = DealINI.IniReadValue(customers[i], "iso");
                    string producttype = DealINI.IniReadValue(customers[i], "producttype");
                    string cell_mfg = DealINI.IniReadValue(customers[i], "cell_mfg");
                    string cellsource_country = DealINI.IniReadValue(customers[i], "cellsource_country");
                    string polarity_of_terminal = DealINI.IniReadValue(customers[i], "polarity_of_terminal");
                    string iso9000_date = DealINI.IniReadValue(customers[i], "iso9000_date");
                    string iso9000_name = DealINI.IniReadValue(customers[i], "iso9000_name");
                    string iso14000_date = DealINI.IniReadValue(customers[i], "iso14000_date");
                    string iso14000_name = DealINI.IniReadValue(customers[i], "iso14000_name");
                    string max_sys_vol = DealINI.IniReadValue(customers[i], "max_sys_vol");
                     string cell_mfg_date = DealINI.IniReadValue(customers[i], "cell_mfg_date");

                    RFIDConstants rfidConstant = new RFIDConstants(mfg_country, mfg_name, iec_date, iec_verfy, iso, producttype,iso9000_name,
                        iso9000_date,iso14000_name,iso14000_date,cellsource_country,polarity_of_terminal,max_sys_vol,cell_mfg,
                        cell_mfg_date);

                    dic_customer_RFID_constants.Add(customers[i], rfidConstant);
                }

                if (infoList.Count > 0)
                {
                    cbx_customer.DataSource = infoList;
                    cbx_customer.ValueMember = "Id";
                    cbx_customer.DisplayMember = "Name";
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("解析配置文件出错，请检查配置文件!!!");
            }
            

        }

        private void tbx_SerialWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbox_burningTag.Checked && cbx_customer.SelectedValue == null)
                {
                    MessageBox.Show("请选择客户！！！");
                    return;
                }

                string customer = cbx_customer.SelectedValue.ToString();
                RFIDConstants const_parameters = null;
                if (dic_customer_RFID_constants.ContainsKey(customer))
                {
                    const_parameters = dic_customer_RFID_constants[customer];
                    //ms_cfg_mfg_name = const_parameters.mfg_name;
                    //ms_cfg_mfg_country = const_parameters.mfg_country;
                    //ms_iec_date = const_parameters.iec_date;
                    //ms_iec_verfy = const_parameters.iec_verfy;
                    //ms_iso = const_parameters.iso_desc;
                    //ms_producttype = const_parameters.product_type;
                    //ms_cell_mfg = const_parameters.cell_mfg;
                    //ms_cellsource_country = const_parameters.cellsource_country;
                    //ms_iso9000_date = const_parameters.iso_9000_date;
                    //ms_iso9000_name = const_parameters.iso_9000_name;
                    //ms_iso14000_date = const_parameters.iso_14000_date;
                    //ms_iso14000_name = const_parameters.iso_14000_name;
                    //ms_polarity_of_terminal = const_parameters.polarity_of_terminal;
                    //ms_max_sys_vol = const_parameters.max_sys_vol;
                    //ms_cell_mfg_date = const_parameters.cell_mfg_date;
                }

                CleanIVCurves();
                ShowModuleInfo(false,null);
                string ser = tbx_SerialWrite.Text.Trim().ToUpper();
                //tbx_SerialWrite.Text = "";

                if (ser.Length > 0)
                {
                    paintBackgroundColor(statusType.START);
                    tbx_SerialWrite.Enabled = false;
                    
                    SetLabelStatus(statusType.START);

                    m_sSerialNumber = ser;

                    if (chkbox_burningTag.Checked)
                    {
                        if (!GetTagUID())
                        {
                            WriteLog(lrtxtLog, "没有发现标签！", 1);
                            common.rf_beep(ReaderInfo.icdev, 20);
                            paintBackgroundColor(statusType.FAIL);
                            List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Fail", "" };
                            WriteCSVLog.WriteCSV(csvValueList);
                            SetSerialTxtFocus();
                            Speech("烧录失败");
                        }
                        else
                        {
                            if ("CSV" == "CSV")
                            {
                                WriteRfid( QueryCSVToOdbc(const_parameters, ser));

                            }
                            else
                            {
                                #region query data from database
                                WcfCaller.querySerialInfo((o, ex) =>
                                {
                                    if (ex == null)
                                    {
                                        if (o == null)
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + "未找到组件记录！");
                                            return;
                                        }

                                        #region chech region state



                                        if (string.IsNullOrEmpty(o.ProductType))
                                        {
                                            o.ProductType = const_parameters.product_type;
                                            //DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt01);
                                            //return;
                                        }
                                        if (string.IsNullOrEmpty(o.CellDate))
                                        {
                                            o.CellDate = const_parameters.cell_mfg_date;
                                            //DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt02);
                                            //return;
                                        }
                                        if (string.IsNullOrEmpty(o.PackedDate))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt03);
                                            return;
                                        }
                                        if (string.IsNullOrEmpty(o.Pmax))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt04);
                                            return;
                                        }
                                        if (string.IsNullOrEmpty(o.Voc))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt05);
                                            return;
                                        }
                                        if (string.IsNullOrEmpty(o.Vpm))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt06);
                                            return;
                                        }
                                        if (string.IsNullOrEmpty(o.Ipm))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt07);
                                            return;
                                        }
                                        if (string.IsNullOrEmpty(o.Isc))
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt08);
                                            return;
                                        }
                                        #endregion

                                        ShowIVCurves(double.Parse(o.Isc), double.Parse(o.Ipm), double.Parse(o.Vpm), double.Parse(o.Voc));

                                        o.customer = cbx_customer.SelectedValue.ToString();
                                        //SetRFIDConstants(o.customer);


                                        byte[] btData = TagDataFormat.CreateByteArray(o, const_parameters);

                                        oModuleInfo = o;

                                        m_sBasicInfo = o.ProductType + "|" + o.PackedDate.Replace("-", ".") + "|"
                                            + o.Pivf + "|" + o.Module_ID + "|" + o.CellDate.Replace("-", ".") + "|3";

                                        if (WriteData(btData))
                                        {
                                            //WriteLog2DB();

                                            paintBackgroundColor(statusType.PASS);
                                            WriteLog(lrtxtLog, m_sSerialNumber + " " + "烧录成功！", 0);
                                            common.rf_beep(ReaderInfo.icdev, 10);
                                            List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Pass", m_sTagUIDstring, m_sBasicInfo };
                                            WriteCSVLog.WriteCSV(csvValueList);
                                            ShowModuleInfo(true, const_parameters);
                                            Speech("烧录成功");

                                        }
                                        else
                                        {
                                            DoFailStuff(m_sSerialNumber + " " + "烧录失败！");

                                        }
                                    }
                                    else
                                    {
                                        DoFailStuff("与服务器通讯发生异常" + ex.Message);

                                    }
                                    SetSerialTxtFocus();

                                }, new string[] { m_sSerialNumber, m_sTagUIDstring });
                                #endregion
                            }
                        }
                    }
                    else
                    {
                        if ("CSV" == "CSV")
                        {
                            QueryCSVToOdbc(const_parameters, ser);
                        }
                        else
                        {
                            #region query data from database
                            WcfCaller.querySerialInfo((o, ex) =>
                            {
                                if (ex == null)
                                {
                                    if (o == null)
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + "未找到组件记录！");
                                        return;
                                    }

                                    #region chech region state

                                    if (string.IsNullOrEmpty(o.ProductType))
                                    {
                                        o.ProductType = const_parameters.product_type;
                                        //DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt01);
                                        //return;
                                    }
                                    if (string.IsNullOrEmpty(o.CellDate))
                                    {
                                        o.CellDate = const_parameters.cell_mfg_date;
                                        //DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt02);
                                        //return;
                                    }
                                    if (string.IsNullOrEmpty(o.PackedDate))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt03);
                                        return;
                                    }
                                    if (string.IsNullOrEmpty(o.Pmax))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt04);
                                        return;
                                    }
                                    if (string.IsNullOrEmpty(o.Voc))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt05);
                                        return;
                                    }
                                    if (string.IsNullOrEmpty(o.Vpm))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt06);
                                        return;
                                    }
                                    if (string.IsNullOrEmpty(o.Ipm))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt07);
                                        return;
                                    }
                                    if (string.IsNullOrEmpty(o.Isc))
                                    {
                                        DoFailStuff(m_sSerialNumber + " " + Resources.strPrompt08);
                                        return;
                                    }
                                    #endregion

                                    ShowIVCurves(double.Parse(o.Isc), double.Parse(o.Ipm), double.Parse(o.Vpm), double.Parse(o.Voc));

                                    o.customer = cbx_customer.SelectedValue.ToString();
                                    //SetRFIDConstants(o.customer);

                                    oModuleInfo = o;

                                    paintBackgroundColor(statusType.PASS);

                                    ShowModuleInfo(true, const_parameters);

                                    WriteLog(lrtxtLog, m_sSerialNumber + " " + "获取功率信息成功！", 0);

                                    SetSerialTxtFocus();
                                }
                                else
                                {
                                    DoFailStuff("与服务器通讯发生异常" + ex.Message);
                                    //WriteLog(lrtxtLog, "与服务器通讯发生异常"+ex.Message, 1);
                                    //common.rf_beep(ReaderInfo.icdev, 20);
                                    //paintBackgroundColor(statusType.FAIL);
                                    //List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Fail", "" };
                                    //WriteCSVLog.WriteCSV(csvValueList);
                                    //SetSerialTxtFocus();
                                    //Speech("烧录失败");
                                }
                            }, new string[] { m_sSerialNumber, m_sTagUIDstring });
                            #endregion}
                        }
                    }

                    
                }
            }
        }

        /// <summary>
        /// set rfid's constants by customer
        /// </summary>
        //private void SetRFIDConstants(string customer)
        //{
        //    ms_cfg_mfg_name = "";
        //    ms_cfg_mfg_country = "";
        //    ms_iec_date = "";
        //    ms_iec_verfy = "";
        //    ms_iso = "";
        //    ms_producttype = "";

        //    if (dic_customer_RFID_constants.ContainsKey(customer))
        //    {
        //        RFIDConstants rc = dic_customer_RFID_constants[customer];

        //        ms_cfg_mfg_name = rc.mfg_name;
        //        ms_cfg_mfg_country = rc.mfg_country;
        //        ms_iec_date = rc.iec_date;
        //        ms_iec_verfy = rc.iec_verfy;
        //        ms_iso = rc.iso_desc;
        //        ms_producttype = rc.product_type;
        //    }

        //}

        private void DoFailStuff(string promptMsg)
        {
            paintBackgroundColor(statusType.FAIL);
            WriteLog(lrtxtLog, promptMsg, 1);
            common.rf_beep(ReaderInfo.icdev, 20);

            List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Fail", "" };
            WriteCSVLog.WriteCSV(csvValueList);
            SetSerialTxtFocus();
            Speech("烧录失败");
        }

        private void ShowIVCurves(double ioc, double ipm, double vpm, double voc )
        { 
             I_V_Point[] oriPointArray = new I_V_Point[3];
             I_V_Point ivp = new I_V_Point(ioc, 0);
            oriPointArray[0] = ivp;
            ivp = new I_V_Point(ipm, vpm);
            oriPointArray[1] = ivp;
            ivp = new I_V_Point(0, voc);
            oriPointArray[2] = ivp;
            ivCurves1.SetOriginalPoints(oriPointArray, true);
        }

        private void CleanIVCurves()
        { 
            ivCurves1.SetOriginalPoints(null, true);
        }

        private void WriteLog2DB()
        {

            //string basicInfo = "";

            WcfCaller.WriteLog(ex => {
                if (ex==null)
                {
                    paintBackgroundColor(statusType.PASS);
                    WriteLog(lrtxtLog, m_sSerialNumber + " " + "烧录成功！", 0);
                    common.rf_beep(ReaderInfo.icdev, 10);
                    List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Pass",m_sTagUIDstring, m_sBasicInfo };
                    WriteCSVLog.WriteCSV(csvValueList);
                    ShowModuleInfo(true, const_parameters);
                    Speech("烧录成功");
                }
                else
                {
                    paintBackgroundColor(statusType.FAIL);
                    WriteLog(lrtxtLog, m_sSerialNumber + " " + "写记录到数据库失败！", 1);
                    common.rf_beep(ReaderInfo.icdev, 20);
                    List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Fail", "" };
                    WriteCSVLog.WriteCSV(csvValueList);
                    Speech("烧录失败");
                }

                SetSerialTxtFocus();


            }, new string[] { m_sTagUIDstring, m_sSerialNumber, m_sBasicInfo });
        }

        private void Speech(string sWorld)
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.SpeakAsync(sWorld);
            }
            catch (Exception)
            {
                
                //throw;
            }
            
        }

        #region communication with RFID reader
        
        private bool GetTagUID()
        {
            //only can inventery 1 tag, because the reader is a shit
            UInt16 byteLen = 0;
            byte[] ary_data = new byte[9];    //the first byte is DSFID, and the other 8 byte containers the UID data
            try
            {
                int loop = 0;
                bool stopLoop = false;
                
                /*
                * loop 30 second to find tag
                */
                while (loop < 300  && !stopLoop)
                {
                    st = ISO15693Commands.rf_inventory(ReaderInfo.icdev, 0x36, 0x00, 0x00, out byteLen, ary_data);

                    stopLoop = st == 0 ? true : false;

                    loop++;

                    System.Threading.Thread.Sleep(100);
                }

                if (st != 0)
                {
                    //MessageBox.Show("未发现单个标签");
                    return false;
                }
                else
                {
                    Array.Copy(ary_data, 1, m_btTagUID, 0, 8);

                    byte[] msbFstUID = new byte[8];
                    Array.Copy(m_btTagUID, msbFstUID, 8);
                    Array.Reverse(msbFstUID);

                    m_sTagUIDstring = CCommondMethod.ByteArrayToString(msbFstUID, 0, 8);

                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /*
         * write data to tag, the first two byte contains data length, 
         * the develop note says the reader can doing write 10 blocks one time, 
         * but reality is it only can write 1 block one time. 
         * totally shit
         */
        private bool WriteData(string data)
        {
            try
            {
                byte[] dataLen = BitConverter.GetBytes(Convert.ToInt16(data.Length));
                byte[] dataBytes = Encoding.ASCII.GetBytes(data);
                byte[] writenDataAll = new byte[data.Length + 4];

                dataLen.CopyTo(writenDataAll, 2);               //data length stored in the third and forth byte
                dataBytes.CopyTo(writenDataAll, 4);             //usefal data starts from next block--the fifth byte

                int i_totalBytes = data.Length + 4;    //UOM is byte
                st = 0;

                byte blockIndex = 0;
                int byteIndex = 0;
                while (i_totalBytes > 0 && st == 0)
                {
                    //calculate the byte number of writen data, the max number is 10 block = 40 bytes
                    byte byteNumber = i_totalBytes > 4 ? (byte)4 : (byte)i_totalBytes;

                    byte[] writenData = new byte[4];//the minimum writen unit is block
                    Array.Copy(writenDataAll, byteIndex, writenData, 0, byteNumber);

                    st = ISO15693Commands.rf_writeblock(ReaderInfo.icdev, 0x22, blockIndex, (byte)1, m_btTagUID, (byte)4, writenData);

                    if (st != 0)
                    {
                        return false;
                    }

                    byteIndex += byteNumber;
                    blockIndex += 1;
                    i_totalBytes -= byteNumber;

                    System.Threading.Thread.Sleep(20);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        private bool WriteData(byte[] dataBytes)
        {
            try
            {
                byte[] dataLen = BitConverter.GetBytes(dataBytes.Length);
                byte[] writenDataAll = new byte[dataBytes.Length + 4];

                dataLen.CopyTo(writenDataAll, 2);               //data length stored in the third and forth byte
                dataBytes.CopyTo(writenDataAll, 4);             //usefal data starts from next block--the fifth byte

                int i_totalBytes = dataBytes.Length + 4;    //UOM is byte
                st = 0;

                byte blockIndex = 0;
                int byteIndex = 0;
                while (i_totalBytes > 0 && st == 0)
                {
                    //writing data block by block
                    byte byteNumber = i_totalBytes > 4 ? (byte)4 : (byte)i_totalBytes;

                    byte[] writenData = new byte[4];//the minimum writen unit is block
                    Array.Copy(writenDataAll, byteIndex, writenData, 0, byteNumber);

                    st = ISO15693Commands.rf_writeblock(ReaderInfo.icdev, 0x22, blockIndex, (byte)1, m_btTagUID, (byte)4, writenData);

                    if (st != 0)
                    {
                        return false;
                    }

                    byteIndex += byteNumber;
                    blockIndex += 1;
                    i_totalBytes -= byteNumber;

                    System.Threading.Thread.Sleep(20);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
       
        #endregion
        
        #region control ui handler
        private delegate void WriteLogUnSafe(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType);
        private void WriteLog(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType)
        {
            if (this.InvokeRequired)
            {
                WriteLogUnSafe InvokeWriteLog = new WriteLogUnSafe(WriteLog);
                this.Invoke(InvokeWriteLog, new object[] { logRichTxt, strLog, nType });
            }
            else
            {
                if (nType == 0)
                {
                    logRichTxt.AppendTextEx(strLog, Color.Indigo);
                }
                else
                {
                    logRichTxt.AppendTextEx(strLog, Color.Red);
                }

                if (ckClearOperationRec.Checked)
                {
                    if (logRichTxt.Lines.Length > 50)
                    {
                        logRichTxt.Clear();
                    }
                }

                logRichTxt.Select(logRichTxt.TextLength, 0);
                logRichTxt.ScrollToCaret();
            }
        }

        enum statusType
        {
            START,
            PASS,
            FAIL
        }

        private delegate void paintBackgroundColorDlgt(statusType st);
        private void paintBackgroundColor(statusType st)
        {
            if (this.InvokeRequired)
            {
                paintBackgroundColorDlgt InvokepaintBackgroundColor = new paintBackgroundColorDlgt(paintBackgroundColor);
                this.Invoke(InvokepaintBackgroundColor, new object[] { st });
            }
            else
            {
                switch (st)
                {
                    case statusType.START:
                        this.BackColor = Color.White;
                        //tbx_SerialWrite.Enabled = false;
                        m_sTagUIDstring = "";
                        m_sSerialNumber = "";
                        //SetLabelStatus(statusType.START);
                        tbx_SerialWrite.Text = "";
                        break;
                    case statusType.FAIL:
                        this.BackColor = Color.Red;
                        tbx_SerialWrite.Enabled = true;
                        SetLabelStatus(statusType.FAIL);
                        timer.Change(5000, System.Threading.Timeout.Infinite);
                        break;
                    case statusType.PASS:
                        this.BackColor = Color.LightGreen;
                        tbx_SerialWrite.Enabled = true;
                        SetLabelStatus(statusType.PASS);
                        timer.Change(5000, System.Threading.Timeout.Infinite);
                        break;
                    default:
                        break;
                }

                this.Refresh();
            }
        }

        private delegate void EnableControlDlgt(int btnIndex);
        private void EnableControl(int idx)
        {
            if (this.InvokeRequired)
            {
                EnableControlDlgt InvokeEnableControl = new EnableControlDlgt(EnableControl);
                this.Invoke(InvokeEnableControl, new object[] { idx });
            }
            else
            {
                if (idx == 1)
                {
                    tbx_SerialWrite.Enabled = true;
                }
                else if (idx == 2)
                {
                    //tbx_readSerial.Enabled = true;
                }
            }
        }


        private delegate void SetFocusDlgt();
        private void SetSerialTxtFocus() {
            if (this.InvokeRequired)
            {
                SetFocusDlgt InvokeEnableControl = new SetFocusDlgt(SetSerialTxtFocus);
                this.Invoke(InvokeEnableControl, null );
            }
            else
            {
                tbx_SerialWrite.Text = "";
                tbx_SerialWrite.Focus();
                //tbx_SerialWrite.SelectAll();

            }
        }

        private delegate void SetLabelStatusDlgt(statusType st);
        private void SetLabelStatus(statusType st)
        {
            if (this.InvokeRequired)
            {
                SetLabelStatusDlgt InvokeEnableControl = new SetLabelStatusDlgt(SetLabelStatus);
                this.Invoke(InvokeEnableControl, new object[] { st });
            }
            else
            {
                switch (st) { 
                    case statusType.START:
                        tbx_status.Text = "";
                        tbx_status.BackColor = Color.LightGray;
                        //CleanIVCurves();
                        break;
                    case statusType.PASS:
                        tbx_status.Text = "OK";
                        tbx_status.BackColor = Color.LightGreen;
                        break;
                    case statusType.FAIL:
                        tbx_status.Text = "NG";
                        tbx_status.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }

            }
        }


        private delegate void ShowModuleInfoDlgt(bool bSuccess, RFIDConstants constParameters);
        private void ShowModuleInfo(bool bSuccess,RFIDConstants constParameters)
        {
            if (this.InvokeRequired)
            {
                ShowModuleInfoDlgt InvokeShowModuleInfo = new ShowModuleInfoDlgt(ShowModuleInfo);
                this.Invoke(InvokeShowModuleInfo, new object[] { bSuccess, constParameters });
            }
            else
            {
                if (!bSuccess)
                {
                    //tbx_SerialWrite.Text = "";
                    tbx_celldate.Text = "";
                    tbx_ipm.Text = "";
                    tbx_isc.Text = "";
                    tbx_packdate.Text = "";
                    tbx_pmax.Text = "";
                    tbx_prodtype.Text = "";
                    tbx_voc.Text = "";
                    tbx_vpm.Text = "";
                    tbx_ff.Text = "";

                    textBox5.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    txtCellName.Text = "";
                    txtMFGName.Text = "";

                }
                else
                {
                    //modify by xue lei on 2018-9-28 测试参数显示小数点后两位

                    //tbx_SerialWrite.Text = "";
                    tbx_celldate.Text = oModuleInfo.CellDate;
                    tbx_ipm.Text = ((int)(Convert.ToDouble(oModuleInfo.Ipm) * 100) / 100.00).ToString(); 
                    tbx_isc.Text = ((int)(Convert.ToDouble(oModuleInfo.Isc) * 100) / 100.00).ToString(); //oModuleInfo.Isc;
                    tbx_packdate.Text = oModuleInfo.PackedDate;
                    tbx_pmax.Text = ((int)(Convert.ToDouble(oModuleInfo.Pmax) * 100) / 100.00).ToString(); //oModuleInfo.Pmax;
                    tbx_prodtype.Text = oModuleInfo.ProductType;
                    tbx_voc.Text = ((int)(Convert.ToDouble(oModuleInfo.Voc) * 100) / 100.00).ToString();//oModuleInfo.Voc;
                    //tbx_vpm.Text = (Convert.ToDecimal(Convert.ToInt32(Decimal.Parse(oModuleInfo.Vpm) * 100M)) / 100M).ToString(); ;//oModuleInfo.Vpm;
                    tbx_vpm.Text = ((int)(Convert.ToDouble(oModuleInfo.Vpm) * 100) / 100.00).ToString();
                    //string stemp = oModuleInfo.Pivf;
                    tbx_ff.Text = ((int)(Convert.ToDouble(oModuleInfo.FF) * 100) / 100.00).ToString();//oModuleInfo.FF;
                    txtMFGName.Text = constParameters.mfg_name;
                    //textBox5.Text = oModuleInfo.cell_supplier_country;
                    //textBox1.Text = oModuleInfo.iec_date;
                    //textBox3.Text = oModuleInfo.iec_verfy;
                    //textBox4.Text = oModuleInfo.iso;
                    //textBox2.Text = constParameters.mfg_name;                          //oModuleInfo.mfg_name;
                    textBox5.Text = constParameters.mfg_country;                       //oModuleInfo.cell_supplier_country;
                    textBox1.Text = constParameters.iec_date;                          //oModuleInfo.iec_date;
                    textBox3.Text = constParameters.iec_verfy;                         //oModuleInfo.iec_verfy;
                    //txt_iso9000_name.Text = constParameters.iso_9000_name;
                    //txt_iso9000_date.Text = constParameters.iso_9000_date;
                    //txt_iso14000_name.Text = constParameters.iso_14000_name;
                    //txt_iso14000_date.Text = constParameters.iso_14000_date;
                    //txt_polarity.Text = constParameters.polarity_of_terminal;
                    //txt_max_sys_voltage.Text = constParameters.max_sys_vol;
                    //txt_cell_source.Text = constParameters.cellsource_country;
                    txtCellName.Text = constParameters.cell_mfg;

                }

            }
        }
        #endregion

        private void WriteTag1_Activated(object sender, EventArgs e)
        {
            /*
             * when write form is activated, should disable read tag form
             */

            ReadTag1._read_tag_timer_enable = false;
        }

        //读取csv
        /// <summary>
        /// Odbc查询CSV
        /// </summary>
        public byte[] QueryCSVToOdbc(RFIDConstants configData,string lot)
        {
            ModuleInfo objModule = new ModuleInfo();

            //读取配置文件
            string path = new Jsonhelp().readjson("CSVFilePath", AppDomain.CurrentDomain.BaseDirectory + "config.json");
            //path = path.Replace("\\\\", "\\");
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("没有找到CSV文件");
                paintBackgroundColor(statusType.FAIL);
                return null;
            }
            string newfilename= System.DateTime.Now.ToString("yyyyMMddHHmmss")+".csv";
            string newfilepath = AppDomain.CurrentDomain.BaseDirectory + newfilename;
            System.IO.File.Copy(path, newfilepath);

            //文件路径
            string tableName = newfilepath.Substring(newfilepath.LastIndexOf('\\') + 1);
            string filePath = newfilepath.Substring(0, newfilepath.LastIndexOf('\\') + 1);//AppDomain.CurrentDomain.BaseDirectory;

            string pContent = string.Empty;

            OdbcConnection odbcConn = new OdbcConnection();
            OdbcCommand odbcCmd = new OdbcCommand();
            OdbcDataReader dataReader;
            try
            {
                string strConnOledb = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=";
                strConnOledb += filePath;
                strConnOledb += ";Extensions=csv,txt;";

                odbcConn.ConnectionString = strConnOledb;
                odbcConn.Open();
                StringBuilder commandText = new StringBuilder("SELECT  ");
                commandText.AppendFormat("Date,Time,Snr,Voc,Isc,Pmax,Vpmax,Ipmax,FF From {0} where Snr ='"+lot+"' ", tableName);
                odbcCmd.Connection = odbcConn;
                odbcCmd.CommandText = commandText.ToString();
                dataReader = odbcCmd.ExecuteReader(CommandBehavior.CloseConnection);
                string moduletime = string.Empty;
                if (dataReader.Read())
                {
                    moduletime = DateTime.Parse(dataReader["Date"].ToString()).ToString("yyyy-MM-dd");//+ " " + DateTime.Parse(dataReader["Time"].ToString()).ToString("HH:mm:ss");
                    objModule.PackedDate = moduletime;
                    //电池生产时间从配置文件获取 modify by xue lei on 2018-9-28
                    objModule.CellDate = configData.cell_mfg_date;//new Jsonhelp().readjson("CellProductionDate", AppDomain.CurrentDomain.BaseDirectory + "config.json");  //moduletime;
                    objModule.Pmax = dataReader["Pmax"].ToString();
                    objModule.Voc = dataReader["Voc"].ToString();
                    objModule.Vpm = dataReader["Vpmax"].ToString();
                    objModule.Ipm = dataReader["Ipmax"].ToString();
                    objModule.Isc = dataReader["Isc"].ToString();
                    objModule.FF = dataReader["FF"].ToString();
                    objModule.Module_ID = lot;
                    objModule.ProductType = configData.product_type;
                }
                else
                {
                    DoFailStuff(m_sSerialNumber + " " + "未找到组件记录！");
                }
                //dataReader.Close();
                ShowIVCurves(double.Parse(objModule.Isc), double.Parse(objModule.Ipm), double.Parse(objModule.Vpm), double.Parse(objModule.Voc));
                byte[] btData = TagDataFormat.CreateByteArray(objModule, configData);
                oModuleInfo = objModule;
                ShowModuleInfo(true, configData);
                paintBackgroundColor(statusType.PASS);
                return btData;
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                odbcConn.Close();
                byte[] data = null;
                return data;
            }
            finally
            {
                odbcConn.Close();
            }
        }

        public void WriteRfid(byte[] data)
        {
            if (data != null)
            {
                if (WriteData(data))
                {
                    //WriteLog2DB();

                    paintBackgroundColor(statusType.PASS);
                    WriteLog(lrtxtLog, m_sSerialNumber + " " + "烧录成功！", 0);
                    common.rf_beep(ReaderInfo.icdev, 10);
                    List<string> csvValueList = new List<string> { System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), m_sSerialNumber, "Pass", m_sTagUIDstring, m_sBasicInfo };
                    WriteCSVLog.WriteCSV(csvValueList);
                    
                    Speech("烧录成功");
                    tbx_SerialWrite.Focus();
                }
                else
                {
                    DoFailStuff(m_sSerialNumber + " " + "烧录失败！");
                }
            }
        } 
    }

    public class CustomerInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
