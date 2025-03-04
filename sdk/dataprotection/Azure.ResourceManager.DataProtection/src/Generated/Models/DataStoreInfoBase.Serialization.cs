// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    public partial class DataStoreInfoBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataStoreType");
            writer.WriteStringValue(DataStoreType.ToString());
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static DataStoreInfoBase DeserializeDataStoreInfoBase(JsonElement element)
        {
            DataStoreType dataStoreType = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataStoreType"))
                {
                    dataStoreType = new DataStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new DataStoreInfoBase(dataStoreType, objectType);
        }
    }
}
