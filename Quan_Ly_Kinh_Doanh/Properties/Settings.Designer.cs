﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Do_An_Quan_Ly_Kho.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=QLK_quang_make;Integrated Security=True")]
        public string Do_An_QLK_ConnectionString {
            get {
                return ((string)(this["Do_An_QLK_ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=QLK_quang_make;User ID=sa;Password=12345" +
            "6")]
        public string Do_An_QLK_ConnectionString1 {
            get {
                return ((string)(this["Do_An_QLK_ConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS2005;Initial Catalog=Do_An_Quan_Ly_Kho;User ID=sa")]
        public string Do_An_QLK_ConnectionString2 {
            get {
                return ((string)(this["Do_An_QLK_ConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS2005;Initial Catalog=QLK_quang_make;User ID=sa;Password=1" +
            "23456")]
        public string Do_An_QLK_ConnectionString3 {
            get {
                return ((string)(this["Do_An_QLK_ConnectionString3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=TEMP_TTYT_LAI_CHAU;Integrated Security=T" +
            "rue")]
        public string TEMP_TTYT_LAI_CHAUConnectionString {
            get {
                return ((string)(this["TEMP_TTYT_LAI_CHAUConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=Do_An_Quan_Ly_Kho;Integrated Security=Tr" +
            "ue")]
        public string Do_An_Quan_Ly_KhoConnectionString {
            get {
                return ((string)(this["Do_An_Quan_Ly_KhoConnectionString"]));
            }
        }
    }
}
