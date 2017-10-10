﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.Proxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxy.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Upload", ReplyAction="http://tempuri.org/IService/UploadResponse")]
        string Upload(System.IO.Stream input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Upload", ReplyAction="http://tempuri.org/IService/UploadResponse")]
        System.Threading.Tasks.Task<string> UploadAsync(System.IO.Stream input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Download", ReplyAction="http://tempuri.org/IService/DownloadResponse")]
        System.IO.Stream Download(string file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Download", ReplyAction="http://tempuri.org/IService/DownloadResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownloadAsync(string file);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WebClient.Proxy.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WebClient.Proxy.IService>, WebClient.Proxy.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Upload(System.IO.Stream input) {
            return base.Channel.Upload(input);
        }
        
        public System.Threading.Tasks.Task<string> UploadAsync(System.IO.Stream input) {
            return base.Channel.UploadAsync(input);
        }
        
        public System.IO.Stream Download(string file) {
            return base.Channel.Download(file);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownloadAsync(string file) {
            return base.Channel.DownloadAsync(file);
        }
    }
}
