﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZumoContrib.Sync.SQLCeStore.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ZumoContrib.Sync.SQLCeStore.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A Windows Azure Mobile Services assembly for the current platform was not found. Ensure that the current project references both {0} and the following platform-specific assembly: {1}..
        /// </summary>
        internal static string Platform_AssemblyNotFound {
            get {
                return ResourceManager.GetString("Platform_AssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Column with name &apos;{0}&apos; is not defined on the local table &apos;{1}&apos;..
        /// </summary>
        internal static string SqlCeStore_ColumnNotDefined {
            get {
                return ResourceManager.GetString("SqlCeStore_ColumnNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot define a table after the store has been initialized..
        /// </summary>
        internal static string SqlCeStore_DefineAfterInitialize {
            get {
                return ResourceManager.GetString("SqlCeStore_DefineAfterInitialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generic type T does not have parameterless constructor..
        /// </summary>
        internal static string SqlCeStore_DefineTableEmptyCtorNotDefined {
            get {
                return ResourceManager.GetString("SqlCeStore_DefineTableEmptyCtorNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generic type T is not an object..
        /// </summary>
        internal static string SqlCeStore_DefineTableTNotAnObject {
            get {
                return ResourceManager.GetString("SqlCeStore_DefineTableTNotAnObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid identifier. Identifiers must be under 128 characters in length, start with a letter or underscore, and can contain only alpha-numeric and underscore characters..
        /// </summary>
        internal static string SqlCeStore_InvalidIdentifier {
            get {
                return ResourceManager.GetString("SqlCeStore_InvalidIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property of type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string SqlCeStore_JTokenNotSupported {
            get {
                return ResourceManager.GetString("SqlCeStore_JTokenNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query execution failed with result: &apos;{0}&apos;..
        /// </summary>
        internal static string SqlCeStore_QueryExecutionFailed {
            get {
                return ResourceManager.GetString("SqlCeStore_QueryExecutionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table with name &apos;{0}&apos; is not defined..
        /// </summary>
        internal static string SqlCeStore_TableNotDefined {
            get {
                return ResourceManager.GetString("SqlCeStore_TableNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of fields per entity in an upsert operation is limited to {0}..
        /// </summary>
        internal static string SqlCeStore_TooManyColumns {
            get {
                return ResourceManager.GetString("SqlCeStore_TooManyColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string SqlCeStore_ValueTypeNotSupported {
            get {
                return ResourceManager.GetString("SqlCeStore_ValueTypeNotSupported", resourceCulture);
            }
        }
    }
}
