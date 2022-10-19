﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Axe.Windows.Desktop.Resources {
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
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Axe.Windows.Desktop.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to DequeColors can only be instantiated with fully opaque (Alpha = 255) colors. The DequeColor Blend method can help you if you know the background color.
        /// </summary>
        internal static string DequeOpaqueColors {
            get {
                return ResourceManager.GetString("DequeOpaqueColors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to High Confidence threshold must be &lt; 1.0.
        /// </summary>
        internal static string HighConfidenceLargerThan1 {
            get {
                return ResourceManager.GetString("HighConfidenceLargerThan1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to High Confidence threshold must be larger than Mid confidence threshold.
        /// </summary>
        internal static string HighConfidenceLargerThanMid {
            get {
                return ResourceManager.GetString("HighConfidenceLargerThanMid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Color components are values between 0 and 255.
        /// </summary>
        internal static string InvalidColor {
            get {
                return ResourceManager.GetString("InvalidColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Low Confidence threshold must be &gt; 0.0.
        /// </summary>
        internal static string LowConfidenceGreaterThan0 {
            get {
                return ResourceManager.GetString("LowConfidenceGreaterThan0", resourceCulture);
            }
        }

        ///   Looks up a localized string similar to The dataContext passed in does not match this A11yAutomation.
        /// </summary>
        internal static string InvalidContext {
            get {
                return ResourceManager.GetString("InvalidContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mid Confidence threshold must be larger than Low confidence threshold.
        /// </summary>
        internal static string MidConfidenceLargerThanLow {
            get {
                return ResourceManager.GetString("MidConfidenceLargerThanLow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pattern may no longer be valid.
        /// </summary>
        internal static string PatternNoLongerValid {
            get {
                return ResourceManager.GetString("PatternNoLongerValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tree walker exception: {0}.
        /// </summary>
        internal static string TreeWalkerException {
            get {
                return ResourceManager.GetString("TreeWalkerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unset or unknown type.
        /// </summary>
        internal static string UnsetOrUnknownType {
            get {
                return ResourceManager.GetString("UnsetOrUnknownType", resourceCulture);
            }
        }
    }
}
