// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class FarmBeatsExtensionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FarmBeatsExtensionData DeserializeFarmBeatsExtensionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> targetResourceType = default;
            Optional<string> farmBeatsExtensionId = default;
            Optional<string> farmBeatsExtensionName = default;
            Optional<string> farmBeatsExtensionVersion = default;
            Optional<string> publisherId = default;
            Optional<string> description = default;
            Optional<string> extensionCategory = default;
            Optional<string> extensionAuthLink = default;
            Optional<string> extensionApiDocsLink = default;
            Optional<IReadOnlyList<DetailedInformation>> detailedInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetResourceType"))
                        {
                            targetResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionId"))
                        {
                            farmBeatsExtensionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionName"))
                        {
                            farmBeatsExtensionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionVersion"))
                        {
                            farmBeatsExtensionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionCategory"))
                        {
                            extensionCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionAuthLink"))
                        {
                            extensionAuthLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionApiDocsLink"))
                        {
                            extensionApiDocsLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detailedInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DetailedInformation> array = new List<DetailedInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.DetailedInformation.DeserializeDetailedInformation(item));
                            }
                            detailedInformation = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FarmBeatsExtensionData(id, name, type, systemData.Value, targetResourceType.Value, farmBeatsExtensionId.Value, farmBeatsExtensionName.Value, farmBeatsExtensionVersion.Value, publisherId.Value, description.Value, extensionCategory.Value, extensionAuthLink.Value, extensionApiDocsLink.Value, Optional.ToList(detailedInformation));
        }
    }
}
