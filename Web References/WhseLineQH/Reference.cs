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
namespace QHMobile.WhseLineQH {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WhseLineQH_Binding", Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public partial class WhseLineQH_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public WhseLineQH_Service() {
            this.Url = "http://dpmaster.dptech.local:7045/DynamicsNAVQH/WS/Qian%20Hu/Page/WhseLineQH";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("WhseLineQH")]
        public WhseLineQH Read(string Activity_Type, string No, int Line_No) {
            object[] results = this.Invoke("Read", new object[] {
                        Activity_Type,
                        No,
                        Line_No});
            return ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRead(string Activity_Type, string No, int Line_No, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Read", new object[] {
                        Activity_Type,
                        No,
                        Line_No}, callback, asyncState);
        }
        
        /// <remarks/>
        public WhseLineQH EndRead(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("WhseLineQH")]
        public WhseLineQH ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadByRecId(string recId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadByRecId", new object[] {
                        recId}, callback, asyncState);
        }
        
        /// <remarks/>
        public WhseLineQH EndReadByRecId(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public WhseLineQH[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] WhseLineQH_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadMultiple(WhseLineQH_Filter[] filter, string bookmarkKey, int setSize, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize}, callback, asyncState);
        }
        
        /// <remarks/>
        public WhseLineQH[] EndReadMultiple(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:Create", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="Create_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Create(ref WhseLineQH WhseLineQH) {
            object[] results = this.Invoke("Create", new object[] {
                        WhseLineQH});
            WhseLineQH = ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreate(WhseLineQH WhseLineQH, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Create", new object[] {
                        WhseLineQH}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreate(System.IAsyncResult asyncResult, out WhseLineQH WhseLineQH) {
            object[] results = this.EndInvoke(asyncResult);
            WhseLineQH = ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:CreateMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="CreateMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateMultiple([System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] ref WhseLineQH[] WhseLineQH_List) {
            object[] results = this.Invoke("CreateMultiple", new object[] {
                        WhseLineQH_List});
            WhseLineQH_List = ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateMultiple(WhseLineQH[] WhseLineQH_List, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateMultiple", new object[] {
                        WhseLineQH_List}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreateMultiple(System.IAsyncResult asyncResult, out WhseLineQH[] WhseLineQH_List) {
            object[] results = this.EndInvoke(asyncResult);
            WhseLineQH_List = ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:Update", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="Update_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Update(ref WhseLineQH WhseLineQH) {
            object[] results = this.Invoke("Update", new object[] {
                        WhseLineQH});
            WhseLineQH = ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdate(WhseLineQH WhseLineQH, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Update", new object[] {
                        WhseLineQH}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdate(System.IAsyncResult asyncResult, out WhseLineQH WhseLineQH) {
            object[] results = this.EndInvoke(asyncResult);
            WhseLineQH = ((WhseLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:UpdateMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="UpdateMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateMultiple([System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] ref WhseLineQH[] WhseLineQH_List) {
            object[] results = this.Invoke("UpdateMultiple", new object[] {
                        WhseLineQH_List});
            WhseLineQH_List = ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateMultiple(WhseLineQH[] WhseLineQH_List, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateMultiple", new object[] {
                        WhseLineQH_List}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateMultiple(System.IAsyncResult asyncResult, out WhseLineQH[] WhseLineQH_List) {
            object[] results = this.EndInvoke(asyncResult);
            WhseLineQH_List = ((WhseLineQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/whselineqh:Delete", RequestNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", ResponseElementName="Delete_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/whselineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Delete_Result")]
        public bool Delete(string Key) {
            object[] results = this.Invoke("Delete", new object[] {
                        Key});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDelete(string Key, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Delete", new object[] {
                        Key}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndDelete(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public partial class WhseLineQH {
        
        private string keyField;
        
        private Action_Type action_TypeField;
        
        private bool action_TypeFieldSpecified;
        
        private Activity_Type activity_TypeField;
        
        private bool activity_TypeFieldSpecified;
        
        private string noField;
        
        private int line_NoField;
        
        private bool line_NoFieldSpecified;
        
        private int source_TypeField;
        
        private bool source_TypeFieldSpecified;
        
        private Source_Subtype source_SubtypeField;
        
        private bool source_SubtypeFieldSpecified;
        
        private string source_NoField;
        
        private int source_Line_NoField;
        
        private bool source_Line_NoFieldSpecified;
        
        private int source_Subline_NoField;
        
        private bool source_Subline_NoFieldSpecified;
        
        private Source_Document source_DocumentField;
        
        private bool source_DocumentFieldSpecified;
        
        private string location_CodeField;
        
        private string zone_CodeField;
        
        private string bin_CodeField;
        
        private string shelf_NoField;
        
        private string item_NoField;
        
        private string variant_CodeField;
        
        private string unit_of_Measure_CodeField;
        
        private decimal qty_per_Unit_of_MeasureField;
        
        private bool qty_per_Unit_of_MeasureFieldSpecified;
        
        private string descriptionField;
        
        private string description_2Field;
        
        private decimal quantityField;
        
        private bool quantityFieldSpecified;
        
        private decimal qty_BaseField;
        
        private bool qty_BaseFieldSpecified;
        
        private decimal qty_OutstandingField;
        
        private bool qty_OutstandingFieldSpecified;
        
        private decimal qty_Outstanding_BaseField;
        
        private bool qty_Outstanding_BaseFieldSpecified;
        
        private decimal qty_to_HandleField;
        
        private bool qty_to_HandleFieldSpecified;
        
        private decimal qty_to_Handle_BaseField;
        
        private bool qty_to_Handle_BaseFieldSpecified;
        
        private decimal qty_HandledField;
        
        private bool qty_HandledFieldSpecified;
        
        private decimal qty_Handled_BaseField;
        
        private bool qty_Handled_BaseFieldSpecified;
        
        private string special_Equipment_CodeField;
        
        private Shipping_Advice shipping_AdviceField;
        
        private bool shipping_AdviceFieldSpecified;
        
        private System.DateTime due_DateField;
        
        private bool due_DateFieldSpecified;
        
        private Whse_Document_Type whse_Document_TypeField;
        
        private bool whse_Document_TypeFieldSpecified;
        
        private string whse_Document_NoField;
        
        private int whse_Document_Line_NoField;
        
        private bool whse_Document_Line_NoFieldSpecified;
        
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
        public Action_Type Action_Type {
            get {
                return this.action_TypeField;
            }
            set {
                this.action_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Action_TypeSpecified {
            get {
                return this.action_TypeFieldSpecified;
            }
            set {
                this.action_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Activity_Type Activity_Type {
            get {
                return this.activity_TypeField;
            }
            set {
                this.activity_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Activity_TypeSpecified {
            get {
                return this.activity_TypeFieldSpecified;
            }
            set {
                this.activity_TypeFieldSpecified = value;
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
        public int Line_No {
            get {
                return this.line_NoField;
            }
            set {
                this.line_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Line_NoSpecified {
            get {
                return this.line_NoFieldSpecified;
            }
            set {
                this.line_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Source_Type {
            get {
                return this.source_TypeField;
            }
            set {
                this.source_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Source_TypeSpecified {
            get {
                return this.source_TypeFieldSpecified;
            }
            set {
                this.source_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Source_Subtype Source_Subtype {
            get {
                return this.source_SubtypeField;
            }
            set {
                this.source_SubtypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Source_SubtypeSpecified {
            get {
                return this.source_SubtypeFieldSpecified;
            }
            set {
                this.source_SubtypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Source_No {
            get {
                return this.source_NoField;
            }
            set {
                this.source_NoField = value;
            }
        }
        
        /// <remarks/>
        public int Source_Line_No {
            get {
                return this.source_Line_NoField;
            }
            set {
                this.source_Line_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Source_Line_NoSpecified {
            get {
                return this.source_Line_NoFieldSpecified;
            }
            set {
                this.source_Line_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Source_Subline_No {
            get {
                return this.source_Subline_NoField;
            }
            set {
                this.source_Subline_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Source_Subline_NoSpecified {
            get {
                return this.source_Subline_NoFieldSpecified;
            }
            set {
                this.source_Subline_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Source_Document Source_Document {
            get {
                return this.source_DocumentField;
            }
            set {
                this.source_DocumentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Source_DocumentSpecified {
            get {
                return this.source_DocumentFieldSpecified;
            }
            set {
                this.source_DocumentFieldSpecified = value;
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
        public string Zone_Code {
            get {
                return this.zone_CodeField;
            }
            set {
                this.zone_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Bin_Code {
            get {
                return this.bin_CodeField;
            }
            set {
                this.bin_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Shelf_No {
            get {
                return this.shelf_NoField;
            }
            set {
                this.shelf_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Item_No {
            get {
                return this.item_NoField;
            }
            set {
                this.item_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Variant_Code {
            get {
                return this.variant_CodeField;
            }
            set {
                this.variant_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Unit_of_Measure_Code {
            get {
                return this.unit_of_Measure_CodeField;
            }
            set {
                this.unit_of_Measure_CodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_per_Unit_of_Measure {
            get {
                return this.qty_per_Unit_of_MeasureField;
            }
            set {
                this.qty_per_Unit_of_MeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_per_Unit_of_MeasureSpecified {
            get {
                return this.qty_per_Unit_of_MeasureFieldSpecified;
            }
            set {
                this.qty_per_Unit_of_MeasureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Description_2 {
            get {
                return this.description_2Field;
            }
            set {
                this.description_2Field = value;
            }
        }
        
        /// <remarks/>
        public decimal Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_Base {
            get {
                return this.qty_BaseField;
            }
            set {
                this.qty_BaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_BaseSpecified {
            get {
                return this.qty_BaseFieldSpecified;
            }
            set {
                this.qty_BaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_Outstanding {
            get {
                return this.qty_OutstandingField;
            }
            set {
                this.qty_OutstandingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_OutstandingSpecified {
            get {
                return this.qty_OutstandingFieldSpecified;
            }
            set {
                this.qty_OutstandingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_Outstanding_Base {
            get {
                return this.qty_Outstanding_BaseField;
            }
            set {
                this.qty_Outstanding_BaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_Outstanding_BaseSpecified {
            get {
                return this.qty_Outstanding_BaseFieldSpecified;
            }
            set {
                this.qty_Outstanding_BaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_to_Handle {
            get {
                return this.qty_to_HandleField;
            }
            set {
                this.qty_to_HandleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_to_HandleSpecified {
            get {
                return this.qty_to_HandleFieldSpecified;
            }
            set {
                this.qty_to_HandleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_to_Handle_Base {
            get {
                return this.qty_to_Handle_BaseField;
            }
            set {
                this.qty_to_Handle_BaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_to_Handle_BaseSpecified {
            get {
                return this.qty_to_Handle_BaseFieldSpecified;
            }
            set {
                this.qty_to_Handle_BaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_Handled {
            get {
                return this.qty_HandledField;
            }
            set {
                this.qty_HandledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_HandledSpecified {
            get {
                return this.qty_HandledFieldSpecified;
            }
            set {
                this.qty_HandledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Qty_Handled_Base {
            get {
                return this.qty_Handled_BaseField;
            }
            set {
                this.qty_Handled_BaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_Handled_BaseSpecified {
            get {
                return this.qty_Handled_BaseFieldSpecified;
            }
            set {
                this.qty_Handled_BaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Special_Equipment_Code {
            get {
                return this.special_Equipment_CodeField;
            }
            set {
                this.special_Equipment_CodeField = value;
            }
        }
        
        /// <remarks/>
        public Shipping_Advice Shipping_Advice {
            get {
                return this.shipping_AdviceField;
            }
            set {
                this.shipping_AdviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Shipping_AdviceSpecified {
            get {
                return this.shipping_AdviceFieldSpecified;
            }
            set {
                this.shipping_AdviceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Due_Date {
            get {
                return this.due_DateField;
            }
            set {
                this.due_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Due_DateSpecified {
            get {
                return this.due_DateFieldSpecified;
            }
            set {
                this.due_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Whse_Document_Type Whse_Document_Type {
            get {
                return this.whse_Document_TypeField;
            }
            set {
                this.whse_Document_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Whse_Document_TypeSpecified {
            get {
                return this.whse_Document_TypeFieldSpecified;
            }
            set {
                this.whse_Document_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Whse_Document_No {
            get {
                return this.whse_Document_NoField;
            }
            set {
                this.whse_Document_NoField = value;
            }
        }
        
        /// <remarks/>
        public int Whse_Document_Line_No {
            get {
                return this.whse_Document_Line_NoField;
            }
            set {
                this.whse_Document_Line_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Whse_Document_Line_NoSpecified {
            get {
                return this.whse_Document_Line_NoFieldSpecified;
            }
            set {
                this.whse_Document_Line_NoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Action_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Take,
        
        /// <remarks/>
        Place,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Activity_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Put_away,
        
        /// <remarks/>
        Pick,
        
        /// <remarks/>
        Movement,
        
        /// <remarks/>
        Invt_Put_away,
        
        /// <remarks/>
        Invt_Pick,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Source_Subtype {
        
        /// <remarks/>
        _x0030_,
        
        /// <remarks/>
        _x0031_,
        
        /// <remarks/>
        _x0032_,
        
        /// <remarks/>
        _x0033_,
        
        /// <remarks/>
        _x0034_,
        
        /// <remarks/>
        _x0035_,
        
        /// <remarks/>
        _x0036_,
        
        /// <remarks/>
        _x0037_,
        
        /// <remarks/>
        _x0038_,
        
        /// <remarks/>
        _x0039_,
        
        /// <remarks/>
        _x0031_0,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Source_Document {
        
        /// <remarks/>
        Sales_Order,
        
        /// <remarks/>
        Sales_Return_Order,
        
        /// <remarks/>
        Purchase_Order,
        
        /// <remarks/>
        Purchase_Return_Order,
        
        /// <remarks/>
        Inbound_Transfer,
        
        /// <remarks/>
        Outbound_Transfer,
        
        /// <remarks/>
        Prod_Consumption,
        
        /// <remarks/>
        Prod_Output,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Shipping_Advice {
        
        /// <remarks/>
        Partial,
        
        /// <remarks/>
        Complete,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum Whse_Document_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Receipt,
        
        /// <remarks/>
        Shipment,
        
        /// <remarks/>
        Internal_Put_away,
        
        /// <remarks/>
        Internal_Pick,
        
        /// <remarks/>
        Production,
        
        /// <remarks/>
        Movement_Worksheet,
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public partial class WhseLineQH_Filter {
        
        private WhseLineQH_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public WhseLineQH_Fields Field {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/whselineqh")]
    public enum WhseLineQH_Fields {
        
        /// <remarks/>
        Action_Type,
        
        /// <remarks/>
        Activity_Type,
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Line_No,
        
        /// <remarks/>
        Source_Type,
        
        /// <remarks/>
        Source_Subtype,
        
        /// <remarks/>
        Source_No,
        
        /// <remarks/>
        Source_Line_No,
        
        /// <remarks/>
        Source_Subline_No,
        
        /// <remarks/>
        Source_Document,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Zone_Code,
        
        /// <remarks/>
        Bin_Code,
        
        /// <remarks/>
        Shelf_No,
        
        /// <remarks/>
        Item_No,
        
        /// <remarks/>
        Variant_Code,
        
        /// <remarks/>
        Unit_of_Measure_Code,
        
        /// <remarks/>
        Qty_per_Unit_of_Measure,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Description_2,
        
        /// <remarks/>
        Quantity,
        
        /// <remarks/>
        Qty_Base,
        
        /// <remarks/>
        Qty_Outstanding,
        
        /// <remarks/>
        Qty_Outstanding_Base,
        
        /// <remarks/>
        Qty_to_Handle,
        
        /// <remarks/>
        Qty_to_Handle_Base,
        
        /// <remarks/>
        Qty_Handled,
        
        /// <remarks/>
        Qty_Handled_Base,
        
        /// <remarks/>
        Special_Equipment_Code,
        
        /// <remarks/>
        Shipping_Advice,
        
        /// <remarks/>
        Due_Date,
        
        /// <remarks/>
        Whse_Document_Type,
        
        /// <remarks/>
        Whse_Document_No,
        
        /// <remarks/>
        Whse_Document_Line_No,
    }
}
