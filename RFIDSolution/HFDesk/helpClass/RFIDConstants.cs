using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFDesk.helpClass
{
    public class RFIDConstants
    {
        /// <summary>
        /// 组件产地
        /// </summary>
        public string mfg_country { get; set; }
        /// <summary>
        /// 组件厂商
        /// </summary>
        public string mfg_name { get; set; }
        /// <summary>
        /// 证书颁发日期
        /// </summary>
        public string iec_date { get; set; }
        /// <summary>
        /// 证书颁发者
        /// </summary>
        public string iec_verfy { get; set; }
        /// <summary>
        /// 证书名称
        /// </summary>
        public string iso_desc { get; set; }

        /// <summary>
        /// 产品族
        /// </summary>
        public string product_type { get; set; }
        /// <summary>
        /// 电池厂商
        /// </summary>
        public string cell_mfg { get; set; }
        /// <summary>
        /// 电池产地
        /// </summary>
        public string cellsource_country { get; set; }
        /// <summary>
        /// 电池生产日期
        /// </summary>
        public string cell_mfg_date { get; set; }


        public string iso_9000_name { get; set; }
        public string iso_9000_date { get; set; }

        public string iso_14000_name { get; set; }
        public string iso_14000_date { get; set; }

        /// <summary>
        /// 终端极性
        /// </summary>
        public string polarity_of_terminal { get; set; }
        /// <summary>
        /// 最大系统电压
        /// </summary>
        public string max_sys_vol { get; set; }
        


        public RFIDConstants(string s_mfg_country, string s_mfg_name, string s_iec_date, string s_iec_verfy, string s_iso_desc, string s_product_type, string s_iso_9000_name, string s_iso_9000_date, string s_iso_14000_name, string s_iso_14000_date, string s_cellsource_country,
            string s_polarity_of_terminal, string s_max_sys_vol, string s_cell_mfg, string s_cell_mfg_date)
        {
            mfg_country = s_mfg_country;
            mfg_name = s_mfg_name;
            iec_date = s_iec_date;
            iec_verfy = s_iec_verfy;
            iso_desc = s_iso_desc;
            product_type = s_product_type;
            iso_9000_name = s_iso_9000_name;
            iso_9000_date = s_iso_9000_date;
            iso_14000_name = s_iso_14000_name;
            iso_14000_date = s_iso_14000_date;
            cellsource_country = s_cellsource_country;
            polarity_of_terminal = s_polarity_of_terminal;
            max_sys_vol = s_max_sys_vol;
            cell_mfg = s_cell_mfg;
            cell_mfg_date = s_cell_mfg_date;
        }
    }
}
