﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4971.
// 
namespace QHMobile.VendorListQH {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="VendorListQH_Binding", Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public partial class VendorListQH_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public VendorListQH_Service() {
            this.Url = "http://dpmaster.dptech.local:7045/DynamicsNAVQH/WS/Qian%20Hu/Page/VendorListQH";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlistqh:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("VendorListQH")]
        public VendorListQH Read(string No) {
            object[] results = this.Invoke("Read", new object[] {
                        No});
            return ((VendorListQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRead(string No, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Read", new object[] {
                        No}, callback, asyncState);
        }
        
        /// <remarks/>
        public VendorListQH EndRead(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((VendorListQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlistqh:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("VendorListQH")]
        public VendorListQH ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((VendorListQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadByRecId(string recId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadByRecId", new object[] {
                        recId}, callback, asyncState);
        }
        
        /// <remarks/>
        public VendorListQH EndReadByRecId(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((VendorListQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlistqh:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public VendorListQH[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] VendorListQH_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((VendorListQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadMultiple(VendorListQH_Filter[] filter, string bookmarkKey, int setSize, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize}, callback, asyncState);
        }
        
        /// <remarks/>
        public VendorListQH[] EndReadMultiple(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((VendorListQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlistqh:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("IsUpdated_Result")]
        public bool IsUpdated(string Key) {
            object[] results = this.Invoke("IsUpdated", new object[] {
                        Key});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIsUpdated(string Key, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IsUpdated", new object[] {
                        Key}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndIsUpdated(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/vendorlistqh:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/vendorlistqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetRecIdFromKey_Result")]
        public string GetRecIdFromKey(string Key) {
            object[] results = this.Invoke("GetRecIdFromKey", new object[] {
                        Key});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetRecIdFromKey(string Key, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetRecIdFromKey", new object[] {
                        Key}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetRecIdFromKey(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public partial class VendorListQH {
        
        private string keyField;
        
        private string noField;
        
        private string nameField;
        
        private string responsibility_CenterField;
        
        private string location_CodeField;
        
        private string post_CodeField;
        
        private string country_Region_CodeField;
        
        private string phone_NoField;
        
        private string fax_NoField;
        
        private string iC_Partner_CodeField;
        
        private string contactField;
        
        private string purchaser_CodeField;
        
        private string vendor_Posting_GroupField;
        
        private string gen_Bus_Posting_GroupField;
        
        private string vAT_Bus_Posting_GroupField;
        
        private string payment_Terms_CodeField;
        
        private string fin_Charge_Terms_CodeField;
        
        private string currency_CodeField;
        
        private string language_CodeField;
        
        private string countyField;
        
        private string search_NameField;
        
        private Blocked blockedField;
        
        private bool blockedFieldSpecified;
        
        private System.DateTime last_Date_ModifiedField;
        
        private bool last_Date_ModifiedFieldSpecified;
        
        private Application_Method application_MethodField;
        
        private bool application_MethodFieldSpecified;
        
        private string shipment_Method_CodeField;
        
        private string lead_Time_CalculationField;
        
        private string base_Calendar_CodeField;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Responsibility_Center {
            get {
                return this.responsibility_CenterField;
            }
            set {
                this.responsibility_CenterField = value;
            }
        }
        
        /// <remarks/>
        public string Location_Code {
            get {
                return this.location_CodeField;
            }
            set {
                this.location_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Post_Code {
            get {
                return this.post_CodeField;
            }
            set {
                this.post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Country_Region_Code {
            get {
                return this.country_Region_CodeField;
            }
            set {
                this.country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Phone_No {
            get {
                return this.phone_NoField;
            }
            set {
                this.phone_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Fax_No {
            get {
                return this.fax_NoField;
            }
            set {
                this.fax_NoField = value;
            }
        }
        
        /// <remarks/>
        public string IC_Partner_Code {
            get {
                return this.iC_Partner_CodeField;
            }
            set {
                this.iC_Partner_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        public string Purchaser_Code {
            get {
                return this.purchaser_CodeField;
            }
            set {
                this.purchaser_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Vendor_Posting_Group {
            get {
                return this.vendor_Posting_GroupField;
            }
            set {
                this.vendor_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string Gen_Bus_Posting_Group {
            get {
                return this.gen_Bus_Posting_GroupField;
            }
            set {
                this.gen_Bus_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string VAT_Bus_Posting_Group {
            get {
                return this.vAT_Bus_Posting_GroupField;
            }
            set {
                this.vAT_Bus_Posting_GroupField = value;
            }
        }
        
        /// <remarks/>
        public string Payment_Terms_Code {
            get {
                return this.payment_Terms_CodeField;
            }
            set {
                this.payment_Terms_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Fin_Charge_Terms_Code {
            get {
                return this.fin_Charge_Terms_CodeField;
            }
            set {
                this.fin_Charge_Terms_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Currency_Code {
            get {
                return this.currency_CodeField;
            }
            set {
                this.currency_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Language_Code {
            get {
                return this.language_CodeField;
            }
            set {
                this.language_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        public string Search_Name {
            get {
                return this.search_NameField;
            }
            set {
                this.search_NameField = value;
            }
        }
        
        /// <remarks/>
        public Blocked Blocked {
            get {
                return this.blockedField;
            }
            set {
                this.blockedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlockedSpecified {
            get {
                return this.blockedFieldSpecified;
            }
            set {
                this.blockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Last_Date_Modified {
            get {
                return this.last_Date_ModifiedField;
            }
            set {
                this.last_Date_ModifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Last_Date_ModifiedSpecified {
            get {
                return this.last_Date_ModifiedFieldSpecified;
            }
            set {
                this.last_Date_ModifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Application_Method Application_Method {
            get {
                return this.application_MethodField;
            }
            set {
                this.application_MethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Application_MethodSpecified {
            get {
                return this.application_MethodFieldSpecified;
            }
            set {
                this.application_MethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Shipment_Method_Code {
            get {
                return this.shipment_Method_CodeField;
            }
            set {
                this.shipment_Method_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Lead_Time_Calculation {
            get {
                return this.lead_Time_CalculationField;
            }
            set {
                this.lead_Time_CalculationField = value;
            }
        }
        
        /// <remarks/>
        public string Base_Calendar_Code {
            get {
                return this.base_Calendar_CodeField;
            }
            set {
                this.base_Calendar_CodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public enum Blocked {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Payment,
        
        /// <remarks/>
        All,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public enum Application_Method {
        
        /// <remarks/>
        Manual,
        
        /// <remarks/>
        Apply_to_Oldest,
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public partial class VendorListQH_Filter {
        
        private VendorListQH_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public VendorListQH_Fields Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        public string Criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/vendorlistqh")]
    public enum VendorListQH_Fields {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Name,
        
        /// <remarks/>
        Responsibility_Center,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Post_Code,
        
        /// <remarks/>
        Country_Region_Code,
        
        /// <remarks/>
        Phone_No,
        
        /// <remarks/>
        Fax_No,
        
        /// <remarks/>
        IC_Partner_Code,
        
        /// <remarks/>
        Contact,
        
        /// <remarks/>
        Purchaser_Code,
        
        /// <remarks/>
        Vendor_Posting_Group,
        
        /// <remarks/>
        Gen_Bus_Posting_Group,
        
        /// <remarks/>
        VAT_Bus_Posting_Group,
        
        /// <remarks/>
        Payment_Terms_Code,
        
        /// <remarks/>
        Fin_Charge_Terms_Code,
        
        /// <remarks/>
        Currency_Code,
        
        /// <remarks/>
        Language_Code,
        
        /// <remarks/>
        County,
        
        /// <remarks/>
        Search_Name,
        
        /// <remarks/>
        Blocked,
        
        /// <remarks/>
        Last_Date_Modified,
        
        /// <remarks/>
        Application_Method,
        
        /// <remarks/>
        Shipment_Method_Code,
        
        /// <remarks/>
        Lead_Time_Calculation,
        
        /// <remarks/>
        Base_Calendar_Code,
    }
}
