// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// Result of listing lot summary.
    /// Serialized Name: Lots
    /// </summary>
    internal partial class Lots
    {
        /// <summary> Initializes a new instance of Lots. </summary>
        internal Lots()
        {
            Value = new ChangeTrackingList<ConsumptionLotSummary>();
        }

        /// <summary> Initializes a new instance of Lots. </summary>
        /// <param name="value">
        /// The list of lot summary.
        /// Serialized Name: Lots.value
        /// </param>
        /// <param name="nextLink">
        /// The link (url) to the next page of results.
        /// Serialized Name: Lots.nextLink
        /// </param>
        internal Lots(IReadOnlyList<ConsumptionLotSummary> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of lot summary.
        /// Serialized Name: Lots.value
        /// </summary>
        public IReadOnlyList<ConsumptionLotSummary> Value { get; }
        /// <summary>
        /// The link (url) to the next page of results.
        /// Serialized Name: Lots.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
