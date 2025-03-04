// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class representing the DiagnosticRemoteSupportSetting data model. </summary>
    public partial class DiagnosticRemoteSupportSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of DiagnosticRemoteSupportSettingData. </summary>
        public DiagnosticRemoteSupportSettingData()
        {
            RemoteSupportSettingsList = new ChangeTrackingList<EdgeRemoteSupportSettings>();
        }

        /// <summary> Initializes a new instance of DiagnosticRemoteSupportSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="remoteSupportSettingsList"> Remote support settings list according to the RemoteApplicationType. </param>
        internal DiagnosticRemoteSupportSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<EdgeRemoteSupportSettings> remoteSupportSettingsList) : base(id, name, resourceType, systemData)
        {
            RemoteSupportSettingsList = remoteSupportSettingsList;
        }

        /// <summary> Remote support settings list according to the RemoteApplicationType. </summary>
        public IList<EdgeRemoteSupportSettings> RemoteSupportSettingsList { get; }
    }
}
