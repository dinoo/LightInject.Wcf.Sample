﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FooService.ConsoleClient.Bar {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Bar.IBarService")]
    public interface IBarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBarService/ServiceAction", ReplyAction="http://tempuri.org/IBarService/ServiceActionResponse")]
        string ServiceAction();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBarService/ServiceAction", ReplyAction="http://tempuri.org/IBarService/ServiceActionResponse")]
        System.Threading.Tasks.Task<string> ServiceActionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBarServiceChannel : FooService.ConsoleClient.Bar.IBarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BarServiceClient : System.ServiceModel.ClientBase<FooService.ConsoleClient.Bar.IBarService>, FooService.ConsoleClient.Bar.IBarService {
        
        public BarServiceClient() {
        }
        
        public BarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ServiceAction() {
            return base.Channel.ServiceAction();
        }
        
        public System.Threading.Tasks.Task<string> ServiceActionAsync() {
            return base.Channel.ServiceActionAsync();
        }
    }
}
