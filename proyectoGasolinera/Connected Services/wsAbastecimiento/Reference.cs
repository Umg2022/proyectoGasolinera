﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoGasolinera.wsAbastecimiento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsAbastecimiento.wsAbastecimientoSoap")]
    public interface wsAbastecimientoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_abastecimiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_abastecimiento();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_abastecimiento", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_abastecimientoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_abastecimiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_abastecimiento(int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_abastecimiento", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_abastecimientoAsync(int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_abastecimiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_abastecimiento(int idAbastecimiento, int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_abastecimiento", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_abastecimientoAsync(int idAbastecimiento, int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_abastecimiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_abastecimiento(int idAbastecimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_abastecimiento", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_abastecimientoAsync(int idAbastecimiento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsAbastecimientoSoapChannel : proyectoGasolinera.wsAbastecimiento.wsAbastecimientoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsAbastecimientoSoapClient : System.ServiceModel.ClientBase<proyectoGasolinera.wsAbastecimiento.wsAbastecimientoSoap>, proyectoGasolinera.wsAbastecimiento.wsAbastecimientoSoap {
        
        public wsAbastecimientoSoapClient() {
        }
        
        public wsAbastecimientoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsAbastecimientoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsAbastecimientoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsAbastecimientoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_abastecimiento() {
            return base.Channel.listado_abastecimiento();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_abastecimientoAsync() {
            return base.Channel.listado_abastecimientoAsync();
        }
        
        public int insertar_abastecimiento(int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra) {
            return base.Channel.insertar_abastecimiento(idProveedor, idEmpleado, idTipoCombustible, cantidadComprada, precioCombustibleCompra);
        }
        
        public System.Threading.Tasks.Task<int> insertar_abastecimientoAsync(int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra) {
            return base.Channel.insertar_abastecimientoAsync(idProveedor, idEmpleado, idTipoCombustible, cantidadComprada, precioCombustibleCompra);
        }
        
        public int actualizar_abastecimiento(int idAbastecimiento, int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra) {
            return base.Channel.actualizar_abastecimiento(idAbastecimiento, idProveedor, idEmpleado, idTipoCombustible, cantidadComprada, precioCombustibleCompra);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_abastecimientoAsync(int idAbastecimiento, int idProveedor, int idEmpleado, int idTipoCombustible, int cantidadComprada, double precioCombustibleCompra) {
            return base.Channel.actualizar_abastecimientoAsync(idAbastecimiento, idProveedor, idEmpleado, idTipoCombustible, cantidadComprada, precioCombustibleCompra);
        }
        
        public int eliminar_abastecimiento(int idAbastecimiento) {
            return base.Channel.eliminar_abastecimiento(idAbastecimiento);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_abastecimientoAsync(int idAbastecimiento) {
            return base.Channel.eliminar_abastecimientoAsync(idAbastecimiento);
        }
    }
}
