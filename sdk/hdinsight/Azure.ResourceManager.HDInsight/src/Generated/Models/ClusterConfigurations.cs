// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The configuration object for the specified cluster. </summary>
    public partial class ClusterConfigurations
    {
        /// <summary> Initializes a new instance of ClusterConfigurations. </summary>
        internal ClusterConfigurations()
        {
            Configurations = new ChangeTrackingDictionary<string, IDictionary<string, string>>();
        }

        /// <summary> Initializes a new instance of ClusterConfigurations. </summary>
        /// <param name="configurations"> The configuration object for the specified configuration for the specified cluster. </param>
        internal ClusterConfigurations(IReadOnlyDictionary<string, IDictionary<string, string>> configurations)
        {
            Configurations = configurations;
        }

        /// <summary> The configuration object for the specified configuration for the specified cluster. </summary>
        public IReadOnlyDictionary<string, IDictionary<string, string>> Configurations { get; }
    }
}
