﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.TonKhoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TonKho", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class TonKho : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SP_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoLuongTonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ThoiGianField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SP_ID {
            get {
                return this.SP_IDField;
            }
            set {
                if ((this.SP_IDField.Equals(value) != true)) {
                    this.SP_IDField = value;
                    this.RaisePropertyChanged("SP_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SoLuongTon {
            get {
                return this.SoLuongTonField;
            }
            set {
                if ((this.SoLuongTonField.Equals(value) != true)) {
                    this.SoLuongTonField = value;
                    this.RaisePropertyChanged("SoLuongTon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ThoiGian {
            get {
                return this.ThoiGianField;
            }
            set {
                if ((this.ThoiGianField.Equals(value) != true)) {
                    this.ThoiGianField = value;
                    this.RaisePropertyChanged("ThoiGian");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TonKhoServiceReference.ITonKhoService")]
    public interface ITonKhoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/SoLuongTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService/SoLuongTonKho_SPIDResponse")]
        int SoLuongTonKho_SPID(int spid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/HienThiTonKho", ReplyAction="http://tempuri.org/ITonKhoService/HienThiTonKhoResponse")]
        WinForm.TonKhoServiceReference.TonKho[] HienThiTonKho();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/TimKiemTonKho_SPID", ReplyAction="http://tempuri.org/ITonKhoService/TimKiemTonKho_SPIDResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SPID(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/TimKiemTonKho_ThoiGian", ReplyAction="http://tempuri.org/ITonKhoService/TimKiemTonKho_ThoiGianResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_ThoiGian(int thang, int nam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/TimKiemTonKho_Ngay", ReplyAction="http://tempuri.org/ITonKhoService/TimKiemTonKho_NgayResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_Ngay(System.DateTime ngaytu, System.DateTime ngayden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/TimKiemTonKho_SoLuongTon", ReplyAction="http://tempuri.org/ITonKhoService/TimKiemTonKho_SoLuongTonResponse")]
        WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SoLuongTon(int k);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/Them_Moi", ReplyAction="http://tempuri.org/ITonKhoService/Them_MoiResponse")]
        void Them_Moi(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/Them_Nhap", ReplyAction="http://tempuri.org/ITonKhoService/Them_NhapResponse")]
        void Them_Nhap(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/Them_Xuat", ReplyAction="http://tempuri.org/ITonKhoService/Them_XuatResponse")]
        void Them_Xuat(WinForm.TonKhoServiceReference.TonKho tk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITonKhoService/Xoa", ReplyAction="http://tempuri.org/ITonKhoService/XoaResponse")]
        void Xoa(WinForm.TonKhoServiceReference.TonKho tk);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITonKhoServiceChannel : WinForm.TonKhoServiceReference.ITonKhoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TonKhoServiceClient : System.ServiceModel.ClientBase<WinForm.TonKhoServiceReference.ITonKhoService>, WinForm.TonKhoServiceReference.ITonKhoService {
        
        public TonKhoServiceClient() {
        }
        
        public TonKhoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TonKhoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonKhoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TonKhoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SoLuongTonKho_SPID(int spid) {
            return base.Channel.SoLuongTonKho_SPID(spid);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] HienThiTonKho() {
            return base.Channel.HienThiTonKho();
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SPID(WinForm.TonKhoServiceReference.TonKho tk) {
            return base.Channel.TimKiemTonKho_SPID(tk);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_ThoiGian(int thang, int nam) {
            return base.Channel.TimKiemTonKho_ThoiGian(thang, nam);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_Ngay(System.DateTime ngaytu, System.DateTime ngayden) {
            return base.Channel.TimKiemTonKho_Ngay(ngaytu, ngayden);
        }
        
        public WinForm.TonKhoServiceReference.TonKho[] TimKiemTonKho_SoLuongTon(int k) {
            return base.Channel.TimKiemTonKho_SoLuongTon(k);
        }
        
        public void Them_Moi(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.Them_Moi(tk);
        }
        
        public void Them_Nhap(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.Them_Nhap(tk);
        }
        
        public void Them_Xuat(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.Them_Xuat(tk);
        }
        
        public void Xoa(WinForm.TonKhoServiceReference.TonKho tk) {
            base.Channel.Xoa(tk);
        }
    }
}
