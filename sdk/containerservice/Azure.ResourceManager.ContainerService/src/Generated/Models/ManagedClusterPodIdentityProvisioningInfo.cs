// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The ManagedClusterPodIdentityProvisioningInfo. </summary>
    internal partial class ManagedClusterPodIdentityProvisioningInfo
    {
        /// <summary> Initializes a new instance of ManagedClusterPodIdentityProvisioningInfo. </summary>
        internal ManagedClusterPodIdentityProvisioningInfo()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterPodIdentityProvisioningInfo. </summary>
        /// <param name="error"> Pod identity assignment error (if any). </param>
        internal ManagedClusterPodIdentityProvisioningInfo(ManagedClusterPodIdentityProvisioningError error)
        {
            Error = error;
        }

        /// <summary> Pod identity assignment error (if any). </summary>
        internal ManagedClusterPodIdentityProvisioningError Error { get; }
        /// <summary> Details about the error. </summary>
        public ResponseError ErrorDetail
        {
            get => Error?.ErrorDetail;
        }
    }
}
