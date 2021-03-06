﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.ExpressionEvaluator {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.ExpressionEvaluator.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string ErrorName {
            get {
                return ResourceManager.GetString("ErrorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; threw an exception of type &apos;{1}&apos;.
        /// </summary>
        internal static string ExceptionThrown {
            get {
                return ResourceManager.GetString("ExceptionThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot dereference &apos;{0}&apos;. The pointer is not valid..
        /// </summary>
        internal static string InvalidPointerDereference {
            get {
                return ResourceManager.GetString("InvalidPointerDereference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-Public members.
        /// </summary>
        internal static string NonPublicMembers {
            get {
                return ResourceManager.GetString("NonPublicMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Raw View.
        /// </summary>
        internal static string RawView {
            get {
                return ResourceManager.GetString("RawView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results View.
        /// </summary>
        internal static string ResultsView {
            get {
                return ResourceManager.GetString("ResultsView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results View requires System.Core.dll to be referenced.
        /// </summary>
        internal static string ResultsViewNoSystemCore {
            get {
                return ResourceManager.GetString("ResultsViewNoSystemCore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only Enumerable types can have Results View.
        /// </summary>
        internal static string ResultsViewNotEnumerable {
            get {
                return ResourceManager.GetString("ResultsViewNotEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expanding the Results View will enumerate the IEnumerable.
        /// </summary>
        internal static string ResultsViewValueWarning {
            get {
                return ResourceManager.GetString("ResultsViewValueWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type variables.
        /// </summary>
        internal static string TypeVariablesName {
            get {
                return ResourceManager.GetString("TypeVariablesName", resourceCulture);
            }
        }
    }
}
