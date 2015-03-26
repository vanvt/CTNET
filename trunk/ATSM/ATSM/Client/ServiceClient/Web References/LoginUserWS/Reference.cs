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

namespace ServiceClient.LoginUserWS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="LoginUserWSSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class LoginUserWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CallServiceOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LoginUserWS() {
            this.Url = global::ServiceClient.Properties.Settings.Default.ServiceClient_LoginUserWS_LoginUserWS;
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
        public LoginUserWSI CallService(LoginUserWSI wsi) {
            object[] results = this.Invoke("CallService", new object[] {
                        wsi});
            return ((LoginUserWSI)(results[0]));
        }
        
        /// <remarks/>
        public void CallServiceAsync(LoginUserWSI wsi) {
            this.CallServiceAsync(wsi, null);
        }
        
        /// <remarks/>
        public void CallServiceAsync(LoginUserWSI wsi, object userState) {
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
    public partial class LoginUserWSI {
        
        private LoginUser loginUserField;
        
        private string isWsiErrorField;
        
        private object[] wsiErrorField;
        
        private string modeField;
        
        /// <remarks/>
        public LoginUser LoginUser {
            get {
                return this.loginUserField;
            }
            set {
                this.loginUserField = value;
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
    public partial class LoginUser {
        
        private string loginUserIdField;
        
        private string passwordField;
        
        private System.DateTime insertDateField;
        
        private System.DateTime updateDateField;
        
        private System.Nullable<System.DateTime> deleteDateField;
        
        private System.Nullable<int> deleteUserIdField;
        
        private string newPasswordField;
        
        private int statusField;
        
        /// <remarks/>
        public string LoginUserId {
            get {
                return this.loginUserIdField;
            }
            set {
                this.loginUserIdField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime InsertDate {
            get {
                return this.insertDateField;
            }
            set {
                this.insertDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime UpdateDate {
            get {
                return this.updateDateField;
            }
            set {
                this.updateDateField = value;
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
        
        /// <remarks/>
        public string NewPassword {
            get {
                return this.newPasswordField;
            }
            set {
                this.newPasswordField = value;
            }
        }
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public LoginUserWSI Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LoginUserWSI)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591