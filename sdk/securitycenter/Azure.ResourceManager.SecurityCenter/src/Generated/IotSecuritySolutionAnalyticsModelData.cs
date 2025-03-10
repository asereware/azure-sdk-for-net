// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the IotSecuritySolutionAnalyticsModel data model. </summary>
    public partial class IotSecuritySolutionAnalyticsModelData : ResourceData
    {
        /// <summary> Initializes a new instance of IotSecuritySolutionAnalyticsModelData. </summary>
        public IotSecuritySolutionAnalyticsModelData()
        {
            DevicesMetrics = new ChangeTrackingList<IotSecuritySolutionAnalyticsModelPropertiesDevicesMetricsItem>();
            TopAlertedDevices = new ChangeTrackingList<IotSecurityAlertedDevice>();
            MostPrevalentDeviceAlerts = new ChangeTrackingList<IotSecurityDeviceAlert>();
            MostPrevalentDeviceRecommendations = new ChangeTrackingList<IotSecurityDeviceRecommendation>();
        }

        /// <summary> Initializes a new instance of IotSecuritySolutionAnalyticsModelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="metrics"> Security analytics of your IoT Security solution. </param>
        /// <param name="unhealthyDeviceCount"> Number of unhealthy devices within your IoT Security solution. </param>
        /// <param name="devicesMetrics"> List of device metrics by the aggregation date. </param>
        /// <param name="topAlertedDevices"> List of the 3 devices with the most alerts. </param>
        /// <param name="mostPrevalentDeviceAlerts"> List of the 3 most prevalent device alerts. </param>
        /// <param name="mostPrevalentDeviceRecommendations"> List of the 3 most prevalent device recommendations. </param>
        internal IotSecuritySolutionAnalyticsModelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IotSeverityMetrics metrics, long? unhealthyDeviceCount, IReadOnlyList<IotSecuritySolutionAnalyticsModelPropertiesDevicesMetricsItem> devicesMetrics, IList<IotSecurityAlertedDevice> topAlertedDevices, IList<IotSecurityDeviceAlert> mostPrevalentDeviceAlerts, IList<IotSecurityDeviceRecommendation> mostPrevalentDeviceRecommendations) : base(id, name, resourceType, systemData)
        {
            Metrics = metrics;
            UnhealthyDeviceCount = unhealthyDeviceCount;
            DevicesMetrics = devicesMetrics;
            TopAlertedDevices = topAlertedDevices;
            MostPrevalentDeviceAlerts = mostPrevalentDeviceAlerts;
            MostPrevalentDeviceRecommendations = mostPrevalentDeviceRecommendations;
        }

        /// <summary> Security analytics of your IoT Security solution. </summary>
        public IotSeverityMetrics Metrics { get; }
        /// <summary> Number of unhealthy devices within your IoT Security solution. </summary>
        public long? UnhealthyDeviceCount { get; }
        /// <summary> List of device metrics by the aggregation date. </summary>
        public IReadOnlyList<IotSecuritySolutionAnalyticsModelPropertiesDevicesMetricsItem> DevicesMetrics { get; }
        /// <summary> List of the 3 devices with the most alerts. </summary>
        public IList<IotSecurityAlertedDevice> TopAlertedDevices { get; }
        /// <summary> List of the 3 most prevalent device alerts. </summary>
        public IList<IotSecurityDeviceAlert> MostPrevalentDeviceAlerts { get; }
        /// <summary> List of the 3 most prevalent device recommendations. </summary>
        public IList<IotSecurityDeviceRecommendation> MostPrevalentDeviceRecommendations { get; }
    }
}
