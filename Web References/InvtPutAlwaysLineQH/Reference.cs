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
namespace RGSMobile.InvtPutAlwaysLineQH {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InvtPutAlwaysLineQH_Binding", Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public partial class InvtPutAlwaysLineQH_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public InvtPutAlwaysLineQH_Service() {
            this.Url = "http://dpmaster.dptech.local:7045/DynamicsNAVQH/WS/Qian%20Hu/Page/InvtPutAlwaysLi" +
                "neQH";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("InvtPutAlwaysLineQH")]
        public InvtPutAlwaysLineQH ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((InvtPutAlwaysLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadByRecId(string recId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadByRecId", new object[] {
                        recId}, callback, asyncState);
        }
        
        /// <remarks/>
        public InvtPutAlwaysLineQH EndReadByRecId(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((InvtPutAlwaysLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public InvtPutAlwaysLineQH[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] InvtPutAlwaysLineQH_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((InvtPutAlwaysLineQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReadMultiple(InvtPutAlwaysLineQH_Filter[] filter, string bookmarkKey, int setSize, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize}, callback, asyncState);
        }
        
        /// <remarks/>
        public InvtPutAlwaysLineQH[] EndReadMultiple(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((InvtPutAlwaysLineQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:Update", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="Update_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Update(ref InvtPutAlwaysLineQH InvtPutAlwaysLineQH) {
            object[] results = this.Invoke("Update", new object[] {
                        InvtPutAlwaysLineQH});
            InvtPutAlwaysLineQH = ((InvtPutAlwaysLineQH)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdate(InvtPutAlwaysLineQH InvtPutAlwaysLineQH, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Update", new object[] {
                        InvtPutAlwaysLineQH}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdate(System.IAsyncResult asyncResult, out InvtPutAlwaysLineQH InvtPutAlwaysLineQH) {
            object[] results = this.EndInvoke(asyncResult);
            InvtPutAlwaysLineQH = ((InvtPutAlwaysLineQH)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:UpdateMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="UpdateMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateMultiple([System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] ref InvtPutAlwaysLineQH[] InvtPutAlwaysLineQH_List) {
            object[] results = this.Invoke("UpdateMultiple", new object[] {
                        InvtPutAlwaysLineQH_List});
            InvtPutAlwaysLineQH_List = ((InvtPutAlwaysLineQH[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateMultiple(InvtPutAlwaysLineQH[] InvtPutAlwaysLineQH_List, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateMultiple", new object[] {
                        InvtPutAlwaysLineQH_List}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateMultiple(System.IAsyncResult asyncResult, out InvtPutAlwaysLineQH[] InvtPutAlwaysLineQH_List) {
            object[] results = this.EndInvoke(asyncResult);
            InvtPutAlwaysLineQH_List = ((InvtPutAlwaysLineQH[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/invtputalwayslineqh:Delete", RequestNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", ResponseElementName="Delete_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public partial class InvtPutAlwaysLineQH {
        
        private string keyField;
        
        private Action_Type action_TypeField;
        
        private bool action_TypeFieldSpecified;
        
        private Source_Document source_DocumentField;
        
        private bool source_DocumentFieldSpecified;
        
        private string source_NoField;
        
        private string item_NoField;
        
        private string variant_CodeField;
        
        private string descriptionField;
        
        private string serial_NoField;
        
        private string lot_NoField;
        
        private System.DateTime expiration_DateField;
        
        private bool expiration_DateFieldSpecified;
        
        private string location_CodeField;
        
        private string zone_CodeField;
        
        private string bin_CodeField;
        
        private string shelf_NoField;
        
        private decimal quantityField;
        
        private bool quantityFieldSpecified;
        
        private decimal qty_BaseField;
        
        private bool qty_BaseFieldSpecified;
        
        private decimal qty_to_HandleField;
        
        private bool qty_to_HandleFieldSpecified;
        
        private decimal qty_HandledField;
        
        private bool qty_HandledFieldSpecified;
        
        private decimal qty_to_Handle_BaseField;
        
        private bool qty_to_Handle_BaseFieldSpecified;
        
        private decimal qty_Handled_BaseField;
        
        private bool qty_Handled_BaseFieldSpecified;
        
        private decimal qty_OutstandingField;
        
        private bool qty_OutstandingFieldSpecified;
        
        private decimal qty_Outstanding_BaseField;
        
        private bool qty_Outstanding_BaseFieldSpecified;
        
        private System.DateTime due_DateField;
        
        private bool due_DateFieldSpecified;
        
        private string unit_of_Measure_CodeField;
        
        private decimal qty_per_Unit_of_MeasureField;
        
        private bool qty_per_Unit_of_MeasureFieldSpecified;
        
        private Destination_Type destination_TypeField;
        
        private bool destination_TypeFieldSpecified;
        
        private string destination_NoField;
        
        private Whse_Document_Type whse_Document_TypeField;
        
        private bool whse_Document_TypeFieldSpecified;
        
        private string whse_Document_NoField;
        
        private int whse_Document_Line_NoField;
        
        private bool whse_Document_Line_NoFieldSpecified;
        
        private string special_Equipment_CodeField;
        
        private Cross_Dock_Information cross_Dock_InformationField;
        
        private bool cross_Dock_InformationFieldSpecified;
        
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
        public string Source_No {
            get {
                return this.source_NoField;
            }
            set {
                this.source_NoField = value;
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Serial_No {
            get {
                return this.serial_NoField;
            }
            set {
                this.serial_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Lot_No {
            get {
                return this.lot_NoField;
            }
            set {
                this.lot_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Expiration_Date {
            get {
                return this.expiration_DateField;
            }
            set {
                this.expiration_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Expiration_DateSpecified {
            get {
                return this.expiration_DateFieldSpecified;
            }
            set {
                this.expiration_DateFieldSpecified = value;
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
        public Destination_Type Destination_Type {
            get {
                return this.destination_TypeField;
            }
            set {
                this.destination_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Destination_TypeSpecified {
            get {
                return this.destination_TypeFieldSpecified;
            }
            set {
                this.destination_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Destination_No {
            get {
                return this.destination_NoField;
            }
            set {
                this.destination_NoField = value;
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
        public Cross_Dock_Information Cross_Dock_Information {
            get {
                return this.cross_Dock_InformationField;
            }
            set {
                this.cross_Dock_InformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Cross_Dock_InformationSpecified {
            get {
                return this.cross_Dock_InformationFieldSpecified;
            }
            set {
                this.cross_Dock_InformationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public enum Action_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Take,
        
        /// <remarks/>
        Place,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public enum Destination_Type {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Customer,
        
        /// <remarks/>
        Vendor,
        
        /// <remarks/>
        Location,
        
        /// <remarks/>
        Item,
        
        /// <remarks/>
        Family,
        
        /// <remarks/>
        Sales_Order,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public enum Cross_Dock_Information {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Cross_Dock_Items,
        
        /// <remarks/>
        Some_Items_Cross_Docked,
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public partial class InvtPutAlwaysLineQH_Filter {
        
        private InvtPutAlwaysLineQH_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public InvtPutAlwaysLineQH_Fields Field {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/invtputalwayslineqh")]
    public enum InvtPutAlwaysLineQH_Fields {
        
        /// <remarks/>
        Action_Type,
        
        /// <remarks/>
        Source_Document,
        
        /// <remarks/>
        Source_No,
        
        /// <remarks/>
        Item_No,
        
        /// <remarks/>
        Variant_Code,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Serial_No,
        
        /// <remarks/>
        Lot_No,
        
        /// <remarks/>
        Expiration_Date,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Zone_Code,
        
        /// <remarks/>
        Bin_Code,
        
        /// <remarks/>
        Shelf_No,
        
        /// <remarks/>
        Quantity,
        
        /// <remarks/>
        Qty_Base,
        
        /// <remarks/>
        Qty_to_Handle,
        
        /// <remarks/>
        Qty_Handled,
        
        /// <remarks/>
        Qty_to_Handle_Base,
        
        /// <remarks/>
        Qty_Handled_Base,
        
        /// <remarks/>
        Qty_Outstanding,
        
        /// <remarks/>
        Qty_Outstanding_Base,
        
        /// <remarks/>
        Due_Date,
        
        /// <remarks/>
        Unit_of_Measure_Code,
        
        /// <remarks/>
        Qty_per_Unit_of_Measure,
        
        /// <remarks/>
        Destination_Type,
        
        /// <remarks/>
        Destination_No,
        
        /// <remarks/>
        Whse_Document_Type,
        
        /// <remarks/>
        Whse_Document_No,
        
        /// <remarks/>
        Whse_Document_Line_No,
        
        /// <remarks/>
        Special_Equipment_Code,
        
        /// <remarks/>
        Cross_Dock_Information,
    }
}
