// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareRelationEntity. </summary>
    internal partial class HealthcareRelationEntity
    {
        /// <summary> Initializes a new instance of HealthcareRelationEntity. </summary>
        /// <param name="ref"> Reference link object, using a JSON pointer RFC 6901 (URI Fragment Identifier Representation), pointing to the entity . </param>
        /// <param name="role"> Role of entity in the relationship. For example: 'CD20-positive diffuse large B-cell lymphoma' has the following entities with their roles in parenthesis:  CD20 (GeneOrProtein), Positive (Expression), diffuse large B-cell lymphoma (Diagnosis). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ref"/> or <paramref name="role"/> is null. </exception>
        public HealthcareRelationEntity(string @ref, string role)
        {
            Argument.AssertNotNull(@ref, nameof(@ref));
            Argument.AssertNotNull(role, nameof(role));

            Ref = @ref;
            Role = role;
        }

        /// <summary> Reference link object, using a JSON pointer RFC 6901 (URI Fragment Identifier Representation), pointing to the entity . </summary>
        public string Ref { get; set; }
        /// <summary> Role of entity in the relationship. For example: 'CD20-positive diffuse large B-cell lymphoma' has the following entities with their roles in parenthesis:  CD20 (GeneOrProtein), Positive (Expression), diffuse large B-cell lymphoma (Diagnosis). </summary>
        public string Role { get; set; }
    }
}
