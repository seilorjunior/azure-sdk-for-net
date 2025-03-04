// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class MdeOnboardingDataList
    {
        internal static MdeOnboardingDataList DeserializeMdeOnboardingDataList(JsonElement element)
        {
            Optional<IReadOnlyList<MdeOnboardingDataData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MdeOnboardingDataData> array = new List<MdeOnboardingDataData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MdeOnboardingDataData.DeserializeMdeOnboardingDataData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MdeOnboardingDataList(Optional.ToList(value));
        }
    }
}
