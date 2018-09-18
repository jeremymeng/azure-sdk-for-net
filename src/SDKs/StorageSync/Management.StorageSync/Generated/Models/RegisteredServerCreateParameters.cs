// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a storage sync service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RegisteredServerCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegisteredServerCreateParameters
        /// class.
        /// </summary>
        public RegisteredServerCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegisteredServerCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">Required. Gets or sets the location of the
        /// resource. This will be one of the supported and registered Azure
        /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo
        /// region of a resource cannot be changed once it is created, but if
        /// an identical geo region is specified on update, the request will
        /// succeed.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used for viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key with
        /// a length no greater than 128 characters and a value with a length
        /// no greater than 256 characters.</param>
        /// <param name="serverCertificate">Registered Server
        /// Certificate</param>
        /// <param name="agentVersion">Registered Server Agent Version</param>
        /// <param name="serverOSVersion">Registered Server OS Version</param>
        /// <param name="lastHeartBeat">Registered Server last heart
        /// beat</param>
        /// <param name="serverRole">Registered Server serverRole</param>
        /// <param name="clusterId">Registered Server clusterId</param>
        /// <param name="clusterName">Registered Server clusterName</param>
        /// <param name="serverId">Registered Server serverId</param>
        /// <param name="friendlyName">Friendly Name</param>
        public RegisteredServerCreateParameters(string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string serverCertificate = default(string), string agentVersion = default(string), string serverOSVersion = default(string), string lastHeartBeat = default(string), string serverRole = default(string), string clusterId = default(string), string clusterName = default(string), string serverId = default(string), string friendlyName = default(string))
        {
            Location = location;
            Tags = tags;
            ServerCertificate = serverCertificate;
            AgentVersion = agentVersion;
            ServerOSVersion = serverOSVersion;
            LastHeartBeat = lastHeartBeat;
            ServerRole = serverRole;
            ClusterId = clusterId;
            ClusterName = clusterName;
            ServerId = serverId;
            FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. Gets or sets the location of the resource.
        /// This will be one of the supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.). The geo region of a
        /// resource cannot be changed once it is created, but if an identical
        /// geo region is specified on update, the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used for viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key with a length no greater than
        /// 128 characters and a value with a length no greater than 256
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets registered Server Certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverCertificate")]
        public string ServerCertificate { get; set; }

        /// <summary>
        /// Gets or sets registered Server Agent Version
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets registered Server OS Version
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverOSVersion")]
        public string ServerOSVersion { get; set; }

        /// <summary>
        /// Gets or sets registered Server last heart beat
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastHeartBeat")]
        public string LastHeartBeat { get; set; }

        /// <summary>
        /// Gets or sets registered Server serverRole
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverRole")]
        public string ServerRole { get; set; }

        /// <summary>
        /// Gets or sets registered Server clusterId
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterId")]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets registered Server clusterName
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterName")]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or sets registered Server serverId
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverId")]
        public string ServerId { get; set; }

        /// <summary>
        /// Gets or sets friendly Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

    }
}