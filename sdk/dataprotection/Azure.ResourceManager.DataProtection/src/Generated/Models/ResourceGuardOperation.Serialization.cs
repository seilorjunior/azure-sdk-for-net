// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    public partial class ResourceGuardOperation
    {
        internal static ResourceGuardOperation DeserializeResourceGuardOperation(JsonElement element)
        {
            Optional<string> vaultCriticalOperation = default;
            Optional<string> requestResourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultCriticalOperation"))
                {
                    vaultCriticalOperation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestResourceType"))
                {
                    requestResourceType = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceGuardOperation(vaultCriticalOperation.Value, requestResourceType.Value);
        }
    }
}
