﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace restaurantClient.CustomerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/CustomerService")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CustPhoneNumberField;
        
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
        public int CustId {
            get {
                return this.CustIdField;
            }
            set {
                if ((this.CustIdField.Equals(value) != true)) {
                    this.CustIdField = value;
                    this.RaisePropertyChanged("CustId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustName {
            get {
                return this.CustNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustNameField, value) != true)) {
                    this.CustNameField = value;
                    this.RaisePropertyChanged("CustName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CustPhoneNumber {
            get {
                return this.CustPhoneNumberField;
            }
            set {
                if ((this.CustPhoneNumberField.Equals(value) != true)) {
                    this.CustPhoneNumberField = value;
                    this.RaisePropertyChanged("CustPhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceReference.customerInterface")]
    public interface customerInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/GetCustomers", ReplyAction="http://tempuri.org/customerInterface/GetCustomersResponse")]
        System.Data.DataSet GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/GetCustomers", ReplyAction="http://tempuri.org/customerInterface/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/AddCustomer", ReplyAction="http://tempuri.org/customerInterface/AddCustomerResponse")]
        void AddCustomer(string cust_name, long cust_ph_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/AddCustomer", ReplyAction="http://tempuri.org/customerInterface/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(string cust_name, long cust_ph_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/GetCustByPhn", ReplyAction="http://tempuri.org/customerInterface/GetCustByPhnResponse")]
        restaurantClient.CustomerServiceReference.Customer GetCustByPhn(long cust_ph_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/customerInterface/GetCustByPhn", ReplyAction="http://tempuri.org/customerInterface/GetCustByPhnResponse")]
        System.Threading.Tasks.Task<restaurantClient.CustomerServiceReference.Customer> GetCustByPhnAsync(long cust_ph_num);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface customerInterfaceChannel : restaurantClient.CustomerServiceReference.customerInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class customerInterfaceClient : System.ServiceModel.ClientBase<restaurantClient.CustomerServiceReference.customerInterface>, restaurantClient.CustomerServiceReference.customerInterface {
        
        public customerInterfaceClient() {
        }
        
        public customerInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public customerInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public customerInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public customerInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void AddCustomer(string cust_name, long cust_ph_num) {
            base.Channel.AddCustomer(cust_name, cust_ph_num);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(string cust_name, long cust_ph_num) {
            return base.Channel.AddCustomerAsync(cust_name, cust_ph_num);
        }
        
        public restaurantClient.CustomerServiceReference.Customer GetCustByPhn(long cust_ph_num) {
            return base.Channel.GetCustByPhn(cust_ph_num);
        }
        
        public System.Threading.Tasks.Task<restaurantClient.CustomerServiceReference.Customer> GetCustByPhnAsync(long cust_ph_num) {
            return base.Channel.GetCustByPhnAsync(cust_ph_num);
        }
    }
}