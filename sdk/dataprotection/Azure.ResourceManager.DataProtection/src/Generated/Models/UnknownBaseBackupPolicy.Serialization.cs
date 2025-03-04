// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    internal partial class UnknownBaseBackupPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("datasourceTypes");
            writer.WriteStartArray();
            foreach (var item in DatasourceTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static UnknownBaseBackupPolicy DeserializeUnknownBaseBackupPolicy(JsonElement element)
        {
            IList<string> datasourceTypes = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceTypes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    datasourceTypes = array;
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownBaseBackupPolicy(datasourceTypes, objectType);
        }
    }
}
