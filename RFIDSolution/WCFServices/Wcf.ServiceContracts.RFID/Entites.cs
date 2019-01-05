using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace Wcf.ServiceContracts.RFID
{
    [DataContract(Namespace = SvcNameSpace.ContractDataNamespace)]
    public class ModuleInfo
    {
        [DataMember]
        public string ProductType;

        [DataMember]
        public string ELGrade;

        [DataMember]
        public string Status;

        [DataMember]
        public string PackedDate;

        [DataMember]
        public string Pmax;

        [DataMember]
        public string Voc;

        [DataMember]
        public string Isc;

        [DataMember]
        public string Vpm;

        [DataMember]
        public string Ipm;

        [DataMember]
        public string FF;

        [DataMember]
        public string Pivf;

        [DataMember]
        public string Module_ID;

        [DataMember]
        public string PalletNO;

        [DataMember]
        public string CellDate;

        [DataMember]
        public string Cellsource;

        [DataMember]
        public string EqpID;

        [DataMember]
        public string IVFilePath;
       
        [DataMember]
        public string cell_supplier_country;

        [DataMember]
        public string iec_date;

        [DataMember]
        public string iec_verfy;

        [DataMember]
        public string iso;

        [DataMember]
        public string mfg_name;
        [DataMember]
        public string mfg_country;



        [DataMember]
        public bool b_writenDataBefore;

        [DataMember]
        public string customer;

        [DataMember]
        public string iso_9000_name;
        [DataMember]
        public string iso_9000_date;
        [DataMember]
        public string iso_14000_name;
        [DataMember]
        public string iso_14000_date;
        [DataMember]
        public string cell_mfg_name;
        [DataMember]
        public string cell_mfg_date;
        [DataMember]
        public string max_system_voltage;
        [DataMember]
        public string polarity_of_terminal;
        
    }
}
