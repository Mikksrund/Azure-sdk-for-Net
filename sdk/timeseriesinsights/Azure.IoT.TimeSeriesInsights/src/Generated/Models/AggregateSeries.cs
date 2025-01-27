// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Aggregate Series query. Allows to calculate an aggregated time series from events for a given Time Series ID and search span. </summary>
    internal partial class AggregateSeries
    {
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND&apos;ed with filter in each variable. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Interval size is specified in ISO-8601 duration format. All intervals are the same size. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is &quot;PT1M&quot;, 1 millisecond is &quot;PT0.001S&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration. </summary>
        public TimeSpan Interval { get; }
        /// <summary> This allows the user to optionally select the variables that needs to be projected. When it is null or not set, all the variables from inlineVariables and model are returned. Can be null. </summary>
        public IList<string> ProjectedVariables { get; }
        /// <summary>
        /// This allows the user the optionally define inline-variables apart from the ones already defined in the model. When the inline variable names have the same name as the model, the inline variable definition takes precedence. Can be null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </summary>
        public IDictionary<string, TimeSeriesVariable> InlineVariables { get; }
    }
}
