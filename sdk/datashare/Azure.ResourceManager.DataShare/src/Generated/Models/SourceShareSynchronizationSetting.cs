// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary>
    /// A view of synchronization setting added by the provider
    /// Please note <see cref="SourceShareSynchronizationSetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ScheduledSourceSynchronizationSetting"/>.
    /// </summary>
    public abstract partial class SourceShareSynchronizationSetting
    {
        /// <summary> Initializes a new instance of SourceShareSynchronizationSetting. </summary>
        protected SourceShareSynchronizationSetting()
        {
        }

        /// <summary> Initializes a new instance of SourceShareSynchronizationSetting. </summary>
        /// <param name="kind"> Kind of synchronization setting on share. </param>
        internal SourceShareSynchronizationSetting(SourceShareSynchronizationSettingKind kind)
        {
            Kind = kind;
        }

        /// <summary> Kind of synchronization setting on share. </summary>
        internal SourceShareSynchronizationSettingKind Kind { get; set; }
    }
}
