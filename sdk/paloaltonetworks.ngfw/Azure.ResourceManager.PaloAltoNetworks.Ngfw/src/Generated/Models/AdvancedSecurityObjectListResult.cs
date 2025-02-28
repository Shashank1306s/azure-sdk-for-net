// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> advanced security object. </summary>
    public partial class AdvancedSecurityObjectListResult
    {
        /// <summary> Initializes a new instance of AdvancedSecurityObjectListResult. </summary>
        /// <param name="value"> response value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AdvancedSecurityObjectListResult(AdvancedSecurityObject value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of AdvancedSecurityObjectListResult. </summary>
        /// <param name="value"> response value. </param>
        /// <param name="nextLink"> next link. </param>
        internal AdvancedSecurityObjectListResult(AdvancedSecurityObject value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> response value. </summary>
        public AdvancedSecurityObject Value { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
    }
}
