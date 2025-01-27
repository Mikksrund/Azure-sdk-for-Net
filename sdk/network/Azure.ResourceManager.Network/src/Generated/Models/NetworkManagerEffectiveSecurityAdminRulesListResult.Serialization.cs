// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkManagerEffectiveSecurityAdminRulesListResult
    {
        internal static NetworkManagerEffectiveSecurityAdminRulesListResult DeserializeNetworkManagerEffectiveSecurityAdminRulesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EffectiveBaseSecurityAdminRule>> value = default;
            Optional<string> skipToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveBaseSecurityAdminRule> array = new List<EffectiveBaseSecurityAdminRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveBaseSecurityAdminRule.DeserializeEffectiveBaseSecurityAdminRule(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkManagerEffectiveSecurityAdminRulesListResult(Optional.ToList(value), skipToken.Value);
        }
    }
}
