// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    public partial class FeatureValidationResponse
    {
        internal static FeatureValidationResponse DeserializeFeatureValidationResponse(JsonElement element)
        {
            Optional<FeatureType> featureType = default;
            Optional<IReadOnlyList<SupportedFeature>> features = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    featureType = new FeatureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("features"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportedFeature> array = new List<SupportedFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedFeature.DeserializeSupportedFeature(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new FeatureValidationResponse(objectType, Optional.ToNullable(featureType), Optional.ToList(features));
        }
    }
}
