// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{

    /// <summary>
    /// Defines values for PackageState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PackageState
    {
        [System.Runtime.Serialization.EnumMember(Value = "pending")]
        Pending,
        [System.Runtime.Serialization.EnumMember(Value = "active")]
        Active,
        [System.Runtime.Serialization.EnumMember(Value = "unmapped")]
        Unmapped
    }
}
