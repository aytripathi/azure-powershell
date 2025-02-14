// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class FailoverPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IFailoverPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="IsSafeFailover" /> property.</summary>
        private bool? _isSafeFailover;

        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public bool? IsSafeFailover { get => this._isSafeFailover; set => this._isSafeFailover = value; }

        /// <summary>Creates an new <see cref="FailoverPropertiesAutoGenerated" /> instance.</summary>
        public FailoverPropertiesAutoGenerated()
        {

        }
    }
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    public partial interface IFailoverPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.",
        SerializedName = @"IsSafeFailover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSafeFailover { get; set; }

    }
    /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
    internal partial interface IFailoverPropertiesAutoGeneratedInternal

    {
        /// <summary>
        /// Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary.
        /// </summary>
        bool? IsSafeFailover { get; set; }

    }
}