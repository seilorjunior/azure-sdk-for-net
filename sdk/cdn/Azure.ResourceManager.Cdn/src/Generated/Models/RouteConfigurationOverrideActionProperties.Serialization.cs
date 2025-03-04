// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RouteConfigurationOverrideActionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(ActionType.ToString());
            if (Optional.IsDefined(OriginGroupOverride))
            {
                if (OriginGroupOverride != null)
                {
                    writer.WritePropertyName("originGroupOverride");
                    writer.WriteObjectValue(OriginGroupOverride);
                }
                else
                {
                    writer.WriteNull("originGroupOverride");
                }
            }
            if (Optional.IsDefined(CacheConfiguration))
            {
                writer.WritePropertyName("cacheConfiguration");
                writer.WriteObjectValue(CacheConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static RouteConfigurationOverrideActionProperties DeserializeRouteConfigurationOverrideActionProperties(JsonElement element)
        {
            RouteConfigurationOverrideActionType typeName = default;
            Optional<OriginGroupOverride> originGroupOverride = default;
            Optional<CacheConfiguration> cacheConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new RouteConfigurationOverrideActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroupOverride"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        originGroupOverride = null;
                        continue;
                    }
                    originGroupOverride = OriginGroupOverride.DeserializeOriginGroupOverride(property.Value);
                    continue;
                }
                if (property.NameEquals("cacheConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cacheConfiguration = CacheConfiguration.DeserializeCacheConfiguration(property.Value);
                    continue;
                }
            }
            return new RouteConfigurationOverrideActionProperties(typeName, originGroupOverride.Value, cacheConfiguration.Value);
        }
    }
}
