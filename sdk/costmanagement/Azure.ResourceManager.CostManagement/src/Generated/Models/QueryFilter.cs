// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The filter expression to be used in the export. </summary>
    public partial class QueryFilter
    {
        /// <summary> Initializes a new instance of QueryFilter. </summary>
        public QueryFilter()
        {
            And = new ChangeTrackingList<QueryFilter>();
            Or = new ChangeTrackingList<QueryFilter>();
        }

        /// <summary> The logical "AND" expression. Must have at least 2 items. </summary>
        public IList<QueryFilter> And { get; }
        /// <summary> The logical "OR" expression. Must have at least 2 items. </summary>
        public IList<QueryFilter> Or { get; }
        /// <summary> Has comparison expression for a dimension. </summary>
        public QueryComparisonExpression Dimensions { get; set; }
        /// <summary> Has comparison expression for a tag. </summary>
        public QueryComparisonExpression Tags { get; set; }
    }
}
