// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The MediaKeyDelivery. </summary>
    internal partial class MediaKeyDelivery
    {
        /// <summary> Initializes a new instance of MediaKeyDelivery. </summary>
        public MediaKeyDelivery()
        {
        }

        /// <summary> Initializes a new instance of MediaKeyDelivery. </summary>
        /// <param name="accessControl"> The access control properties for Key Delivery. </param>
        internal MediaKeyDelivery(MediaAccessControl accessControl)
        {
            AccessControl = accessControl;
        }

        /// <summary> The access control properties for Key Delivery. </summary>
        public MediaAccessControl AccessControl { get; set; }
    }
}
