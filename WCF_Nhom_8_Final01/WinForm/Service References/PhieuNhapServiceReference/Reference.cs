﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.PhieuNhapServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhieuNhap", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class PhieuNhap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaPhieuNhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayNhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NhaSX_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhieuNhap_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenNhaSXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TongTienField;
        
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
        public string MaPhieuNhap {
            get {
                return this.MaPhieuNhapField;
            }
            set {
                if ((object.ReferenceEquals(this.MaPhieuNhapField, value) != true)) {
                    this.MaPhieuNhapField = value;
                    this.RaisePropertyChanged("MaPhieuNhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayNhap {
            get {
                return this.NgayNhapField;
            }
            set {
                if ((this.NgayNhapField.Equals(value) != true)) {
                    this.NgayNhapField = value;
                    this.RaisePropertyChanged("NgayNhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NhaSX_ID {
            get {
                return this.NhaSX_IDField;
            }
            set {
                if ((this.NhaSX_IDField.Equals(value) != true)) {
                    this.NhaSX_IDField = value;
                    this.RaisePropertyChanged("NhaSX_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhieuNhap_ID {
            get {
                return this.PhieuNhap_IDField;
            }
            set {
                if ((this.PhieuNhap_IDField.Equals(value) != true)) {
                    this.PhieuNhap_IDField = value;
                    this.RaisePropertyChanged("PhieuNhap_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenNhaSX {
            get {
                return this.TenNhaSXField;
            }
            set {
                if ((object.ReferenceEquals(this.TenNhaSXField, value) != true)) {
                    this.TenNhaSXField = value;
                    this.RaisePropertyChanged("TenNhaSX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TongTien {
            get {
                return this.TongTienField;
            }
            set {
                if ((this.TongTienField.Equals(value) != true)) {
                    this.TongTienField = value;
                    this.RaisePropertyChanged("TongTien");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PhieuNhapServiceReference.IPhieuNhapService")]
    public interface IPhieuNhapService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhieuNhapService/HienThiPhieuNhap", ReplyAction="http://tempuri.org/IPhieuNhapService/HienThiPhieuNhapResponse")]
        WinForm.PhieuNhapServiceReference.PhieuNhap[] HienThiPhieuNhap();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhieuNhapService/TimKiem", ReplyAction="http://tempuri.org/IPhieuNhapService/TimKiemResponse")]
        WinForm.PhieuNhapServiceReference.PhieuNhap[] TimKiem(WinForm.PhieuNhapServiceReference.PhieuNhap pn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhieuNhapService/Them", ReplyAction="http://tempuri.org/IPhieuNhapService/ThemResponse")]
        void Them(WinForm.PhieuNhapServiceReference.PhieuNhap pn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhieuNhapService/Sua_TongTien", ReplyAction="http://tempuri.org/IPhieuNhapService/Sua_TongTienResponse")]
        void Sua_TongTien(WinForm.PhieuNhapServiceReference.PhieuNhap pn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPhieuNhapServiceChannel : WinForm.PhieuNhapServiceReference.IPhieuNhapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PhieuNhapServiceClient : System.ServiceModel.ClientBase<WinForm.PhieuNhapServiceReference.IPhieuNhapService>, WinForm.PhieuNhapServiceReference.IPhieuNhapService {
        
        public PhieuNhapServiceClient() {
        }
        
        public PhieuNhapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PhieuNhapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhieuNhapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhieuNhapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinForm.PhieuNhapServiceReference.PhieuNhap[] HienThiPhieuNhap() {
            return base.Channel.HienThiPhieuNhap();
        }
        
        public WinForm.PhieuNhapServiceReference.PhieuNhap[] TimKiem(WinForm.PhieuNhapServiceReference.PhieuNhap pn) {
            return base.Channel.TimKiem(pn);
        }
        
        public void Them(WinForm.PhieuNhapServiceReference.PhieuNhap pn) {
            base.Channel.Them(pn);
        }
        
        public void Sua_TongTien(WinForm.PhieuNhapServiceReference.PhieuNhap pn) {
            base.Channel.Sua_TongTien(pn);
        }
    }
}
