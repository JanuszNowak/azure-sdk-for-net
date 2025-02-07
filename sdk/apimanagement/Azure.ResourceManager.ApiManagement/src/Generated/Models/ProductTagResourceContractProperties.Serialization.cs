// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ProductTagResourceContractProperties
    {
        internal static ProductTagResourceContractProperties DeserializeProductTagResourceContractProperties(JsonElement element)
        {
            Optional<string> id = default;
            string name = default;
            Optional<string> description = default;
            Optional<string> terms = default;
            Optional<bool> subscriptionRequired = default;
            Optional<bool> approvalRequired = default;
            Optional<int> subscriptionsLimit = default;
            Optional<ProductState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terms"))
                {
                    terms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("approvalRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    approvalRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionsLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = property.Value.GetString().ToProductState();
                    continue;
                }
            }
            return new ProductTagResourceContractProperties(description.Value, terms.Value, Optional.ToNullable(subscriptionRequired), Optional.ToNullable(approvalRequired), Optional.ToNullable(subscriptionsLimit), Optional.ToNullable(state), id.Value, name);
        }
    }
}
