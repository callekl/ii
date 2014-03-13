﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIProjectClient.InternalService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InternalService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFilenames", ReplyAction="http://tempuri.org/IService1/GetFilenamesResponse")]
        string[] GetFilenames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllLocations", ReplyAction="http://tempuri.org/IService1/GetAllLocationsResponse")]
        System.Xml.Linq.XElement[] GetAllLocations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEvent", ReplyAction="http://tempuri.org/IService1/GetEventResponse")]
        System.Xml.Linq.XElement GetEvent(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEvents", ReplyAction="http://tempuri.org/IService1/GetEventsResponse")]
        System.Xml.Linq.XElement[] GetEvents(System.DateTime fromInclusive, System.DateTime toInclusive, string readPointEPC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVehicle", ReplyAction="http://tempuri.org/IService1/GetVehicleResponse")]
        System.Xml.Linq.XElement GetVehicle(string epc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLocation", ReplyAction="http://tempuri.org/IService1/GetLocationResponse")]
        System.Xml.Linq.XElement GetLocation(string epc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : IIProjectClient.InternalService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<IIProjectClient.InternalService.IService1>, IIProjectClient.InternalService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetFilenames() {
            return base.Channel.GetFilenames();
        }
        
        public System.Xml.Linq.XElement[] GetAllLocations() {
            return base.Channel.GetAllLocations();
        }
        
        public System.Xml.Linq.XElement GetEvent(string filename) {
            return base.Channel.GetEvent(filename);
        }
        
        public System.Xml.Linq.XElement[] GetEvents(System.DateTime fromInclusive, System.DateTime toInclusive, string readPointEPC) {
            return base.Channel.GetEvents(fromInclusive, toInclusive, readPointEPC);
        }
        
        public System.Xml.Linq.XElement GetVehicle(string epc) {
            return base.Channel.GetVehicle(epc);
        }
        
        public System.Xml.Linq.XElement GetLocation(string epc) {
            return base.Channel.GetLocation(epc);
        }
    }
}