﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Componente
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Componente :
        global::LightSwitchApplication.Componente.DetailsClass.IImplementation
    {
        partial void OnOrdenMant_ComponenteChanged()
        {
            this.___OnPropertyChanged("OrdenMant_Componente");
            this.___OnPropertyChanged("OrdenMant");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnnombreChanged()
        {
            this.___OnPropertyChanged("nombre");
        }
        
        partial void OncodigoChanged()
        {
            this.___OnPropertyChanged("codigo");
        }
        
        partial void OntipoChanged()
        {
            this.___OnPropertyChanged("tipo");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Componente.DetailsClass.IImplementation.OrdenMant
        {
            get
            {
                return this.OrdenMant;
            }
            set
            {
                this.OrdenMant = (global::LightSwitchApplication.Implementation.OrdenMant)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.OrdenMant> __OrdenMant
        {
            get
            {
                if (this.___OrdenMant == null)
                {
                    this.___OrdenMant = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.OrdenMant>(
                        this,
                        "OrdenMant",
                        new string[] { "OrdenMant_Componente" },
                        e => global::System.Object.Equals(e.Id, this.OrdenMant_Componente),
                        () => this._OrdenMant,
                        e => this._OrdenMant = e);
                }
                return this.___OrdenMant;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.OrdenMant> ___OrdenMant;
        
    }
    #endregion
    
    #region Lab
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Lab :
        global::LightSwitchApplication.Lab.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnCantPcChanged()
        {
            this.___OnPropertyChanged("CantPc");
        }
        
        partial void OnnombreChanged()
        {
            this.___OnPropertyChanged("nombre");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Lab.DetailsClass.IImplementation.OrdenMant
        {
            get
            {
                return this.OrdenMant;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> __OrdenMant
        {
            get
            {
                if (this.___OrdenMant == null)
                {
                    this.___OrdenMant = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant>(
                        this,
                        "OrdenMant",
                        () => this._OrdenMant,
                        e => global::System.Object.Equals(e.OrdenMant_Lab, this.Id));
                }
                return this.___OrdenMant;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> ___OrdenMant;
        
    }
    #endregion
    
    #region OrdenMant
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrdenMant :
        global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation
    {
        partial void OnOrdenMant_PedidoChanged()
        {
            this.___OnPropertyChanged("OrdenMant_Pedido");
            this.___OnPropertyChanged("Pedidoes");
        }
        
        partial void OnOrdenMant_TecnicoChanged()
        {
            this.___OnPropertyChanged("OrdenMant_Tecnico");
            this.___OnPropertyChanged("Tecnico");
        }
        
        partial void OnOrdenMant_LabChanged()
        {
            this.___OnPropertyChanged("OrdenMant_Lab");
            this.___OnPropertyChanged("Labs");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnEstadoChanged()
        {
            this.___OnPropertyChanged("Estado");
        }
        
        partial void OnTipoChanged()
        {
            this.___OnPropertyChanged("Tipo");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Pedidoes
        {
            get
            {
                return this.Pedidoes;
            }
            set
            {
                this.Pedidoes = (global::LightSwitchApplication.Implementation.Pedido)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Pedido> __Pedidoes
        {
            get
            {
                if (this.___Pedidoes == null)
                {
                    this.___Pedidoes = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Pedido>(
                        this,
                        "Pedidoes",
                        new string[] { "OrdenMant_Pedido" },
                        e => global::System.Object.Equals(e.Id, this.OrdenMant_Pedido),
                        () => this._Pedidoes,
                        e => this._Pedidoes = e);
                }
                return this.___Pedidoes;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Pedido> ___Pedidoes;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Componentes
        {
            get
            {
                return this.Componentes;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Componente> __Componentes
        {
            get
            {
                if (this.___Componentes == null)
                {
                    this.___Componentes = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Componente>(
                        this,
                        "Componentes",
                        () => this._Componentes,
                        e => global::System.Object.Equals(e.OrdenMant_Componente, this.Id));
                }
                return this.___Componentes;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Componente> ___Componentes;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Tecnico
        {
            get
            {
                return this.Tecnico;
            }
            set
            {
                this.Tecnico = (global::LightSwitchApplication.Implementation.Tecnico)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tecnico> __Tecnico
        {
            get
            {
                if (this.___Tecnico == null)
                {
                    this.___Tecnico = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tecnico>(
                        this,
                        "Tecnico",
                        new string[] { "OrdenMant_Tecnico" },
                        e => global::System.Object.Equals(e.Id, this.OrdenMant_Tecnico),
                        () => this._Tecnico,
                        e => this._Tecnico = e);
                }
                return this.___Tecnico;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tecnico> ___Tecnico;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Labs
        {
            get
            {
                return this.Labs;
            }
            set
            {
                this.Labs = (global::LightSwitchApplication.Implementation.Lab)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Lab> __Labs
        {
            get
            {
                if (this.___Labs == null)
                {
                    this.___Labs = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Lab>(
                        this,
                        "Labs",
                        new string[] { "OrdenMant_Lab" },
                        e => global::System.Object.Equals(e.Id, this.OrdenMant_Lab),
                        () => this._Labs,
                        e => this._Labs = e);
                }
                return this.___Labs;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Lab> ___Labs;
        
    }
    #endregion
    
    #region Pedido
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Pedido :
        global::LightSwitchApplication.Pedido.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNombreSolicChanged()
        {
            this.___OnPropertyChanged("NombreSolic");
        }
        
        partial void OnCantPCChanged()
        {
            this.___OnPropertyChanged("CantPC");
        }
        
        partial void OnCantLabsChanged()
        {
            this.___OnPropertyChanged("CantLabs");
        }
        
        partial void OnsoftwareChanged()
        {
            this.___OnPropertyChanged("software");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Pedido.DetailsClass.IImplementation.Ordenmant
        {
            get
            {
                return this.Ordenmant;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> __Ordenmant
        {
            get
            {
                if (this.___Ordenmant == null)
                {
                    this.___Ordenmant = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant>(
                        this,
                        "Ordenmant",
                        () => this._Ordenmant,
                        e => global::System.Object.Equals(e.OrdenMant_Pedido, this.Id));
                }
                return this.___Ordenmant;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> ___Ordenmant;
        
    }
    #endregion
    
    #region Tecnico
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Tecnico :
        global::LightSwitchApplication.Tecnico.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNombreChanged()
        {
            this.___OnPropertyChanged("Nombre");
        }
        
        partial void OnLegajoChanged()
        {
            this.___OnPropertyChanged("Legajo");
        }
        
        partial void OnApellidoChanged()
        {
            this.___OnPropertyChanged("Apellido");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Tecnico.DetailsClass.IImplementation.OrdenMants
        {
            get
            {
                return this.OrdenMants;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> __OrdenMants
        {
            get
            {
                if (this.___OrdenMants == null)
                {
                    this.___OrdenMants = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant>(
                        this,
                        "OrdenMants",
                        () => this._OrdenMants,
                        e => global::System.Object.Equals(e.OrdenMant_Tecnico, this.Id));
                }
                return this.___OrdenMants;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.OrdenMant> ___OrdenMants;
        
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Componente))
            {
                return new global::LightSwitchApplication.Implementation.Componente();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Lab))
            {
                return new global::LightSwitchApplication.Implementation.Lab();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.OrdenMant))
            {
                return new global::LightSwitchApplication.Implementation.OrdenMant();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Pedido))
            {
                return new global::LightSwitchApplication.Implementation.Pedido();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Tecnico))
            {
                return new global::LightSwitchApplication.Implementation.Tecnico();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.ApplicationData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Componente) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Componente);
            }
            if (typeof(global::LightSwitchApplication.Lab) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Lab);
            }
            if (typeof(global::LightSwitchApplication.OrdenMant) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.OrdenMant);
            }
            if (typeof(global::LightSwitchApplication.Pedido) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Pedido);
            }
            if (typeof(global::LightSwitchApplication.Tecnico) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Tecnico);
            }
            return null;
        }
    }
}
