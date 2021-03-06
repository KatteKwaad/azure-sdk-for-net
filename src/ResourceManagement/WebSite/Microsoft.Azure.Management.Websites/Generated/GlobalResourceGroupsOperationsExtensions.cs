// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class GlobalResourceGroupsOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// </param>
            public static void MoveResources(this IGlobalResourceGroupsOperations operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope)
            {
                Task.Factory.StartNew(s => ((IGlobalResourceGroupsOperations)s).MoveResourcesAsync(resourceGroupName, moveResourceEnvelope), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MoveResourcesAsync( this IGlobalResourceGroupsOperations operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.MoveResourcesWithHttpMessagesAsync(resourceGroupName, moveResourceEnvelope, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
