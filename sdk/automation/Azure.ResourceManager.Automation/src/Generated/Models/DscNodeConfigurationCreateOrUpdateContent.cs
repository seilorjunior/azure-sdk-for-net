// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update node configuration operation. </summary>
    public partial class DscNodeConfigurationCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of DscNodeConfigurationCreateOrUpdateContent. </summary>
        public DscNodeConfigurationCreateOrUpdateContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Name of the node configuration. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the source. </summary>
        public ContentSource Source { get; set; }
        /// <summary> Gets or sets the configuration of the node. </summary>
        internal DscConfigurationAssociationProperty Configuration { get; set; }
        /// <summary> Gets or sets the name of the Dsc configuration. </summary>
        public string ConfigurationName
        {
            get => Configuration is null ? default : Configuration.ConfigurationName;
            set
            {
                if (Configuration is null)
                    Configuration = new DscConfigurationAssociationProperty();
                Configuration.ConfigurationName = value;
            }
        }

        /// <summary> If a new build version of NodeConfiguration is required. </summary>
        public bool? IncrementNodeConfigurationBuild { get; set; }
    }
}
