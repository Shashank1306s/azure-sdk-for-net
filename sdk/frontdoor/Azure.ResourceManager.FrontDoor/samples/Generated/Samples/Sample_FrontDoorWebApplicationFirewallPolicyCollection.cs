// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.FrontDoor;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor.Samples
{
    public partial class Sample_FrontDoorWebApplicationFirewallPolicyCollection
    {
        // Get all Policies in a Resource Group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllPoliciesInAResourceGroup()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/examples/WafListPolicies.json
            // this example is just showing the usage of "Policies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FrontDoorWebApplicationFirewallPolicyResource
            FrontDoorWebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorWebApplicationFirewallPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorWebApplicationFirewallPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPolicy()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/examples/WafPolicyGet.json
            // this example is just showing the usage of "Policies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FrontDoorWebApplicationFirewallPolicyResource
            FrontDoorWebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            FrontDoorWebApplicationFirewallPolicyResource result = await collection.GetAsync(policyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorWebApplicationFirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPolicy()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/examples/WafPolicyGet.json
            // this example is just showing the usage of "Policies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FrontDoorWebApplicationFirewallPolicyResource
            FrontDoorWebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            bool result = await collection.ExistsAsync(policyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Creates specific policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesSpecificPolicy()
        {
            // Generated from example definition: specification/frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/examples/WafPolicyCreateOrUpdate.json
            // this example is just showing the usage of "Policies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FrontDoorWebApplicationFirewallPolicyResource
            FrontDoorWebApplicationFirewallPolicyCollection collection = resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies();

            // invoke the operation
            string policyName = "Policy1";
            FrontDoorWebApplicationFirewallPolicyData data = new FrontDoorWebApplicationFirewallPolicyData(new AzureLocation("placeholder"))
            {
                SkuName = FrontDoorSkuName.ClassicAzureFrontDoor,
                PolicySettings = new FrontDoorWebApplicationFirewallPolicySettings()
                {
                    EnabledState = PolicyEnabledState.Enabled,
                    Mode = FrontDoorWebApplicationFirewallPolicyMode.Prevention,
                    RedirectUri = new Uri("http://www.bing.com"),
                    CustomBlockResponseStatusCode = 499,
                    CustomBlockResponseBody = "PGh0bWw+CjxoZWFkZXI+PHRpdGxlPkhlbGxvPC90aXRsZT48L2hlYWRlcj4KPGJvZHk+CkhlbGxvIHdvcmxkCjwvYm9keT4KPC9odG1sPg==",
                    RequestBodyCheck = PolicyRequestBodyCheck.Disabled,
                },
                Rules =
{
new WebApplicationCustomRule(1,WebApplicationRuleType.RateLimitRule,new WebApplicationRuleMatchCondition[]
{
new WebApplicationRuleMatchCondition(WebApplicationRuleMatchVariable.RemoteAddr,WebApplicationRuleMatchOperator.IPMatch,new string[]
{
"192.168.1.0/24","10.0.0.0/24"
})
},RuleMatchActionType.Block)
{
Name = "Rule1",
RateLimitThreshold = 1000,
},new WebApplicationCustomRule(2,WebApplicationRuleType.MatchRule,new WebApplicationRuleMatchCondition[]
{
new WebApplicationRuleMatchCondition(WebApplicationRuleMatchVariable.RemoteAddr,WebApplicationRuleMatchOperator.GeoMatch,new string[]
{
"CH"
}),new WebApplicationRuleMatchCondition(WebApplicationRuleMatchVariable.RequestHeader,WebApplicationRuleMatchOperator.Contains,new string[]
{
"windows"
})
{
Selector = "UserAgent",
Transforms =
{
WebApplicationRuleMatchTransformType.Lowercase
},
}
},RuleMatchActionType.Block)
{
Name = "Rule2",
}
},
                ManagedRuleSets =
{
new ManagedRuleSet("DefaultRuleSet","1.0")
{
RuleSetAction = ManagedRuleSetActionType.Block,
Exclusions =
{
new ManagedRuleExclusion(ManagedRuleExclusionMatchVariable.RequestHeaderNames,ManagedRuleExclusionSelectorMatchOperator.EqualsValue,"User-Agent")
},
RuleGroupOverrides =
{
new ManagedRuleGroupOverride("SQLI")
{
Exclusions =
{
new ManagedRuleExclusion(ManagedRuleExclusionMatchVariable.RequestCookieNames,ManagedRuleExclusionSelectorMatchOperator.StartsWith,"token")
},
Rules =
{
new ManagedRuleOverride("942100")
{
EnabledState = ManagedRuleEnabledState.Enabled,
Action = RuleMatchActionType.Redirect,
Exclusions =
{
new ManagedRuleExclusion(ManagedRuleExclusionMatchVariable.QueryStringArgNames,ManagedRuleExclusionSelectorMatchOperator.EqualsValue,"query")
},
},new ManagedRuleOverride("942110")
{
EnabledState = ManagedRuleEnabledState.Disabled,
}
},
}
},
}
},
            };
            ArmOperation<FrontDoorWebApplicationFirewallPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyName, data);
            FrontDoorWebApplicationFirewallPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorWebApplicationFirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
