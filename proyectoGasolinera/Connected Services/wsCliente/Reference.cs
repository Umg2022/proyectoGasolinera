//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoGasolinera.wsCliente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsCliente.wsClienteSoap")]
    public interface wsClienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_cliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_clienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_cliente(string nombreCliente, string direccionCLiente, string nitCliente, string emailCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_clienteAsync(string nombreCliente, string direccionCLiente, string nitCliente, string emailCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_cliente(int idCliente, string nombreCliente, string direccionCliente, string nitCliente, string emailCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_clienteAsync(int idCliente, string nombreCliente, string direccionCliente, string nitCliente, string emailCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_cliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_clienteAsync(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscar_cliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscar_clienteAsync(int idCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsClienteSoapChannel : proyectoGasolinera.wsCliente.wsClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsClienteSoapClient : System.ServiceModel.ClientBase<proyectoGasolinera.wsCliente.wsClienteSoap>, proyectoGasolinera.wsCliente.wsClienteSoap {
        
        public wsClienteSoapClient() {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_cliente() {
            return base.Channel.listado_cliente();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_clienteAsync() {
            return base.Channel.listado_clienteAsync();
        }
        
        public int insertar_cliente(string nombreCliente, string direccionCLiente, string nitCliente, string emailCliente) {
            return base.Channel.insertar_cliente(nombreCliente, direccionCLiente, nitCliente, emailCliente);
        }
        
        public System.Threading.Tasks.Task<int> insertar_clienteAsync(string nombreCliente, string direccionCLiente, string nitCliente, string emailCliente) {
            return base.Channel.insertar_clienteAsync(nombreCliente, direccionCLiente, nitCliente, emailCliente);
        }
        
        public int actualizar_cliente(int idCliente, string nombreCliente, string direccionCliente, string nitCliente, string emailCliente) {
            return base.Channel.actualizar_cliente(idCliente, nombreCliente, direccionCliente, nitCliente, emailCliente);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_clienteAsync(int idCliente, string nombreCliente, string direccionCliente, string nitCliente, string emailCliente) {
            return base.Channel.actualizar_clienteAsync(idCliente, nombreCliente, direccionCliente, nitCliente, emailCliente);
        }
        
        public int eliminar_cliente(int idCliente) {
            return base.Channel.eliminar_cliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_clienteAsync(int idCliente) {
            return base.Channel.eliminar_clienteAsync(idCliente);
        }
        
        public System.Data.DataSet buscar_cliente(int idCliente) {
            return base.Channel.buscar_cliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscar_clienteAsync(int idCliente) {
            return base.Channel.buscar_clienteAsync(idCliente);
        }
    }
}
