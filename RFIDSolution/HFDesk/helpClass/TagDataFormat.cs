//#define CUSTOMER_RS
#define GENERAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RFIDService.ClientData;
using System.IO;

namespace HFDesk.helpClass
{
    class TagDataFormat
    {

        public static byte[] CreateByteArray(ModuleInfo mi, RFIDConstants const_info)
        {
            //int year = DateTime.Parse(mi.PackedDate).Year;
            //int month = DateTime.Parse(mi.PackedDate).Month;
            //int day = DateTime.Parse(mi.PackedDate).Day;
            //DateTime dateOfModulePacked = new DateTime(year, month, day, 0, 0, 0);

            //year = DateTime.Parse(mi.CellDate).Year;
            //month = DateTime.Parse(mi.CellDate).Month;
            //day = DateTime.Parse(mi.CellDate).Day;
            //DateTime celldate = new DateTime(year, month, day, 0, 0, 0);

            decimal iPmax = Decimal.Parse(mi.Pmax)*100M;
            decimal iVoc = Decimal.Parse(mi.Voc) * 100M;
            decimal iIsc = Decimal.Parse(mi.Isc) * 100M;
            decimal iVpm = Decimal.Parse(mi.Vpm) * 100M;
            decimal iIpm = Decimal.Parse(mi.Ipm) * 100M;
            decimal ff = Decimal.Parse(mi.FF) * 100M;
            
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {

                    writer.Write("@@");
                    //writer.Write(mi.customer);
                    writer.Write(mi.ProductType);
                    writer.Write(mi.Module_ID);
                    writer.Write(const_info.mfg_country);           // 组件产地
                    writer.Write(const_info.mfg_name);              // 组件厂商
                    writer.Write(mi.PackedDate);                    // 组件生产日期
                    writer.Write((int)iPmax);
                    writer.Write((short)iVoc);
                    writer.Write((short)iIsc);
                    writer.Write((short)iVpm);
                    writer.Write((short)iIpm);
                    writer.Write((short)ff);
                    writer.Write(const_info.cell_mfg);              // 电池片生产厂商
                    writer.Write(const_info.cell_mfg_date);         // 电池片生产日期
                    //writer.Write(const_info.cellsource_country);    // 电池片产地
                    //writer.Write(const_info.iso_9000_date);     
                    //writer.Write(const_info.iso_9000_name);
                    //writer.Write(const_info.iso_14000_date);
                    //writer.Write(const_info.iso_14000_name);
                    //writer.Write(const_info.polarity_of_terminal);
                    writer.Write(const_info.iec_date);          //证书日期
                    writer.Write(const_info.iec_verfy);         //证书名称
                    //writer.Write(const_info.max_sys_vol);    



                    writer.Write("##");
                 
                    writer.Close();
                }
                return stream.ToArray();
            }
        }

        /// <summary>
        /// 当前日期减去基准日期相差的天数
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static short DateToInt16(DateTime date)
        {
            TimeSpan span = date - DateTime.Parse("2016-01-01");
            int days = span.Days;
            return (short)days;
        }
    }
}
