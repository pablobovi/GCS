﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    public sealed partial class EditableTecnicoesGrid
        : global::Microsoft.LightSwitch.Framework.Client.ScreenObject<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private EditableTecnicoesGrid() : base("LightSwitchApplication.Application5.DesktopClient:EditableTecnicoesGrid")
        {
            global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.Initialize(this);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static EditableTecnicoesGrid CreateInstance()
        {
            return new global::LightSwitchApplication.EditableTecnicoesGrid(
            );
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_Activated();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_Saving(ref bool handled);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_Saved();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_Closing(ref bool cancel);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EditableTecnicoesGrid_SaveError(global::System.Exception exception, ref bool handled);
     
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)((global::Microsoft.LightSwitch.Details.Client.IScreenDetails)this.Details).DataWorkspace;
            }
        }
        
        #endregion
 
        partial void Tecnicoes_SelectionChanged();

        partial void Tecnicoes_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e);

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tecnicoes_Loaded(bool succeeded);

        /// <summary>
        /// Gets the Tecnicoes visual collection. The collection contains all records currently shown on the respective list or grid control.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.Client.VisualCollection<global::LightSwitchApplication.Tecnico> Tecnicoes
        {
            get
            {
                return global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.GetValue(this, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties.Tecnicoes);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tecnicoes_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySet, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.CommandSet, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializePropertyEntry = global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties.Tecnicoes;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>.Entry
                __EditableTecnicoesGridEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>.Entry(
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeInitializeDataWorkspace,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeSavingEvent,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeSavedEvent,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeClosingEvent,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeCreated,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeActivated,
                    global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.__EditableTecnicoesGrid_InvokeSaveErrorEvent);
            private static void __EditableTecnicoesGrid_InvokeInitializeDataWorkspace(global::LightSwitchApplication.EditableTecnicoesGrid s, global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
            {
                s.EditableTecnicoesGrid_InitializeDataWorkspace(saveChangesTo);
            }
            private static bool __EditableTecnicoesGrid_InvokeSavingEvent(global::LightSwitchApplication.EditableTecnicoesGrid s)
            {
                bool handled = false;
                s.EditableTecnicoesGrid_Saving(ref handled);
                return handled;
            }
            private static void __EditableTecnicoesGrid_InvokeSavedEvent(global::LightSwitchApplication.EditableTecnicoesGrid s)
            {
                s.EditableTecnicoesGrid_Saved();
            }
            private static bool __EditableTecnicoesGrid_InvokeClosingEvent(global::LightSwitchApplication.EditableTecnicoesGrid s)
            {
                bool cancel = false;
                s.EditableTecnicoesGrid_Closing(ref cancel);
                return cancel;
            }
            private static void __EditableTecnicoesGrid_InvokeCreated(global::LightSwitchApplication.EditableTecnicoesGrid s)
            {
                s.EditableTecnicoesGrid_Created();
            }
            private static void __EditableTecnicoesGrid_InvokeActivated(global::LightSwitchApplication.EditableTecnicoesGrid s)
            {
                s.EditableTecnicoesGrid_Activated();
            }
            private static bool __EditableTecnicoesGrid_InvokeSaveErrorEvent(global::LightSwitchApplication.EditableTecnicoesGrid s, global::System.Exception ex)
            {
                bool handled = false;
                s.EditableTecnicoesGrid_SaveError(ex, ref handled);
                return handled;
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            private global::Microsoft.LightSwitch.IDataServiceQueryable TecnicoesQuery()
            {
                return this.Screen.DataWorkspace.ApplicationData.Tecnicoes;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico>.Data _Tecnicoes;

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenPropertySet<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico> Tecnicoes
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico>)base.GetItem(global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties.Tecnicoes);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCommandSet<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenMethodSet<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico>.Entry
                    Tecnicoes = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico>.Entry(
                        "Tecnicoes",
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_Stub,
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_Validate,
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_CreateQuery,
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_SelectionChanged,
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_OnCollectionChanged,
                        global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass.PropertySetProperties._Tecnicoes_OnLoaded);
                private static void _Tecnicoes_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EditableTecnicoesGrid, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass, global::LightSwitchApplication.Tecnico>.Data> c, global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass d, object sf)
                {
                    c(d, ref d._Tecnicoes, sf);
                }
                private static void _Tecnicoes_Validate(global::LightSwitchApplication.EditableTecnicoesGrid s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.Tecnicoes_Validate(r);
                }
                private static global::Microsoft.LightSwitch.IDataServiceQueryable _Tecnicoes_CreateQuery(global::LightSwitchApplication.EditableTecnicoesGrid.DetailsClass d, object[] args)
                {
                    return d.TecnicoesQuery();
                }
                private static void _Tecnicoes_SelectionChanged(global::LightSwitchApplication.EditableTecnicoesGrid s)
                {
                    s.Tecnicoes_SelectionChanged();
                }
                private static void _Tecnicoes_OnCollectionChanged(global::LightSwitchApplication.EditableTecnicoesGrid s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    s.Tecnicoes_Changed(e);
                }
                private static void _Tecnicoes_OnLoaded(global::LightSwitchApplication.EditableTecnicoesGrid s, bool succeeded)
                {
                    s.Tecnicoes_Loaded(succeeded);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {
            }
        }
    }
}