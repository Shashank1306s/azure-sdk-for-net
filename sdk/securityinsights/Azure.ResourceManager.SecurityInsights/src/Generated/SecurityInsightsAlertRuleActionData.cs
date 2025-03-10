// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsAlertRuleAction data model.
    /// Action for alert rule.
    /// </summary>
    public partial class SecurityInsightsAlertRuleActionData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleActionData. </summary>
        public SecurityInsightsAlertRuleActionData()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleActionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Etag of the action. </param>
        /// <param name="logicAppResourceId"> Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}. </param>
        /// <param name="workflowId"> The name of the logic app's workflow. </param>
        internal SecurityInsightsAlertRuleActionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, ResourceIdentifier logicAppResourceId, string workflowId) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            LogicAppResourceId = logicAppResourceId;
            WorkflowId = workflowId;
        }

        /// <summary> Etag of the action. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}. </summary>
        public ResourceIdentifier LogicAppResourceId { get; set; }
        /// <summary> The name of the logic app's workflow. </summary>
        public string WorkflowId { get; set; }
    }
}
