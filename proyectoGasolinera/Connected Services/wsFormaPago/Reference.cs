﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoGasolinera.wsFormaPago {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsFormaPago.wsFormaPagoSoap")]
    public interface wsFormaPagoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listaFormasdePago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listaFormasdePago();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listaFormasdePago", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listaFormasdePagoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_FormadePago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_FormadePago(string tipoFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_FormadePago", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_FormadePagoAsync(string tipoFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_formapago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_formapago(int idFormaPago, string tipoFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_formapago", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_formapagoAsync(int idFormaPago, string tipoFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_formapago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_formapago(int idFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_formapago", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_formapagoAsync(int idFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar_formapago", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscar_formapago(int idFormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar_formapago", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscar_formapagoAsync(int idFormaPago);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsFormaPagoSoapChannel : proyectoGasolinera.wsFormaPago.wsFormaPagoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsFormaPagoSoapClient : System.ServiceModel.ClientBase<proyectoGasolinera.wsFormaPago.wsFormaPagoSoap>, proyectoGasolinera.wsFormaPago.wsFormaPagoSoap {
        
        public wsFormaPagoSoapClient() {
        }
        
        public wsFormaPagoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsFormaPagoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsFormaPagoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsFormaPagoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listaFormasdePago() {
            return base.Channel.listaFormasdePago();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listaFormasdePagoAsync() {
            return base.Channel.listaFormasdePagoAsync();
        }
        
        public int insertar_FormadePago(string tipoFormaPago) {
            return base.Channel.insertar_FormadePago(tipoFormaPago);
        }
        
        public System.Threading.Tasks.Task<int> insertar_FormadePagoAsync(string tipoFormaPago) {
            return base.Channel.insertar_FormadePagoAsync(tipoFormaPago);
        }
        
        public int actualizar_formapago(int idFormaPago, string tipoFormaPago) {
            return base.Channel.actualizar_formapago(idFormaPago, tipoFormaPago);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_formapagoAsync(int idFormaPago, string tipoFormaPago) {
            return base.Channel.actualizar_formapagoAsync(idFormaPago, tipoFormaPago);
        }
        
        public int eliminar_formapago(int idFormaPago) {
            return base.Channel.eliminar_formapago(idFormaPago);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_formapagoAsync(int idFormaPago) {
            return base.Channel.eliminar_formapagoAsync(idFormaPago);
        }
        
        public System.Data.DataSet buscar_formapago(int idFormaPago) {
            return base.Channel.buscar_formapago(idFormaPago);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscar_formapagoAsync(int idFormaPago) {
            return base.Channel.buscar_formapagoAsync(idFormaPago);
        }
    }
}