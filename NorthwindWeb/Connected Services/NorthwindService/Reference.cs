﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindWeb.NorthwindService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderBetweendateEntity", Namespace="http://schemas.datacontract.org/2004/07/NorthwindDAL.Entities")]
    [System.SerializableAttribute()]
    public partial class OrderBetweendateEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string productNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string productSalesField;
        
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
        public string categoryName {
            get {
                return this.categoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryNameField, value) != true)) {
                    this.categoryNameField = value;
                    this.RaisePropertyChanged("categoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                if ((object.ReferenceEquals(this.productNameField, value) != true)) {
                    this.productNameField = value;
                    this.RaisePropertyChanged("productName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string productSales {
            get {
                return this.productSalesField;
            }
            set {
                if ((object.ReferenceEquals(this.productSalesField, value) != true)) {
                    this.productSalesField = value;
                    this.RaisePropertyChanged("productSales");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserınfoEntity", Namespace="http://schemas.datacontract.org/2004/07/NorthwindDAL.Entities")]
    [System.SerializableAttribute()]
    public partial class UserınfoEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string companyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contactNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contactTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string customerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string faxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string postalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string regionField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.companyNameField, value) != true)) {
                    this.companyNameField = value;
                    this.RaisePropertyChanged("companyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contactName {
            get {
                return this.contactNameField;
            }
            set {
                if ((object.ReferenceEquals(this.contactNameField, value) != true)) {
                    this.contactNameField = value;
                    this.RaisePropertyChanged("contactName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contactTitle {
            get {
                return this.contactTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.contactTitleField, value) != true)) {
                    this.contactTitleField = value;
                    this.RaisePropertyChanged("contactTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customerId {
            get {
                return this.customerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.customerIdField, value) != true)) {
                    this.customerIdField = value;
                    this.RaisePropertyChanged("customerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fax {
            get {
                return this.faxField;
            }
            set {
                if ((object.ReferenceEquals(this.faxField, value) != true)) {
                    this.faxField = value;
                    this.RaisePropertyChanged("fax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.postalCodeField, value) != true)) {
                    this.postalCodeField = value;
                    this.RaisePropertyChanged("postalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string region {
            get {
                return this.regionField;
            }
            set {
                if ((object.ReferenceEquals(this.regionField, value) != true)) {
                    this.regionField = value;
                    this.RaisePropertyChanged("region");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddOrderEntity", Namespace="http://schemas.datacontract.org/2004/07/NorthwindDAL.Entities")]
    [System.SerializableAttribute()]
    public partial class AddOrderEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string customerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int employeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int freightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime orderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime requiredDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipCountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipPostalcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipRegionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int shipViaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime shippedDateField;
        
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
        public string customerId {
            get {
                return this.customerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.customerIdField, value) != true)) {
                    this.customerIdField = value;
                    this.RaisePropertyChanged("customerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int employeeId {
            get {
                return this.employeeIdField;
            }
            set {
                if ((this.employeeIdField.Equals(value) != true)) {
                    this.employeeIdField = value;
                    this.RaisePropertyChanged("employeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int freight {
            get {
                return this.freightField;
            }
            set {
                if ((this.freightField.Equals(value) != true)) {
                    this.freightField = value;
                    this.RaisePropertyChanged("freight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime orderDate {
            get {
                return this.orderDateField;
            }
            set {
                if ((this.orderDateField.Equals(value) != true)) {
                    this.orderDateField = value;
                    this.RaisePropertyChanged("orderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime requiredDate {
            get {
                return this.requiredDateField;
            }
            set {
                if ((this.requiredDateField.Equals(value) != true)) {
                    this.requiredDateField = value;
                    this.RaisePropertyChanged("requiredDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.shipAddressField, value) != true)) {
                    this.shipAddressField = value;
                    this.RaisePropertyChanged("shipAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipCity {
            get {
                return this.shipCityField;
            }
            set {
                if ((object.ReferenceEquals(this.shipCityField, value) != true)) {
                    this.shipCityField = value;
                    this.RaisePropertyChanged("shipCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipCountry {
            get {
                return this.shipCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.shipCountryField, value) != true)) {
                    this.shipCountryField = value;
                    this.RaisePropertyChanged("shipCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipName {
            get {
                return this.shipNameField;
            }
            set {
                if ((object.ReferenceEquals(this.shipNameField, value) != true)) {
                    this.shipNameField = value;
                    this.RaisePropertyChanged("shipName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipPostalcode {
            get {
                return this.shipPostalcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.shipPostalcodeField, value) != true)) {
                    this.shipPostalcodeField = value;
                    this.RaisePropertyChanged("shipPostalcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipRegion {
            get {
                return this.shipRegionField;
            }
            set {
                if ((object.ReferenceEquals(this.shipRegionField, value) != true)) {
                    this.shipRegionField = value;
                    this.RaisePropertyChanged("shipRegion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int shipVia {
            get {
                return this.shipViaField;
            }
            set {
                if ((this.shipViaField.Equals(value) != true)) {
                    this.shipViaField = value;
                    this.RaisePropertyChanged("shipVia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime shippedDate {
            get {
                return this.shippedDateField;
            }
            set {
                if ((this.shippedDateField.Equals(value) != true)) {
                    this.shippedDateField = value;
                    this.RaisePropertyChanged("shippedDate");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddOrderDetailEntity", Namespace="http://schemas.datacontract.org/2004/07/NorthwindDAL.Entities")]
    [System.SerializableAttribute()]
    public partial class AddOrderDetailEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int discountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int orderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int productIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int unitPriceField;
        
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
        public int discount {
            get {
                return this.discountField;
            }
            set {
                if ((this.discountField.Equals(value) != true)) {
                    this.discountField = value;
                    this.RaisePropertyChanged("discount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int orderId {
            get {
                return this.orderIdField;
            }
            set {
                if ((this.orderIdField.Equals(value) != true)) {
                    this.orderIdField = value;
                    this.RaisePropertyChanged("orderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int productId {
            get {
                return this.productIdField;
            }
            set {
                if ((this.productIdField.Equals(value) != true)) {
                    this.productIdField = value;
                    this.RaisePropertyChanged("productId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int unitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                if ((this.unitPriceField.Equals(value) != true)) {
                    this.unitPriceField = value;
                    this.RaisePropertyChanged("unitPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NorthwindService.INorthwindService")]
    public interface INorthwindService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/getOrderInfo", ReplyAction="http://tempuri.org/INorthwindService/getOrderInfoResponse")]
        NorthwindWeb.NorthwindService.OrderBetweendateEntity[] getOrderInfo(string d1, string d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/getOrderInfo", ReplyAction="http://tempuri.org/INorthwindService/getOrderInfoResponse")]
        System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.OrderBetweendateEntity[]> getOrderInfoAsync(string d1, string d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/getLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/getLoginInfoResponse")]
        NorthwindWeb.NorthwindService.UserınfoEntity[] getLoginInfo(string p_username, string p_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/getLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/getLoginInfoResponse")]
        System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity[]> getLoginInfoAsync(string p_username, string p_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/ss", ReplyAction="http://tempuri.org/INorthwindService/ssResponse")]
        int ss(string k, string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/ss", ReplyAction="http://tempuri.org/INorthwindService/ssResponse")]
        System.Threading.Tasks.Task<int> ssAsync(string k, string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/insertUserLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/insertUserLoginInfoResponse")]
        string insertUserLoginInfo(string uid, string uname, string upw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/insertUserLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/insertUserLoginInfoResponse")]
        System.Threading.Tasks.Task<string> insertUserLoginInfoAsync(string uid, string uname, string upw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/addOrder", ReplyAction="http://tempuri.org/INorthwindService/addOrderResponse")]
        string addOrder(NorthwindWeb.NorthwindService.AddOrderEntity data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/addOrder", ReplyAction="http://tempuri.org/INorthwindService/addOrderResponse")]
        System.Threading.Tasks.Task<string> addOrderAsync(NorthwindWeb.NorthwindService.AddOrderEntity data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/addOrderDetail", ReplyAction="http://tempuri.org/INorthwindService/addOrderDetailResponse")]
        string addOrderDetail(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/addOrderDetail", ReplyAction="http://tempuri.org/INorthwindService/addOrderDetailResponse")]
        System.Threading.Tasks.Task<string> addOrderDetailAsync(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/asd", ReplyAction="http://tempuri.org/INorthwindService/asdResponse")]
        string asd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/asd", ReplyAction="http://tempuri.org/INorthwindService/asdResponse")]
        System.Threading.Tasks.Task<string> asdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/ue", ReplyAction="http://tempuri.org/INorthwindService/ueResponse")]
        NorthwindWeb.NorthwindService.UserınfoEntity ue(NorthwindWeb.NorthwindService.UserınfoEntity entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/ue", ReplyAction="http://tempuri.org/INorthwindService/ueResponse")]
        System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity> ueAsync(NorthwindWeb.NorthwindService.UserınfoEntity entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsongetOrderInfo", ReplyAction="http://tempuri.org/INorthwindService/JsongetOrderInfoResponse")]
        NorthwindWeb.NorthwindService.OrderBetweendateEntity[] JsongetOrderInfo(string d1, string d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsongetOrderInfo", ReplyAction="http://tempuri.org/INorthwindService/JsongetOrderInfoResponse")]
        System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.OrderBetweendateEntity[]> JsongetOrderInfoAsync(string d1, string d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsongetLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/JsongetLoginInfoResponse")]
        NorthwindWeb.NorthwindService.UserınfoEntity[] JsongetLoginInfo(string p_username, string p_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsongetLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/JsongetLoginInfoResponse")]
        System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity[]> JsongetLoginInfoAsync(string p_username, string p_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsoninsertUserLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/JsoninsertUserLoginInfoResponse")]
        string JsoninsertUserLoginInfo(string uid, string uname, string upw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsoninsertUserLoginInfo", ReplyAction="http://tempuri.org/INorthwindService/JsoninsertUserLoginInfoResponse")]
        System.Threading.Tasks.Task<string> JsoninsertUserLoginInfoAsync(string uid, string uname, string upw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsonaddOrder", ReplyAction="http://tempuri.org/INorthwindService/JsonaddOrderResponse")]
        string JsonaddOrder(NorthwindWeb.NorthwindService.AddOrderEntity data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsonaddOrder", ReplyAction="http://tempuri.org/INorthwindService/JsonaddOrderResponse")]
        System.Threading.Tasks.Task<string> JsonaddOrderAsync(NorthwindWeb.NorthwindService.AddOrderEntity data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsonaddOrderDetail", ReplyAction="http://tempuri.org/INorthwindService/JsonaddOrderDetailResponse")]
        string JsonaddOrderDetail(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/JsonaddOrderDetail", ReplyAction="http://tempuri.org/INorthwindService/JsonaddOrderDetailResponse")]
        System.Threading.Tasks.Task<string> JsonaddOrderDetailAsync(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/Jsonasd", ReplyAction="http://tempuri.org/INorthwindService/JsonasdResponse")]
        string Jsonasd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindService/Jsonasd", ReplyAction="http://tempuri.org/INorthwindService/JsonasdResponse")]
        System.Threading.Tasks.Task<string> JsonasdAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INorthwindServiceChannel : NorthwindWeb.NorthwindService.INorthwindService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NorthwindServiceClient : System.ServiceModel.ClientBase<NorthwindWeb.NorthwindService.INorthwindService>, NorthwindWeb.NorthwindService.INorthwindService {
        
        public NorthwindServiceClient() {
        }
        
        public NorthwindServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NorthwindServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NorthwindServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NorthwindServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NorthwindWeb.NorthwindService.OrderBetweendateEntity[] getOrderInfo(string d1, string d2) {
            return base.Channel.getOrderInfo(d1, d2);
        }
        
        public System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.OrderBetweendateEntity[]> getOrderInfoAsync(string d1, string d2) {
            return base.Channel.getOrderInfoAsync(d1, d2);
        }
        
        public NorthwindWeb.NorthwindService.UserınfoEntity[] getLoginInfo(string p_username, string p_password) {
            return base.Channel.getLoginInfo(p_username, p_password);
        }
        
        public System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity[]> getLoginInfoAsync(string p_username, string p_password) {
            return base.Channel.getLoginInfoAsync(p_username, p_password);
        }
        
        public int ss(string k, string s) {
            return base.Channel.ss(k, s);
        }
        
        public System.Threading.Tasks.Task<int> ssAsync(string k, string s) {
            return base.Channel.ssAsync(k, s);
        }
        
        public string insertUserLoginInfo(string uid, string uname, string upw) {
            return base.Channel.insertUserLoginInfo(uid, uname, upw);
        }
        
        public System.Threading.Tasks.Task<string> insertUserLoginInfoAsync(string uid, string uname, string upw) {
            return base.Channel.insertUserLoginInfoAsync(uid, uname, upw);
        }
        
        public string addOrder(NorthwindWeb.NorthwindService.AddOrderEntity data) {
            return base.Channel.addOrder(data);
        }
        
        public System.Threading.Tasks.Task<string> addOrderAsync(NorthwindWeb.NorthwindService.AddOrderEntity data) {
            return base.Channel.addOrderAsync(data);
        }
        
        public string addOrderDetail(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data) {
            return base.Channel.addOrderDetail(detail_data);
        }
        
        public System.Threading.Tasks.Task<string> addOrderDetailAsync(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data) {
            return base.Channel.addOrderDetailAsync(detail_data);
        }
        
        public string asd() {
            return base.Channel.asd();
        }
        
        public System.Threading.Tasks.Task<string> asdAsync() {
            return base.Channel.asdAsync();
        }
        
        public NorthwindWeb.NorthwindService.UserınfoEntity ue(NorthwindWeb.NorthwindService.UserınfoEntity entity) {
            return base.Channel.ue(entity);
        }
        
        public System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity> ueAsync(NorthwindWeb.NorthwindService.UserınfoEntity entity) {
            return base.Channel.ueAsync(entity);
        }
        
        public NorthwindWeb.NorthwindService.OrderBetweendateEntity[] JsongetOrderInfo(string d1, string d2) {
            return base.Channel.JsongetOrderInfo(d1, d2);
        }
        
        public System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.OrderBetweendateEntity[]> JsongetOrderInfoAsync(string d1, string d2) {
            return base.Channel.JsongetOrderInfoAsync(d1, d2);
        }
        
        public NorthwindWeb.NorthwindService.UserınfoEntity[] JsongetLoginInfo(string p_username, string p_password) {
            return base.Channel.JsongetLoginInfo(p_username, p_password);
        }
        
        public System.Threading.Tasks.Task<NorthwindWeb.NorthwindService.UserınfoEntity[]> JsongetLoginInfoAsync(string p_username, string p_password) {
            return base.Channel.JsongetLoginInfoAsync(p_username, p_password);
        }
        
        public string JsoninsertUserLoginInfo(string uid, string uname, string upw) {
            return base.Channel.JsoninsertUserLoginInfo(uid, uname, upw);
        }
        
        public System.Threading.Tasks.Task<string> JsoninsertUserLoginInfoAsync(string uid, string uname, string upw) {
            return base.Channel.JsoninsertUserLoginInfoAsync(uid, uname, upw);
        }
        
        public string JsonaddOrder(NorthwindWeb.NorthwindService.AddOrderEntity data) {
            return base.Channel.JsonaddOrder(data);
        }
        
        public System.Threading.Tasks.Task<string> JsonaddOrderAsync(NorthwindWeb.NorthwindService.AddOrderEntity data) {
            return base.Channel.JsonaddOrderAsync(data);
        }
        
        public string JsonaddOrderDetail(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data) {
            return base.Channel.JsonaddOrderDetail(detail_data);
        }
        
        public System.Threading.Tasks.Task<string> JsonaddOrderDetailAsync(NorthwindWeb.NorthwindService.AddOrderDetailEntity detail_data) {
            return base.Channel.JsonaddOrderDetailAsync(detail_data);
        }
        
        public string Jsonasd() {
            return base.Channel.Jsonasd();
        }
        
        public System.Threading.Tasks.Task<string> JsonasdAsync() {
            return base.Channel.JsonasdAsync();
        }
    }
}
