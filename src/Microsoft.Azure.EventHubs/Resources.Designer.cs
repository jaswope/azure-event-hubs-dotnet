﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.EventHubs {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.EventHubs.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The received message (delivery-id:{0}, size:{1} bytes) exceeds the limit ({2} bytes) currently allowed on the link..
        /// </summary>
        public static string AmqpMessageSizeExceeded {
            get {
                return ResourceManager.GetString("AmqpMessageSizeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The argument {0} is null or white space..
        /// </summary>
        public static string ArgumentNullOrWhiteSpace {
            get {
                return ResourceManager.GetString("ArgumentNullOrWhiteSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The argument &apos;{0}&apos; cannot exceed {1} characters..
        /// </summary>
        public static string ArgumentStringTooBig {
            get {
                return ResourceManager.GetString("ArgumentStringTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Sending empty {0} is not a valid operation..
        /// </summary>
        public static string CannotSendAnEmptyEvent {
            get {
                return ResourceManager.GetString("CannotSendAnEmptyEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There are no event data supplied. Please make sure input events are not empty..
        /// </summary>
        public static string EventDataListIsNullOrEmpty {
            get {
                return ResourceManager.GetString("EventDataListIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Serialization operation failed due to unsupported type {0}..
        /// </summary>
        public static string FailedToSerializeUnsupportedType {
            get {
                return ResourceManager.GetString("FailedToSerializeUnsupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        public static string InvalidEncoding {
            get {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified partitionKey &apos;{0}&apos; is invalid for partition &apos;{1}&apos;. Do not specify a partitionKey when sending using a PartitionedSender.  Instead use EventHubClient.Send..
        /// </summary>
        public static string PartitionInvalidPartitionKey {
            get {
                return ResourceManager.GetString("PartitionInvalidPartitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Argument {0} must be a non-negative timeout value. The provided value was {1}..
        /// </summary>
        public static string TimeoutMustBeNonNegative {
            get {
                return ResourceManager.GetString("TimeoutMustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Argument {0} must be a positive timeout value. The provided value was {1}..
        /// </summary>
        public static string TimeoutMustBePositive {
            get {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The provided token does not specify the &apos;Audience&apos; value..
        /// </summary>
        public static string TokenMissingAudience {
            get {
                return ResourceManager.GetString("TokenMissingAudience", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The provided token does not specify the &apos;ExpiresOn&apos; value..
        /// </summary>
        public static string TokenMissingExpiresOn {
            get {
                return ResourceManager.GetString("TokenMissingExpiresOn", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to {0} cannot be specified along with {1}. {0} alone should be...
        /// </summary>
        public static string SasTokenShouldBeAlone
        {
            get
            {
                return ResourceManager.GetString("SasTokenShouldBeAlone", resourceCulture);
            }
        }

        /// <summary>
        ///    Gets localized string like: Please make sure either all or none of the following arguments are defined: '{0}'.
        /// </summary>
        public static string ArgumentInvalidCombination
        {
            get
            {
                return ResourceManager.GetString("ArgumentInvalidCombination", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to System property '{0}' is missing in the event.
        /// </summary>
        public static string MissingSystemProperty
        {
            get
            {
                return ResourceManager.GetString("MissingSystemProperty", resourceCulture);
            }
        }

        /// <summary>
        /// Gets localized string like: The identifier parameter exceeds the maximum allowed size of {0} characters.
        /// </summary>
        internal static string ReceiverIdentifierOverMaxValue
        {
            get
            {
                return ResourceManager.GetString("ReceiverIdentifierOverMaxValue", resourceCulture);
            }
        }
    }
}
