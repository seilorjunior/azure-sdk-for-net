// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary> List Restore Ranges Response. </summary>
    public partial class AzureBackupFindRestorableTimeRangesResponseResource : ResourceData
    {
        /// <summary> Initializes a new instance of AzureBackupFindRestorableTimeRangesResponseResource. </summary>
        public AzureBackupFindRestorableTimeRangesResponseResource()
        {
        }

        /// <summary> Initializes a new instance of AzureBackupFindRestorableTimeRangesResponseResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> AzureBackupFindRestorableTimeRangesResponseResource properties. </param>
        internal AzureBackupFindRestorableTimeRangesResponseResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureBackupFindRestorableTimeRangesResponse properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> AzureBackupFindRestorableTimeRangesResponseResource properties. </summary>
        public AzureBackupFindRestorableTimeRangesResponse Properties { get; set; }
    }
}
