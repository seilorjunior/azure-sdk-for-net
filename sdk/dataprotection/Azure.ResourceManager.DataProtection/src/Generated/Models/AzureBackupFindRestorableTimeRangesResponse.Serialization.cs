// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    public partial class AzureBackupFindRestorableTimeRangesResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RestorableTimeRanges))
            {
                writer.WritePropertyName("restorableTimeRanges");
                writer.WriteStartArray();
                foreach (var item in RestorableTimeRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType");
                writer.WriteStringValue(ObjectType);
            }
            writer.WriteEndObject();
        }

        internal static AzureBackupFindRestorableTimeRangesResponse DeserializeAzureBackupFindRestorableTimeRangesResponse(JsonElement element)
        {
            Optional<IList<RestorableTimeRange>> restorableTimeRanges = default;
            Optional<string> objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restorableTimeRanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorableTimeRange> array = new List<RestorableTimeRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableTimeRange.DeserializeRestorableTimeRange(item));
                    }
                    restorableTimeRanges = array;
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new AzureBackupFindRestorableTimeRangesResponse(Optional.ToList(restorableTimeRanges), objectType.Value);
        }
    }
}
