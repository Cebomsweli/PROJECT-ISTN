﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=WSTISTWEB2\\ISTN3;Initial Catalog=ist3cx;Persist Security Info=True;Us" +
            "er ID=ist3cx;Password=g8j687;TrustServerCertificate=True")]
        public string ist3cxConnectionString {
            get {
                return ((string)(this["ist3cxConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=146.230.177.46;Initial Catalog=G12Wst2024;User ID=G12Wst2024;Password" +
            "=auhwd")]
        public string G12Wst2024ConnectionString {
            get {
                return ((string)(this["G12Wst2024ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=146.230.177.46\\ISTN3;Initial Catalog=ist3cx;Persist Security Info=Tru" +
            "e;User ID=ist3cx;Password=g8j687;Encrypt=True;TrustServerCertificate=True")]
        public string ist3cxConnectionString1 {
            get {
                return ((string)(this["ist3cxConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=146.230.177.46\\ISTN3;Initial Catalog=ist3df;Persist Security Info=Tru" +
            "e;User ID=ist3df;Password=yn6yw4")]
        public string ist3dfConnectionString {
            get {
                return ((string)(this["ist3dfConnectionString"]));
            }
        }
    }
}
