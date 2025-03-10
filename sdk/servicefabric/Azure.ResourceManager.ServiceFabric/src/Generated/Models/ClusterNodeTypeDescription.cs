// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes a node type in the cluster, each node type represents sub set of nodes in the cluster. </summary>
    public partial class ClusterNodeTypeDescription
    {
        /// <summary> Initializes a new instance of ClusterNodeTypeDescription. </summary>
        /// <param name="name"> The name of the node type. </param>
        /// <param name="clientConnectionEndpointPort"> The TCP cluster management endpoint port. </param>
        /// <param name="httpGatewayEndpointPort"> The HTTP cluster management endpoint port. </param>
        /// <param name="isPrimary"> The node type on which system services will run. Only one node type should be marked as primary. Primary node type cannot be deleted or changed for existing clusters. </param>
        /// <param name="vmInstanceCount"> VMInstanceCount should be 1 to n, where n indicates the number of VM instances corresponding to this nodeType. VMInstanceCount = 0 can be done only in these scenarios: NodeType is a secondary nodeType. Durability = Bronze or Durability &gt;= Bronze and InfrastructureServiceManager = true. If VMInstanceCount = 0, implies the VMs for this nodeType will not be used for the initial cluster size computation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ClusterNodeTypeDescription(string name, int clientConnectionEndpointPort, int httpGatewayEndpointPort, bool isPrimary, int vmInstanceCount)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            PlacementProperties = new ChangeTrackingDictionary<string, string>();
            Capacities = new ChangeTrackingDictionary<string, string>();
            ClientConnectionEndpointPort = clientConnectionEndpointPort;
            HttpGatewayEndpointPort = httpGatewayEndpointPort;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
        }

        /// <summary> Initializes a new instance of ClusterNodeTypeDescription. </summary>
        /// <param name="name"> The name of the node type. </param>
        /// <param name="placementProperties"> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </param>
        /// <param name="capacities"> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </param>
        /// <param name="clientConnectionEndpointPort"> The TCP cluster management endpoint port. </param>
        /// <param name="httpGatewayEndpointPort"> The HTTP cluster management endpoint port. </param>
        /// <param name="durabilityLevel">
        /// The durability level of the node type. Learn about [DurabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        /// 
        ///   - Bronze - No privileges. This is the default.
        ///   - Silver - The infrastructure jobs can be paused for a duration of 10 minutes per UD.
        ///   - Gold - The infrastructure jobs can be paused for a duration of 2 hours per UD. Gold durability can be enabled only on full node VM skus like D15_V2, G5 etc.
        /// 
        /// </param>
        /// <param name="applicationPorts"> The range of ports from which cluster assigned port to Service Fabric applications. </param>
        /// <param name="ephemeralPorts"> The range of ephemeral ports that nodes in this node type should be configured with. </param>
        /// <param name="isPrimary"> The node type on which system services will run. Only one node type should be marked as primary. Primary node type cannot be deleted or changed for existing clusters. </param>
        /// <param name="vmInstanceCount"> VMInstanceCount should be 1 to n, where n indicates the number of VM instances corresponding to this nodeType. VMInstanceCount = 0 can be done only in these scenarios: NodeType is a secondary nodeType. Durability = Bronze or Durability &gt;= Bronze and InfrastructureServiceManager = true. If VMInstanceCount = 0, implies the VMs for this nodeType will not be used for the initial cluster size computation. </param>
        /// <param name="reverseProxyEndpointPort"> The endpoint used by reverse proxy. </param>
        /// <param name="isStateless"> Indicates if the node type can only host Stateless workloads. </param>
        /// <param name="isMultipleAvailabilityZonesSupported"> Indicates if the node type is enabled to support multiple zones. </param>
        internal ClusterNodeTypeDescription(string name, IDictionary<string, string> placementProperties, IDictionary<string, string> capacities, int clientConnectionEndpointPort, int httpGatewayEndpointPort, ClusterDurabilityLevel? durabilityLevel, ClusterEndpointRangeDescription applicationPorts, ClusterEndpointRangeDescription ephemeralPorts, bool isPrimary, int vmInstanceCount, int? reverseProxyEndpointPort, bool? isStateless, bool? isMultipleAvailabilityZonesSupported)
        {
            Name = name;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ClientConnectionEndpointPort = clientConnectionEndpointPort;
            HttpGatewayEndpointPort = httpGatewayEndpointPort;
            DurabilityLevel = durabilityLevel;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            ReverseProxyEndpointPort = reverseProxyEndpointPort;
            IsStateless = isStateless;
            IsMultipleAvailabilityZonesSupported = isMultipleAvailabilityZonesSupported;
        }

        /// <summary> The name of the node type. </summary>
        public string Name { get; set; }
        /// <summary> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </summary>
        public IDictionary<string, string> PlacementProperties { get; }
        /// <summary> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </summary>
        public IDictionary<string, string> Capacities { get; }
        /// <summary> The TCP cluster management endpoint port. </summary>
        public int ClientConnectionEndpointPort { get; set; }
        /// <summary> The HTTP cluster management endpoint port. </summary>
        public int HttpGatewayEndpointPort { get; set; }
        /// <summary>
        /// The durability level of the node type. Learn about [DurabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        /// 
        ///   - Bronze - No privileges. This is the default.
        ///   - Silver - The infrastructure jobs can be paused for a duration of 10 minutes per UD.
        ///   - Gold - The infrastructure jobs can be paused for a duration of 2 hours per UD. Gold durability can be enabled only on full node VM skus like D15_V2, G5 etc.
        /// 
        /// </summary>
        public ClusterDurabilityLevel? DurabilityLevel { get; set; }
        /// <summary> The range of ports from which cluster assigned port to Service Fabric applications. </summary>
        public ClusterEndpointRangeDescription ApplicationPorts { get; set; }
        /// <summary> The range of ephemeral ports that nodes in this node type should be configured with. </summary>
        public ClusterEndpointRangeDescription EphemeralPorts { get; set; }
        /// <summary> The node type on which system services will run. Only one node type should be marked as primary. Primary node type cannot be deleted or changed for existing clusters. </summary>
        public bool IsPrimary { get; set; }
        /// <summary> VMInstanceCount should be 1 to n, where n indicates the number of VM instances corresponding to this nodeType. VMInstanceCount = 0 can be done only in these scenarios: NodeType is a secondary nodeType. Durability = Bronze or Durability &gt;= Bronze and InfrastructureServiceManager = true. If VMInstanceCount = 0, implies the VMs for this nodeType will not be used for the initial cluster size computation. </summary>
        public int VmInstanceCount { get; set; }
        /// <summary> The endpoint used by reverse proxy. </summary>
        public int? ReverseProxyEndpointPort { get; set; }
        /// <summary> Indicates if the node type can only host Stateless workloads. </summary>
        public bool? IsStateless { get; set; }
        /// <summary> Indicates if the node type is enabled to support multiple zones. </summary>
        public bool? IsMultipleAvailabilityZonesSupported { get; set; }
    }
}
