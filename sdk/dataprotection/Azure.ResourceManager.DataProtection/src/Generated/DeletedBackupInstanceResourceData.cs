// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataProtection.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtection
{
    /// <summary> A class representing the DeletedBackupInstanceResource data model. </summary>
    public partial class DeletedBackupInstanceResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedBackupInstanceResourceData. </summary>
        public DeletedBackupInstanceResourceData()
        {
        }

        /// <summary> Initializes a new instance of DeletedBackupInstanceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> DeletedBackupInstanceResource properties. </param>
        internal DeletedBackupInstanceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DeletedBackupInstance properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> DeletedBackupInstanceResource properties. </summary>
        public DeletedBackupInstance Properties { get; set; }
    }
}
