// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class Error : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code");
            writer.WriteStringValue(Code.ToString());
            writer.WritePropertyName("message");
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details");
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Innererror))
            {
                writer.WritePropertyName("innererror");
                writer.WriteObjectValue(Innererror);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Error DeserializeError(JsonElement element)
        {
            ErrorCode code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IList<Error>> details = default;
            Optional<InnerErrorModel> innererror = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = new ErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Error> array = new List<Error>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innererror = InnerErrorModel.DeserializeInnerErrorModel(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Error(code, message, target.Value, Optional.ToList(details), innererror.Value, additionalProperties);
        }
    }
}
