﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoGasolinera.wsPuesto {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsPuesto.wsPuestoSoap")]
    public interface wsPuestoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listado_Puestos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listado_Puestos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listado_Puestos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Listado_PuestosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar_Puesto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar_Puesto(int idPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar_Puesto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Buscar_PuestoAsync(int idPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar_Puesto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Insertar_Puesto(string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar_Puesto", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Insertar_PuestoAsync(string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_puesto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_puesto(int idPuesto, string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_puesto", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_puestoAsync(int idPuesto, string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_sucursal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_sucursal(int idPuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_sucursal", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_sucursalAsync(int idPuesto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsPuestoSoapChannel : proyectoGasolinera.wsPuesto.wsPuestoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsPuestoSoapClient : System.ServiceModel.ClientBase<proyectoGasolinera.wsPuesto.wsPuestoSoap>, proyectoGasolinera.wsPuesto.wsPuestoSoap {
        
        public wsPuestoSoapClient() {
        }
        
        public wsPuestoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsPuestoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPuestoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsPuestoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listado_Puestos() {
            return base.Channel.Listado_Puestos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Listado_PuestosAsync() {
            return base.Channel.Listado_PuestosAsync();
        }
        
        public System.Data.DataSet Buscar_Puesto(int idPuesto) {
            return base.Channel.Buscar_Puesto(idPuesto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Buscar_PuestoAsync(int idPuesto) {
            return base.Channel.Buscar_PuestoAsync(idPuesto);
        }
        
        public int Insertar_Puesto(string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto) {
            return base.Channel.Insertar_Puesto(nombrePuesto, caracteristicasPuesto, sueldoPuesto);
        }
        
        public System.Threading.Tasks.Task<int> Insertar_PuestoAsync(string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto) {
            return base.Channel.Insertar_PuestoAsync(nombrePuesto, caracteristicasPuesto, sueldoPuesto);
        }
        
        public int actualizar_puesto(int idPuesto, string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto) {
            return base.Channel.actualizar_puesto(idPuesto, nombrePuesto, caracteristicasPuesto, sueldoPuesto);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_puestoAsync(int idPuesto, string nombrePuesto, string caracteristicasPuesto, double sueldoPuesto) {
            return base.Channel.actualizar_puestoAsync(idPuesto, nombrePuesto, caracteristicasPuesto, sueldoPuesto);
        }
        
        public int eliminar_sucursal(int idPuesto) {
            return base.Channel.eliminar_sucursal(idPuesto);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_sucursalAsync(int idPuesto) {
            return base.Channel.eliminar_sucursalAsync(idPuesto);
        }
    }
}
