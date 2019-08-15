﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEstudiante.Estudiantes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estudiante", Namespace="http://schemas.datacontract.org/2004/07/PRUEBA_NET.Rest.Dominio")]
    [System.SerializableAttribute()]
    public partial class Estudiante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NotaField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nota {
            get {
                return this.NotaField;
            }
            set {
                if ((this.NotaField.Equals(value) != true)) {
                    this.NotaField = value;
                    this.RaisePropertyChanged("Nota");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Estudiantes.IEstudiantes")]
    public interface IEstudiantes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/CrearActividad", ReplyAction="http://tempuri.org/IEstudiantes/CrearActividadResponse")]
        WebEstudiante.Estudiantes.Estudiante CrearActividad(WebEstudiante.Estudiantes.Estudiante std);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/CrearActividad", ReplyAction="http://tempuri.org/IEstudiantes/CrearActividadResponse")]
        System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante> CrearActividadAsync(WebEstudiante.Estudiantes.Estudiante std);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/ObtenerMaxMin", ReplyAction="http://tempuri.org/IEstudiantes/ObtenerMaxMinResponse")]
        WebEstudiante.Estudiantes.Estudiante[] ObtenerMaxMin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/ObtenerMaxMin", ReplyAction="http://tempuri.org/IEstudiantes/ObtenerMaxMinResponse")]
        System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante[]> ObtenerMaxMinAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/ConsultarPromedio", ReplyAction="http://tempuri.org/IEstudiantes/ConsultarPromedioResponse")]
        WebEstudiante.Estudiantes.Estudiante[] ConsultarPromedio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudiantes/ConsultarPromedio", ReplyAction="http://tempuri.org/IEstudiantes/ConsultarPromedioResponse")]
        System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante[]> ConsultarPromedioAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstudiantesChannel : WebEstudiante.Estudiantes.IEstudiantes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstudiantesClient : System.ServiceModel.ClientBase<WebEstudiante.Estudiantes.IEstudiantes>, WebEstudiante.Estudiantes.IEstudiantes {
        
        public EstudiantesClient() {
        }
        
        public EstudiantesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstudiantesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudiantesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudiantesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebEstudiante.Estudiantes.Estudiante CrearActividad(WebEstudiante.Estudiantes.Estudiante std) {
            return base.Channel.CrearActividad(std);
        }
        
        public System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante> CrearActividadAsync(WebEstudiante.Estudiantes.Estudiante std) {
            return base.Channel.CrearActividadAsync(std);
        }
        
        public WebEstudiante.Estudiantes.Estudiante[] ObtenerMaxMin() {
            return base.Channel.ObtenerMaxMin();
        }
        
        public System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante[]> ObtenerMaxMinAsync() {
            return base.Channel.ObtenerMaxMinAsync();
        }
        
        public WebEstudiante.Estudiantes.Estudiante[] ConsultarPromedio() {
            return base.Channel.ConsultarPromedio();
        }
        
        public System.Threading.Tasks.Task<WebEstudiante.Estudiantes.Estudiante[]> ConsultarPromedioAsync() {
            return base.Channel.ConsultarPromedioAsync();
        }
    }
}