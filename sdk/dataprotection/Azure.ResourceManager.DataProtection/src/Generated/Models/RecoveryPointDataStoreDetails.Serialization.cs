// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtection.Models
{
    public partial class RecoveryPointDataStoreDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime");
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime");
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(MetaData))
            {
                writer.WritePropertyName("metaData");
                writer.WriteStringValue(MetaData);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(RecoveryPointDataStoreDetailsType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(RecoveryPointDataStoreDetailsType);
            }
            if (Optional.IsDefined(Visible))
            {
                writer.WritePropertyName("visible");
                writer.WriteBooleanValue(Visible.Value);
            }
            writer.WriteEndObject();
        }

        internal static RecoveryPointDataStoreDetails DeserializeRecoveryPointDataStoreDetails(JsonElement element)
        {
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<string> id = default;
            Optional<string> metaData = default;
            Optional<string> state = default;
            Optional<string> type = default;
            Optional<bool> visible = default;
            Optional<DateTimeOffset> rehydrationExpiryTime = default;
            Optional<RehydrationStatus> rehydrationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metaData"))
                {
                    metaData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visible"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    visible = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rehydrationExpiryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rehydrationExpiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rehydrationStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rehydrationStatus = new RehydrationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new RecoveryPointDataStoreDetails(Optional.ToNullable(creationTime), Optional.ToNullable(expiryTime), id.Value, metaData.Value, state.Value, type.Value, Optional.ToNullable(visible), Optional.ToNullable(rehydrationExpiryTime), Optional.ToNullable(rehydrationStatus));
        }
    }
}
