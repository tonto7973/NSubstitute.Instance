﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NSubstitute.Instantiation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal partial class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NSubstitute.Instantiation.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to Cannot create an instance of type &apos;{0}&apos; because it is an interface..
        /// </summary>
        internal static string CannotCreateInstanceOfInterface {
            get {
                return ResourceManager.GetString("CannotCreateInstanceOfInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create an instance of type &apos;{0}&apos; because its constructor &apos;{1}&apos; depends on itself..
        /// </summary>
        internal static string CannotCreateInstanceOfRecursiveType {
            get {
                return ResourceManager.GetString("CannotCreateInstanceOfRecursiveType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create an instance of type &apos;{0}&apos; because it has unbounded type parameters..
        /// </summary>
        internal static string CannotCreateInstanceOfUnboundedType {
            get {
                return ResourceManager.GetString("CannotCreateInstanceOfUnboundedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find accessible constructor on type &apos;{0}&apos;..
        /// </summary>
        internal static string CannotFindAccessibleConstructor {
            get {
                return ResourceManager.GetString("CannotFindAccessibleConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find accessible constructor on type &apos;{0}&apos; matching dependencies &apos;[{1}]&apos;..
        /// </summary>
        internal static string CannotFindMatchingAccessibleConstructor {
            get {
                return ResourceManager.GetString("CannotFindMatchingAccessibleConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependency cannot be null; Use Instance.Null instead..
        /// </summary>
        internal static string DependencyCannotBeNull {
            get {
                return ResourceManager.GetString("DependencyCannotBeNull", resourceCulture);
            }
        }
    }
}