﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace ServiceClient.TinTucDaoTaoWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TinTucDaoTaoWSSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class TinTucDaoTaoWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CallServiceOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TinTucDaoTaoWS() {
            this.Url = global::ServiceClient.Properties.Settings.Default.ServiceClient_TinTucDaoTaoWS_TinTucDaoTaoWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CallServiceCompletedEventHandler CallServiceCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CallService", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TinTucDaoTaoWSI CallService(TinTucDaoTaoWSI wsi) {
            object[] results = this.Invoke("CallService", new object[] {
                        wsi});
            return ((TinTucDaoTaoWSI)(results[0]));
        }
        
        /// <remarks/>
        public void CallServiceAsync(TinTucDaoTaoWSI wsi) {
            this.CallServiceAsync(wsi, null);
        }
        
        /// <remarks/>
        public void CallServiceAsync(TinTucDaoTaoWSI wsi, object userState) {
            if ((this.CallServiceOperationCompleted == null)) {
                this.CallServiceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallServiceOperationCompleted);
            }
            this.InvokeAsync("CallService", new object[] {
                        wsi}, this.CallServiceOperationCompleted, userState);
        }
        
        private void OnCallServiceOperationCompleted(object arg) {
            if ((this.CallServiceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CallServiceCompleted(this, new CallServiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TinTucDaoTaoWSI {
        
        private TinTucDaoTao[] tinTucDaoTaoField;
        
        private TheLoaiTin[] theLoaiTinField;
        
        private CanBoGiaoVien[] canBoGiaoVienField;
        
        private ChucVu[] chucVuField;
        
        private string isWsiErrorField;
        
        private object[] wsiErrorField;
        
        private string modeField;
        
        /// <remarks/>
        public TinTucDaoTao[] TinTucDaoTao {
            get {
                return this.tinTucDaoTaoField;
            }
            set {
                this.tinTucDaoTaoField = value;
            }
        }
        
        /// <remarks/>
        public TheLoaiTin[] TheLoaiTin {
            get {
                return this.theLoaiTinField;
            }
            set {
                this.theLoaiTinField = value;
            }
        }
        
        /// <remarks/>
        public CanBoGiaoVien[] CanBoGiaoVien {
            get {
                return this.canBoGiaoVienField;
            }
            set {
                this.canBoGiaoVienField = value;
            }
        }
        
        /// <remarks/>
        public ChucVu[] ChucVu {
            get {
                return this.chucVuField;
            }
            set {
                this.chucVuField = value;
            }
        }
        
        /// <remarks/>
        public string IsWsiError {
            get {
                return this.isWsiErrorField;
            }
            set {
                this.isWsiErrorField = value;
            }
        }
        
        /// <remarks/>
        public object[] WsiError {
            get {
                return this.wsiErrorField;
            }
            set {
                this.wsiErrorField = value;
            }
        }
        
        /// <remarks/>
        public string Mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TinTucDaoTao {
        
        private int idField;
        
        private System.Nullable<int> matltField;
        
        private string macbgvField;
        
        private string tieudeField;
        
        private string tomtatField;
        
        private string noidungField;
        
        private string filedinhkemField;
        
        private System.Nullable<System.DateTime> thoigianField;
        
        private string hinhanhField;
        
        private System.Nullable<System.DateTime> deleteDateField;
        
        private System.Nullable<int> deleteUserIdField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Matlt {
            get {
                return this.matltField;
            }
            set {
                this.matltField = value;
            }
        }
        
        /// <remarks/>
        public string Macbgv {
            get {
                return this.macbgvField;
            }
            set {
                this.macbgvField = value;
            }
        }
        
        /// <remarks/>
        public string Tieude {
            get {
                return this.tieudeField;
            }
            set {
                this.tieudeField = value;
            }
        }
        
        /// <remarks/>
        public string Tomtat {
            get {
                return this.tomtatField;
            }
            set {
                this.tomtatField = value;
            }
        }
        
        /// <remarks/>
        public string Noidung {
            get {
                return this.noidungField;
            }
            set {
                this.noidungField = value;
            }
        }
        
        /// <remarks/>
        public string Filedinhkem {
            get {
                return this.filedinhkemField;
            }
            set {
                this.filedinhkemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> Thoigian {
            get {
                return this.thoigianField;
            }
            set {
                this.thoigianField = value;
            }
        }
        
        /// <remarks/>
        public string Hinhanh {
            get {
                return this.hinhanhField;
            }
            set {
                this.hinhanhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> DeleteDate {
            get {
                return this.deleteDateField;
            }
            set {
                this.deleteDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> DeleteUserId {
            get {
                return this.deleteUserIdField;
            }
            set {
                this.deleteUserIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ChucVu {
        
        private int macvField;
        
        private string tencvField;
        
        /// <remarks/>
        public int Macv {
            get {
                return this.macvField;
            }
            set {
                this.macvField = value;
            }
        }
        
        /// <remarks/>
        public string Tencv {
            get {
                return this.tencvField;
            }
            set {
                this.tencvField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CanBoGiaoVien {
        
        private string macbgvField;
        
        private System.Nullable<int> macvField;
        
        private string tencbgvField;
        
        private string sodtField;
        
        private string emailField;
        
        private System.Nullable<System.DateTime> ngaysinhField;
        
        private string noisinhField;
        
        private string noithuongtruField;
        
        private string gioitinhField;
        
        private string dantocField;
        
        private string tongiaoField;
        
        private string socmndField;
        
        private string matkhauField;
        
        private System.Nullable<System.DateTime> deleteDateField;
        
        private System.Nullable<int> deleteUserIdField;
        
        /// <remarks/>
        public string Macbgv {
            get {
                return this.macbgvField;
            }
            set {
                this.macbgvField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Macv {
            get {
                return this.macvField;
            }
            set {
                this.macvField = value;
            }
        }
        
        /// <remarks/>
        public string Tencbgv {
            get {
                return this.tencbgvField;
            }
            set {
                this.tencbgvField = value;
            }
        }
        
        /// <remarks/>
        public string Sodt {
            get {
                return this.sodtField;
            }
            set {
                this.sodtField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> Ngaysinh {
            get {
                return this.ngaysinhField;
            }
            set {
                this.ngaysinhField = value;
            }
        }
        
        /// <remarks/>
        public string Noisinh {
            get {
                return this.noisinhField;
            }
            set {
                this.noisinhField = value;
            }
        }
        
        /// <remarks/>
        public string Noithuongtru {
            get {
                return this.noithuongtruField;
            }
            set {
                this.noithuongtruField = value;
            }
        }
        
        /// <remarks/>
        public string Gioitinh {
            get {
                return this.gioitinhField;
            }
            set {
                this.gioitinhField = value;
            }
        }
        
        /// <remarks/>
        public string Dantoc {
            get {
                return this.dantocField;
            }
            set {
                this.dantocField = value;
            }
        }
        
        /// <remarks/>
        public string Tongiao {
            get {
                return this.tongiaoField;
            }
            set {
                this.tongiaoField = value;
            }
        }
        
        /// <remarks/>
        public string Socmnd {
            get {
                return this.socmndField;
            }
            set {
                this.socmndField = value;
            }
        }
        
        /// <remarks/>
        public string Matkhau {
            get {
                return this.matkhauField;
            }
            set {
                this.matkhauField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> DeleteDate {
            get {
                return this.deleteDateField;
            }
            set {
                this.deleteDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> DeleteUserId {
            get {
                return this.deleteUserIdField;
            }
            set {
                this.deleteUserIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TheLoaiTin {
        
        private int matltField;
        
        private string tentltField;
        
        /// <remarks/>
        public int Matlt {
            get {
                return this.matltField;
            }
            set {
                this.matltField = value;
            }
        }
        
        /// <remarks/>
        public string Tentlt {
            get {
                return this.tentltField;
            }
            set {
                this.tentltField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void CallServiceCompletedEventHandler(object sender, CallServiceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CallServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CallServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TinTucDaoTaoWSI Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TinTucDaoTaoWSI)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591