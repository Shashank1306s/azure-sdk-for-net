// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App's Job execution name. </summary>
    public partial class ContainerAppJobExecutionBase
    {
        /// <summary> Initializes a new instance of ContainerAppJobExecutionBase. </summary>
        internal ContainerAppJobExecutionBase()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppJobExecutionBase. </summary>
        /// <param name="name"> Job execution name. </param>
        /// <param name="id"> Job execution Id. </param>
        internal ContainerAppJobExecutionBase(string name, string id)
        {
            Name = name;
            Id = id;
        }

        /// <summary> Job execution name. </summary>
        public string Name { get; }
        /// <summary> Job execution Id. </summary>
        public string Id { get; }
    }
}
