﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataDumper {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConfigStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataDumper.ConfigStrings", typeof(ConfigStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debug.
        /// </summary>
        internal static string SECTION_DEBUG {
            get {
                return ResourceManager.GetString("SECTION_DEBUG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Developer Settings.
        /// </summary>
        internal static string SECTION_DEV {
            get {
                return ResourceManager.GetString("SECTION_DEV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General Settings.
        /// </summary>
        internal static string SECTION_GENERAL {
            get {
                return ResourceManager.GetString("SECTION_GENERAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DumpUnknown.
        /// </summary>
        internal static string SETTING_DUMPFILE {
            get {
                return ResourceManager.GetString("SETTING_DUMPFILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debug Setting
        ///If enabled, when an unknown data block is encounterd the files contents will be dumped into the console.
        /// </summary>
        internal static string SETTING_DUMPFILE_DESC {
            get {
                return ResourceManager.GetString("SETTING_DUMPFILE_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EnableHotReload.
        /// </summary>
        internal static string SETTING_HOTRELOAD {
            get {
                return ResourceManager.GetString("SETTING_HOTRELOAD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Developer Setting
        ///Hot reloading is an experimental feature that allows the user to reload game data blocks without having to restart the game
        ///Currently this only works on the &apos;Rundown&apos; and &apos;LevelLayout&apos; data blocks.
        /// </summary>
        internal static string SETTING_HOTRELOAD_DESC {
            get {
                return ResourceManager.GetString("SETTING_HOTRELOAD_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RundownPackage.
        /// </summary>
        internal static string SETTING_RUNDOWNPACKAGE {
            get {
                return ResourceManager.GetString("SETTING_RUNDOWNPACKAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the folder containing the game data to load
        ///Folders containing game data should be placed in config&gt;Rundowns
        ///&apos;default&apos; loads a folder matching &apos;GameData_XXXXX&apos; where X is the current game version.
        /// </summary>
        internal static string SETTING_RUNDOWNPACKAGE_DESC {
            get {
                return ResourceManager.GetString("SETTING_RUNDOWNPACKAGE_DESC", resourceCulture);
            }
        }
    }
}
