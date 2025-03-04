﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniSqlQuery.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-dd HH:mm:ss.fff")]
        public string DateTimeFormat {
            get {
                return ((string)(this["DateTimeFormat"]));
            }
            set {
                this["DateTimeFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultConnectionDefinitionFilename {
            get {
                return ((string)(this["DefaultConnectionDefinitionFilename"]));
            }
            set {
                this["DefaultConnectionDefinitionFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableQueryBatching {
            get {
                return ((bool)(this["EnableQueryBatching"]));
            }
            set {
                this["EnableQueryBatching"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"SQL Files (*.sql)|*.sql|Mini SQL Template Files (*.mt)|*.mt|ASPX Files (*.asp;*.aspx;*.asax;*.asmx)|*.asp;*.aspx;*.asax;*.asmx|Batch Files (*.bat;*.cmd)|*.bat;*.cmd|BOO Files (*.boo)|*.boo|Coco Files (*.atg)|*.atg|C++ Files (*.cpp;*.cc;*.c;*.h)|*.cpp;*.cc;*.c;*.h|C# Files (*.cs)|*.cs|HTML Files (*.htm*)|*.htm*|Java Files (*.java)|*.java|JavaScript Files (*.js)|*.js|Patch Files (*.patch;*.diff)|*.patch;*.diff|PHP Files (*.php*)|*.php*|TeX Files (*.tex)|*.tex|VB.NET Files (*.vb)|*.vb|XML Files (*.xml;*.resx)|*.xml;*.resx|All Files (*.*)|*.*")]
        public string FileDialogFilter {
            get {
                return ((string)(this["FileDialogFilter"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IncludeReadOnlyColumnsInExport {
            get {
                return ((bool)(this["IncludeReadOnlyColumnsInExport"]));
            }
            set {
                this["IncludeReadOnlyColumnsInExport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LoadExternalPlugins {
            get {
                return ((bool)(this["LoadExternalPlugins"]));
            }
            set {
                this["LoadExternalPlugins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default - MSSQL Master@localhost")]
        public string NammedConnection {
            get {
                return ((string)(this["NammedConnection"]));
            }
            set {
                this["NammedConnection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<NULL>")]
        public string NullText {
            get {
                return ((string)(this["NullText"]));
            }
            set {
                this["NullText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.PlugIn.dll")]
        public string PlugInFileFilter {
            get {
                return ((string)(this["PlugInFileFilter"]));
            }
            set {
                this["PlugInFileFilter"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.sql")]
        public string SqlFileFilter {
            get {
                return ((string)(this["SqlFileFilter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XML Files (*.xml)|*.xml|All Files (*.*)|*.*")]
        public string XmlFileDialogFilter {
            get {
                return ((string)(this["XmlFileDialogFilter"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int CommandTimeout {
            get {
                return ((int)(this["CommandTimeout"]));
            }
            set {
                this["CommandTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection MostRecentFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MostRecentFiles"]));
            }
            set {
                this["MostRecentFiles"] = value;
            }
        }
    }
}
