//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cv12web.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Compute", ReplyAction="http://tempuri.org/IService1/ComputeResponse")]
        decimal Compute(decimal firstNumber, decimal secondNumber, string operation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Compute", ReplyAction="http://tempuri.org/IService1/ComputeResponse")]
        System.Threading.Tasks.Task<decimal> ComputeAsync(decimal firstNumber, decimal secondNumber, string operation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : cv12web.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<cv12web.ServiceReference2.IService1>, cv12web.ServiceReference2.IService1 {
        
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
        
        public decimal Compute(decimal firstNumber, decimal secondNumber, string operation) {
            return base.Channel.Compute(firstNumber, secondNumber, operation);
        }
        
        public System.Threading.Tasks.Task<decimal> ComputeAsync(decimal firstNumber, decimal secondNumber, string operation) {
            return base.Channel.ComputeAsync(firstNumber, secondNumber, operation);
        }
    }
}
