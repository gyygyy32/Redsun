﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://www.hulisoft.com/RFIDServiceData", ClrNamespace="RFIDService.ClientData")]

namespace RFIDService.ClientData
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModuleInfo", Namespace="http://www.hulisoft.com/RFIDServiceData")]
    public partial class ModuleInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CellDateField;
        
        private string CellsourceField;
        
        private string ELGradeField;
        
        private string EqpIDField;
        
        private string FFField;
        
        private string IVFilePathField;
        
        private string IpmField;
        
        private string IscField;
        
        private string Module_IDField;
        
        private string PackedDateField;
        
        private string PalletNOField;
        
        private string PivfField;
        
        private string PmaxField;
        
        private string ProductTypeField;
        
        private string StatusField;
        
        private string VocField;
        
        private string VpmField;
        
        private bool b_writenDataBeforeField;
        
        private string cell_mfg_dateField;
        
        private string cell_mfg_nameField;
        
        private string cell_supplier_countryField;
        
        private string customerField;
        
        private string iec_dateField;
        
        private string iec_verfyField;
        
        private string isoField;
        
        private string iso_14000_dateField;
        
        private string iso_14000_nameField;
        
        private string iso_9000_dateField;
        
        private string iso_9000_nameField;
        
        private string max_system_voltageField;
        
        private string mfg_countryField;
        
        private string mfg_nameField;
        
        private string polarity_of_terminalField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CellDate
        {
            get
            {
                return this.CellDateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CellDateField, value) != true))
                {
                    this.CellDateField = value;
                    this.RaisePropertyChanged("CellDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cellsource
        {
            get
            {
                return this.CellsourceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CellsourceField, value) != true))
                {
                    this.CellsourceField = value;
                    this.RaisePropertyChanged("Cellsource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ELGrade
        {
            get
            {
                return this.ELGradeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ELGradeField, value) != true))
                {
                    this.ELGradeField = value;
                    this.RaisePropertyChanged("ELGrade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EqpID
        {
            get
            {
                return this.EqpIDField;
            }
            set
            {
                if ((object.ReferenceEquals(this.EqpIDField, value) != true))
                {
                    this.EqpIDField = value;
                    this.RaisePropertyChanged("EqpID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FF
        {
            get
            {
                return this.FFField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FFField, value) != true))
                {
                    this.FFField = value;
                    this.RaisePropertyChanged("FF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IVFilePath
        {
            get
            {
                return this.IVFilePathField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IVFilePathField, value) != true))
                {
                    this.IVFilePathField = value;
                    this.RaisePropertyChanged("IVFilePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ipm
        {
            get
            {
                return this.IpmField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IpmField, value) != true))
                {
                    this.IpmField = value;
                    this.RaisePropertyChanged("Ipm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Isc
        {
            get
            {
                return this.IscField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IscField, value) != true))
                {
                    this.IscField = value;
                    this.RaisePropertyChanged("Isc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Module_ID
        {
            get
            {
                return this.Module_IDField;
            }
            set
            {
                if ((object.ReferenceEquals(this.Module_IDField, value) != true))
                {
                    this.Module_IDField = value;
                    this.RaisePropertyChanged("Module_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PackedDate
        {
            get
            {
                return this.PackedDateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PackedDateField, value) != true))
                {
                    this.PackedDateField = value;
                    this.RaisePropertyChanged("PackedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PalletNO
        {
            get
            {
                return this.PalletNOField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PalletNOField, value) != true))
                {
                    this.PalletNOField = value;
                    this.RaisePropertyChanged("PalletNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pivf
        {
            get
            {
                return this.PivfField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PivfField, value) != true))
                {
                    this.PivfField = value;
                    this.RaisePropertyChanged("Pivf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pmax
        {
            get
            {
                return this.PmaxField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PmaxField, value) != true))
                {
                    this.PmaxField = value;
                    this.RaisePropertyChanged("Pmax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductType
        {
            get
            {
                return this.ProductTypeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ProductTypeField, value) != true))
                {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusField, value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Voc
        {
            get
            {
                return this.VocField;
            }
            set
            {
                if ((object.ReferenceEquals(this.VocField, value) != true))
                {
                    this.VocField = value;
                    this.RaisePropertyChanged("Voc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vpm
        {
            get
            {
                return this.VpmField;
            }
            set
            {
                if ((object.ReferenceEquals(this.VpmField, value) != true))
                {
                    this.VpmField = value;
                    this.RaisePropertyChanged("Vpm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool b_writenDataBefore
        {
            get
            {
                return this.b_writenDataBeforeField;
            }
            set
            {
                if ((this.b_writenDataBeforeField.Equals(value) != true))
                {
                    this.b_writenDataBeforeField = value;
                    this.RaisePropertyChanged("b_writenDataBefore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cell_mfg_date
        {
            get
            {
                return this.cell_mfg_dateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.cell_mfg_dateField, value) != true))
                {
                    this.cell_mfg_dateField = value;
                    this.RaisePropertyChanged("cell_mfg_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cell_mfg_name
        {
            get
            {
                return this.cell_mfg_nameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.cell_mfg_nameField, value) != true))
                {
                    this.cell_mfg_nameField = value;
                    this.RaisePropertyChanged("cell_mfg_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cell_supplier_country
        {
            get
            {
                return this.cell_supplier_countryField;
            }
            set
            {
                if ((object.ReferenceEquals(this.cell_supplier_countryField, value) != true))
                {
                    this.cell_supplier_countryField = value;
                    this.RaisePropertyChanged("cell_supplier_country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                if ((object.ReferenceEquals(this.customerField, value) != true))
                {
                    this.customerField = value;
                    this.RaisePropertyChanged("customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iec_date
        {
            get
            {
                return this.iec_dateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iec_dateField, value) != true))
                {
                    this.iec_dateField = value;
                    this.RaisePropertyChanged("iec_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iec_verfy
        {
            get
            {
                return this.iec_verfyField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iec_verfyField, value) != true))
                {
                    this.iec_verfyField = value;
                    this.RaisePropertyChanged("iec_verfy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iso
        {
            get
            {
                return this.isoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.isoField, value) != true))
                {
                    this.isoField = value;
                    this.RaisePropertyChanged("iso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iso_14000_date
        {
            get
            {
                return this.iso_14000_dateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iso_14000_dateField, value) != true))
                {
                    this.iso_14000_dateField = value;
                    this.RaisePropertyChanged("iso_14000_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iso_14000_name
        {
            get
            {
                return this.iso_14000_nameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iso_14000_nameField, value) != true))
                {
                    this.iso_14000_nameField = value;
                    this.RaisePropertyChanged("iso_14000_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iso_9000_date
        {
            get
            {
                return this.iso_9000_dateField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iso_9000_dateField, value) != true))
                {
                    this.iso_9000_dateField = value;
                    this.RaisePropertyChanged("iso_9000_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iso_9000_name
        {
            get
            {
                return this.iso_9000_nameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iso_9000_nameField, value) != true))
                {
                    this.iso_9000_nameField = value;
                    this.RaisePropertyChanged("iso_9000_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string max_system_voltage
        {
            get
            {
                return this.max_system_voltageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.max_system_voltageField, value) != true))
                {
                    this.max_system_voltageField = value;
                    this.RaisePropertyChanged("max_system_voltage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mfg_country
        {
            get
            {
                return this.mfg_countryField;
            }
            set
            {
                if ((object.ReferenceEquals(this.mfg_countryField, value) != true))
                {
                    this.mfg_countryField = value;
                    this.RaisePropertyChanged("mfg_country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mfg_name
        {
            get
            {
                return this.mfg_nameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.mfg_nameField, value) != true))
                {
                    this.mfg_nameField = value;
                    this.RaisePropertyChanged("mfg_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string polarity_of_terminal
        {
            get
            {
                return this.polarity_of_terminalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.polarity_of_terminalField, value) != true))
                {
                    this.polarity_of_terminalField = value;
                    this.RaisePropertyChanged("polarity_of_terminal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

namespace RFIDService.Clients
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.hulisoft.com/RFIDService", ConfigurationName="RFIDService.Clients.IRFIDService")]
    public interface IRFIDService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.hulisoft.com/RFIDService/IRFIDService/writeTag", ReplyAction="http://www.hulisoft.com/RFIDService/IRFIDService/writeTagResponse")]
        void writeTag();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.hulisoft.com/RFIDService/IRFIDService/WriteLog", ReplyAction="http://www.hulisoft.com/RFIDService/IRFIDService/WriteLogResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RFIDService.ClientData.ModuleInfo))]
        void WriteLog(object[] parms);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.hulisoft.com/RFIDService/IRFIDService/readTag", ReplyAction="http://www.hulisoft.com/RFIDService/IRFIDService/readTagResponse")]
        void readTag();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.hulisoft.com/RFIDService/IRFIDService/getModuleInfo", ReplyAction="http://www.hulisoft.com/RFIDService/IRFIDService/getModuleInfoResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RFIDService.ClientData.ModuleInfo))]
        RFIDService.ClientData.ModuleInfo getModuleInfo(object[] parms);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRFIDServiceChannel : RFIDService.Clients.IRFIDService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RFIDServiceClient : System.ServiceModel.ClientBase<RFIDService.Clients.IRFIDService>, RFIDService.Clients.IRFIDService
    {
        
        public RFIDServiceClient()
        {
        }
        
        public RFIDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public RFIDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RFIDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RFIDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void writeTag()
        {
            base.Channel.writeTag();
        }
        
        public void WriteLog(object[] parms)
        {
            base.Channel.WriteLog(parms);
        }
        
        public void readTag()
        {
            base.Channel.readTag();
        }
        
        public RFIDService.ClientData.ModuleInfo getModuleInfo(object[] parms)
        {
            return base.Channel.getModuleInfo(parms);
        }
    }
}