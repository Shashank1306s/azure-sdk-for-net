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
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiIssueCommentCollection
    {
        // ApiManagementListApiIssueComments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListApiIssueComments()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListApiIssueComments.json
            // this example is just showing the usage of "ApiIssueComment_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueCommentResource
            ApiIssueCommentCollection collection = apiIssue.GetApiIssueComments();

            // invoke the operation and iterate over the result
            await foreach (ApiIssueCommentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiIssueCommentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueCommentResource
            ApiIssueCommentCollection collection = apiIssue.GetApiIssueComments();

            // invoke the operation
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ApiIssueCommentResource result = await collection.GetAsync(commentId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueCommentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueCommentResource
            ApiIssueCommentCollection collection = apiIssue.GetApiIssueComments();

            // invoke the operation
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            bool result = await collection.ExistsAsync(commentId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementCreateApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementCreateApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueResource created on azure
            // for more information of creating ApiIssueResource, please refer to the document of ApiIssueResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiIssueResourceId = ApiIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId);
            ApiIssueResource apiIssue = client.GetApiIssueResource(apiIssueResourceId);

            // get the collection of this ApiIssueCommentResource
            ApiIssueCommentCollection collection = apiIssue.GetApiIssueComments();

            // invoke the operation
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ApiIssueCommentData data = new ApiIssueCommentData()
            {
                Text = "Issue comment.",
                CreatedOn = DateTimeOffset.Parse("2018-02-01T22:21:20.467Z"),
                UserId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/users/1"),
            };
            ArmOperation<ApiIssueCommentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, commentId, data);
            ApiIssueCommentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueCommentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
