// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// Legacy reservation recommendation.
    /// Serialized Name: LegacyReservationRecommendation
    /// </summary>
    public partial class ConsumptionLegacyReservationRecommendation : ConsumptionReservationRecommendation
    {
        /// <summary> Initializes a new instance of ConsumptionLegacyReservationRecommendation. </summary>
        /// <param name="scope">
        /// Shared or single recommendation.
        /// Serialized Name: LegacyReservationRecommendation.properties.scope
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        internal ConsumptionLegacyReservationRecommendation(string scope)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            Scope = scope;
            SkuProperties = new ChangeTrackingList<ConsumptionSkuProperty>();
            Kind = ReservationRecommendationKind.Legacy;
        }

        /// <summary> Initializes a new instance of ConsumptionLegacyReservationRecommendation. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// Specifies the kind of reservation recommendation.
        /// Serialized Name: ReservationRecommendation.kind
        /// </param>
        /// <param name="etag">
        /// The etag for the resource.
        /// Serialized Name: Resource.etag
        /// </param>
        /// <param name="tags">
        /// Resource tags.
        /// Serialized Name: Resource.tags
        /// </param>
        /// <param name="location">
        /// Resource location
        /// Serialized Name: ResourceAttributes.location
        /// </param>
        /// <param name="sku">
        /// Resource sku
        /// Serialized Name: ResourceAttributes.sku
        /// </param>
        /// <param name="lookBackPeriod">
        /// The number of days of usage to look back for recommendation.
        /// Serialized Name: LegacyReservationRecommendation.properties.lookBackPeriod
        /// </param>
        /// <param name="instanceFlexibilityRatio">
        /// The instance Flexibility Ratio.
        /// Serialized Name: LegacyReservationRecommendation.properties.instanceFlexibilityRatio
        /// </param>
        /// <param name="instanceFlexibilityGroup">
        /// The instance Flexibility Group.
        /// Serialized Name: LegacyReservationRecommendation.properties.instanceFlexibilityGroup
        /// </param>
        /// <param name="normalizedSize">
        /// The normalized Size.
        /// Serialized Name: LegacyReservationRecommendation.properties.normalizedSize
        /// </param>
        /// <param name="recommendedQuantityNormalized">
        /// The recommended Quantity Normalized.
        /// Serialized Name: LegacyReservationRecommendation.properties.recommendedQuantityNormalized
        /// </param>
        /// <param name="meterId">
        /// The meter id (GUID)
        /// Serialized Name: LegacyReservationRecommendation.properties.meterId
        /// </param>
        /// <param name="term">
        /// RI recommendations in one or three year terms.
        /// Serialized Name: LegacyReservationRecommendation.properties.term
        /// </param>
        /// <param name="costWithNoReservedInstances">
        /// The total amount of cost without reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.costWithNoReservedInstances
        /// </param>
        /// <param name="recommendedQuantity">
        /// Recommended quality for reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.recommendedQuantity
        /// </param>
        /// <param name="totalCostWithReservedInstances">
        /// The total amount of cost with reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.totalCostWithReservedInstances
        /// </param>
        /// <param name="netSavings">
        /// Total estimated savings with reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.netSavings
        /// </param>
        /// <param name="firstUsageOn">
        /// The usage date for looking back.
        /// Serialized Name: LegacyReservationRecommendation.properties.firstUsageDate
        /// </param>
        /// <param name="scope">
        /// Shared or single recommendation.
        /// Serialized Name: LegacyReservationRecommendation.properties.scope
        /// </param>
        /// <param name="skuProperties">
        /// List of sku properties
        /// Serialized Name: LegacyReservationRecommendation.properties.skuProperties
        /// </param>
        internal ConsumptionLegacyReservationRecommendation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ReservationRecommendationKind kind, ETag? etag, IReadOnlyDictionary<string, string> tags, AzureLocation? location, string sku, string lookBackPeriod, float? instanceFlexibilityRatio, string instanceFlexibilityGroup, string normalizedSize, float? recommendedQuantityNormalized, Guid? meterId, string term, decimal? costWithNoReservedInstances, decimal? recommendedQuantity, decimal? totalCostWithReservedInstances, decimal? netSavings, DateTimeOffset? firstUsageOn, string scope, IReadOnlyList<ConsumptionSkuProperty> skuProperties) : base(id, name, resourceType, systemData, kind, etag, tags, location, sku)
        {
            LookBackPeriod = lookBackPeriod;
            InstanceFlexibilityRatio = instanceFlexibilityRatio;
            InstanceFlexibilityGroup = instanceFlexibilityGroup;
            NormalizedSize = normalizedSize;
            RecommendedQuantityNormalized = recommendedQuantityNormalized;
            MeterId = meterId;
            Term = term;
            CostWithNoReservedInstances = costWithNoReservedInstances;
            RecommendedQuantity = recommendedQuantity;
            TotalCostWithReservedInstances = totalCostWithReservedInstances;
            NetSavings = netSavings;
            FirstUsageOn = firstUsageOn;
            Scope = scope;
            SkuProperties = skuProperties;
            Kind = kind;
        }

        /// <summary>
        /// The number of days of usage to look back for recommendation.
        /// Serialized Name: LegacyReservationRecommendation.properties.lookBackPeriod
        /// </summary>
        public string LookBackPeriod { get; }
        /// <summary>
        /// The instance Flexibility Ratio.
        /// Serialized Name: LegacyReservationRecommendation.properties.instanceFlexibilityRatio
        /// </summary>
        public float? InstanceFlexibilityRatio { get; }
        /// <summary>
        /// The instance Flexibility Group.
        /// Serialized Name: LegacyReservationRecommendation.properties.instanceFlexibilityGroup
        /// </summary>
        public string InstanceFlexibilityGroup { get; }
        /// <summary>
        /// The normalized Size.
        /// Serialized Name: LegacyReservationRecommendation.properties.normalizedSize
        /// </summary>
        public string NormalizedSize { get; }
        /// <summary>
        /// The recommended Quantity Normalized.
        /// Serialized Name: LegacyReservationRecommendation.properties.recommendedQuantityNormalized
        /// </summary>
        public float? RecommendedQuantityNormalized { get; }
        /// <summary>
        /// The meter id (GUID)
        /// Serialized Name: LegacyReservationRecommendation.properties.meterId
        /// </summary>
        public Guid? MeterId { get; }
        /// <summary>
        /// RI recommendations in one or three year terms.
        /// Serialized Name: LegacyReservationRecommendation.properties.term
        /// </summary>
        public string Term { get; }
        /// <summary>
        /// The total amount of cost without reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.costWithNoReservedInstances
        /// </summary>
        public decimal? CostWithNoReservedInstances { get; }
        /// <summary>
        /// Recommended quality for reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.recommendedQuantity
        /// </summary>
        public decimal? RecommendedQuantity { get; }
        /// <summary>
        /// The total amount of cost with reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.totalCostWithReservedInstances
        /// </summary>
        public decimal? TotalCostWithReservedInstances { get; }
        /// <summary>
        /// Total estimated savings with reserved instances.
        /// Serialized Name: LegacyReservationRecommendation.properties.netSavings
        /// </summary>
        public decimal? NetSavings { get; }
        /// <summary>
        /// The usage date for looking back.
        /// Serialized Name: LegacyReservationRecommendation.properties.firstUsageDate
        /// </summary>
        public DateTimeOffset? FirstUsageOn { get; }
        /// <summary>
        /// Shared or single recommendation.
        /// Serialized Name: LegacyReservationRecommendation.properties.scope
        /// </summary>
        internal string Scope { get; set; }
        /// <summary>
        /// List of sku properties
        /// Serialized Name: LegacyReservationRecommendation.properties.skuProperties
        /// </summary>
        public IReadOnlyList<ConsumptionSkuProperty> SkuProperties { get; }
    }
}
