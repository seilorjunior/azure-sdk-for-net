// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for servers connection configuration. </summary>
    public partial class DefenderForServersGcpOfferingDefenderForServers
    {
        /// <summary> Initializes a new instance of DefenderForServersGcpOfferingDefenderForServers. </summary>
        public DefenderForServersGcpOfferingDefenderForServers()
        {
        }

        /// <summary> Initializes a new instance of DefenderForServersGcpOfferingDefenderForServers. </summary>
        /// <param name="workloadIdentityProviderId"> The workload identity provider id in GCP for this feature. </param>
        /// <param name="serviceAccountEmailAddress"> The service account email address in GCP for this feature. </param>
        internal DefenderForServersGcpOfferingDefenderForServers(string workloadIdentityProviderId, string serviceAccountEmailAddress)
        {
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
        }

        /// <summary> The workload identity provider id in GCP for this feature. </summary>
        public string WorkloadIdentityProviderId { get; set; }
        /// <summary> The service account email address in GCP for this feature. </summary>
        public string ServiceAccountEmailAddress { get; set; }
    }
}
