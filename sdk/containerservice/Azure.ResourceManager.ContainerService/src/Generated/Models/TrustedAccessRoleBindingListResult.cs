// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> List of trusted access role bindings. </summary>
    internal partial class TrustedAccessRoleBindingListResult
    {
        /// <summary> Initializes a new instance of TrustedAccessRoleBindingListResult. </summary>
        internal TrustedAccessRoleBindingListResult()
        {
            Value = new ChangeTrackingList<ContainerServiceTrustedAccessRoleBindingData>();
        }

        /// <summary> Initializes a new instance of TrustedAccessRoleBindingListResult. </summary>
        /// <param name="value"> Role binding list. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal TrustedAccessRoleBindingListResult(IReadOnlyList<ContainerServiceTrustedAccessRoleBindingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role binding list. </summary>
        public IReadOnlyList<ContainerServiceTrustedAccessRoleBindingData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
