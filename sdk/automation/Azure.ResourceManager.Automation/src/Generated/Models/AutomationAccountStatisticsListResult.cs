// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list statistics operation. </summary>
    internal partial class AutomationAccountStatisticsListResult
    {
        /// <summary> Initializes a new instance of AutomationAccountStatisticsListResult. </summary>
        internal AutomationAccountStatisticsListResult()
        {
            Value = new ChangeTrackingList<AutomationAccountStatistics>();
        }

        /// <summary> Initializes a new instance of AutomationAccountStatisticsListResult. </summary>
        /// <param name="value"> Gets or sets a list of statistics. </param>
        internal AutomationAccountStatisticsListResult(IReadOnlyList<AutomationAccountStatistics> value)
        {
            Value = value;
        }

        /// <summary> Gets or sets a list of statistics. </summary>
        public IReadOnlyList<AutomationAccountStatistics> Value { get; }
    }
}
