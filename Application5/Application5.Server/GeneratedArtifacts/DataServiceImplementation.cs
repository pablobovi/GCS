﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Componente))
            {
                return new global::LightSwitchApplication.Implementation.Componente();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Lab))
            {
                return new global::LightSwitchApplication.Implementation.Lab();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.OrdenMant))
            {
                return new global::LightSwitchApplication.Implementation.OrdenMant();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Pedido))
            {
                return new global::LightSwitchApplication.Implementation.Pedido();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Tecnico))
            {
                return new global::LightSwitchApplication.Implementation.Tecnico();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.WorkStation))
            {
                return new global::LightSwitchApplication.Implementation.WorkStation();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
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
            if (typeof(T) == typeof(global::LightSwitchApplication.WorkStation))
            {
                return new global::LightSwitchApplication.Implementation.WorkStation();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
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
            if (typeof(global::LightSwitchApplication.WorkStation) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.WorkStation);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Componente :
        global::LightSwitchApplication.Componente.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Componente.DetailsClass.IImplementation.WorkStation
        {
            get
            {
                return this.WorkStation;
            }
            set
            {
                this.WorkStation = (global::LightSwitchApplication.Implementation.WorkStation)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("WorkStation");
                }
            }
        }
        
        partial void OnWorkStation_ComponenteChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("WorkStation");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Lab :
        global::LightSwitchApplication.Lab.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Lab.DetailsClass.IImplementation.OrdenMant
        {
            get
            {
                return this.OrdenMant;
            }
            set
            {
                this.OrdenMant = (global::LightSwitchApplication.Implementation.OrdenMant)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrdenMant");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Lab.DetailsClass.IImplementation.WorkStations
        {
            get
            {
                return this.WorkStations;
            }
        }
        
        partial void OnOrdenMant_LabChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrdenMant");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrdenMant :
        global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Labs
        {
            get
            {
                return this.Labs;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Pedidoes
        {
            get
            {
                return this.Pedidoes;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrdenMant.DetailsClass.IImplementation.Tecnico
        {
            get
            {
                return this.Tecnico;
            }
            set
            {
                this.Tecnico = (global::LightSwitchApplication.Implementation.Tecnico)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Tecnico");
                }
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Pedido :
        global::LightSwitchApplication.Pedido.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Pedido.DetailsClass.IImplementation.OrdenMant
        {
            get
            {
                return this.OrdenMant;
            }
            set
            {
                this.OrdenMant = (global::LightSwitchApplication.Implementation.OrdenMant)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrdenMant");
                }
            }
        }
        
        partial void OnOrdenMant_PedidoChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrdenMant");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Tecnico :
        global::LightSwitchApplication.Tecnico.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Tecnico.DetailsClass.IImplementation.OrdenMant
        {
            get
            {
                return this.OrdenMant;
            }
            set
            {
                this.OrdenMant = (global::LightSwitchApplication.Implementation.OrdenMant)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrdenMant");
                }
            }
        }
        
        partial void OnIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrdenMant");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class WorkStation :
        global::LightSwitchApplication.WorkStation.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.WorkStation.DetailsClass.IImplementation.Componentes
        {
            get
            {
                return this.Componentes;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.WorkStation.DetailsClass.IImplementation.Lab
        {
            get
            {
                return this.Lab;
            }
            set
            {
                this.Lab = (global::LightSwitchApplication.Implementation.Lab)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Lab");
                }
            }
        }
        
        partial void OnLab_WorkStationChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Lab");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
