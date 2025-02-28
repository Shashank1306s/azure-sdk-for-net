// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the DataShareSynchronizationSetting data model.
    /// A Synchronization Setting data transfer object.
    /// Please note <see cref="DataShareSynchronizationSettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ScheduledSynchronizationSetting"/>.
    /// </summary>
    public partial class DataShareSynchronizationSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of DataShareSynchronizationSettingData. </summary>
        public DataShareSynchronizationSettingData()
        {
        }

        /// <summary> Initializes a new instance of DataShareSynchronizationSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of synchronization setting. </param>
        internal DataShareSynchronizationSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SynchronizationSettingKind kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Kind of synchronization setting. </summary>
        internal SynchronizationSettingKind Kind { get; set; }
    }
}
