﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceLOCParticipante {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLOCParticipante.WebServiceLOCParticipanteSoap")]
    public interface WebServiceLOCParticipanteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarParticipanteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void agregarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarParticipanteService", ReplyAction="*")]
        System.Threading.Tasks.Task agregarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarParticipanteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listarParticipanteService();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarParticipanteService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarParticipanteServiceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarParticipanteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarParticipanteService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarRut", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceLOCParticipante.Participante buscarRut(CapaGUI.ServiceLOCParticipante.Participante participante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarRut", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceLOCParticipante.Participante> buscarRutAsync(CapaGUI.ServiceLOCParticipante.Participante participante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarParticipanteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void modificarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarParticipanteService", ReplyAction="*")]
        System.Threading.Tasks.Task modificarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdParticipanteServie", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscarIdParticipanteServie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdParticipanteServie", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarIdParticipanteServieAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Participante : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long id_Participante1Field;
        
        private string rut_Participante1Field;
        
        private string nombre_Participante1Field;
        
        private string apellido_Patreno_Participante1Field;
        
        private string apellido_Materno_Participante1Field;
        
        private System.DateTime fecha_Nacimiento_Participante1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Id_Participante1 {
            get {
                return this.id_Participante1Field;
            }
            set {
                this.id_Participante1Field = value;
                this.RaisePropertyChanged("Id_Participante1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Rut_Participante1 {
            get {
                return this.rut_Participante1Field;
            }
            set {
                this.rut_Participante1Field = value;
                this.RaisePropertyChanged("Rut_Participante1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nombre_Participante1 {
            get {
                return this.nombre_Participante1Field;
            }
            set {
                this.nombre_Participante1Field = value;
                this.RaisePropertyChanged("Nombre_Participante1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Apellido_Patreno_Participante1 {
            get {
                return this.apellido_Patreno_Participante1Field;
            }
            set {
                this.apellido_Patreno_Participante1Field = value;
                this.RaisePropertyChanged("Apellido_Patreno_Participante1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Apellido_Materno_Participante1 {
            get {
                return this.apellido_Materno_Participante1Field;
            }
            set {
                this.apellido_Materno_Participante1Field = value;
                this.RaisePropertyChanged("Apellido_Materno_Participante1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime Fecha_Nacimiento_Participante1 {
            get {
                return this.fecha_Nacimiento_Participante1Field;
            }
            set {
                this.fecha_Nacimiento_Participante1Field = value;
                this.RaisePropertyChanged("Fecha_Nacimiento_Participante1");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Estado_Participante : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long id_Estado_Comuna1Field;
        
        private string descripcion_Estado_Participante1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Id_Estado_Comuna1 {
            get {
                return this.id_Estado_Comuna1Field;
            }
            set {
                this.id_Estado_Comuna1Field = value;
                this.RaisePropertyChanged("Id_Estado_Comuna1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Descripcion_Estado_Participante1 {
            get {
                return this.descripcion_Estado_Participante1Field;
            }
            set {
                this.descripcion_Estado_Participante1Field = value;
                this.RaisePropertyChanged("Descripcion_Estado_Participante1");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Sexo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long id_Sexo1Field;
        
        private string descripcion_Sexo1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Id_Sexo1 {
            get {
                return this.id_Sexo1Field;
            }
            set {
                this.id_Sexo1Field = value;
                this.RaisePropertyChanged("Id_Sexo1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Descripcion_Sexo1 {
            get {
                return this.descripcion_Sexo1Field;
            }
            set {
                this.descripcion_Sexo1Field = value;
                this.RaisePropertyChanged("Descripcion_Sexo1");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Comuna : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long id_Comuna1Field;
        
        private string nombre_Comuna1Field;
        
        private string sigla_Comuna1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Id_Comuna1 {
            get {
                return this.id_Comuna1Field;
            }
            set {
                this.id_Comuna1Field = value;
                this.RaisePropertyChanged("Id_Comuna1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre_Comuna1 {
            get {
                return this.nombre_Comuna1Field;
            }
            set {
                this.nombre_Comuna1Field = value;
                this.RaisePropertyChanged("Nombre_Comuna1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Sigla_Comuna1 {
            get {
                return this.sigla_Comuna1Field;
            }
            set {
                this.sigla_Comuna1Field = value;
                this.RaisePropertyChanged("Sigla_Comuna1");
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
    public interface WebServiceLOCParticipanteSoapChannel : CapaGUI.ServiceLOCParticipante.WebServiceLOCParticipanteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceLOCParticipanteSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceLOCParticipante.WebServiceLOCParticipanteSoap>, CapaGUI.ServiceLOCParticipante.WebServiceLOCParticipanteSoap {
        
        public WebServiceLOCParticipanteSoapClient() {
        }
        
        public WebServiceLOCParticipanteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceLOCParticipanteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLOCParticipanteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLOCParticipanteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void agregarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado) {
            base.Channel.agregarParticipanteService(participante, comuna, sexo, estado);
        }
        
        public System.Threading.Tasks.Task agregarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado) {
            return base.Channel.agregarParticipanteServiceAsync(participante, comuna, sexo, estado);
        }
        
        public System.Data.DataSet listarParticipanteService() {
            return base.Channel.listarParticipanteService();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarParticipanteServiceAsync() {
            return base.Channel.listarParticipanteServiceAsync();
        }
        
        public void eliminarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante) {
            base.Channel.eliminarParticipanteService(participante);
        }
        
        public System.Threading.Tasks.Task eliminarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante) {
            return base.Channel.eliminarParticipanteServiceAsync(participante);
        }
        
        public CapaGUI.ServiceLOCParticipante.Participante buscarRut(CapaGUI.ServiceLOCParticipante.Participante participante) {
            return base.Channel.buscarRut(participante);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceLOCParticipante.Participante> buscarRutAsync(CapaGUI.ServiceLOCParticipante.Participante participante) {
            return base.Channel.buscarRutAsync(participante);
        }
        
        public void modificarParticipanteService(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado) {
            base.Channel.modificarParticipanteService(participante, comuna, sexo, estado);
        }
        
        public System.Threading.Tasks.Task modificarParticipanteServiceAsync(CapaGUI.ServiceLOCParticipante.Participante participante, CapaGUI.ServiceLOCParticipante.Comuna comuna, CapaGUI.ServiceLOCParticipante.Sexo sexo, CapaGUI.ServiceLOCParticipante.Estado_Participante estado) {
            return base.Channel.modificarParticipanteServiceAsync(participante, comuna, sexo, estado);
        }
        
        public System.Data.DataSet buscarIdParticipanteServie() {
            return base.Channel.buscarIdParticipanteServie();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarIdParticipanteServieAsync() {
            return base.Channel.buscarIdParticipanteServieAsync();
        }
    }
}