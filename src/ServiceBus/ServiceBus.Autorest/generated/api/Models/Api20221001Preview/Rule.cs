// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Description of Rule Resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class Rule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRule,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ProxyResource();

        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public int? ActionCompatibilityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionCompatibilityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionCompatibilityLevel = value ?? default(int); }

        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public bool? ActionRequiresPreprocessing { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionRequiresPreprocessing; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionRequiresPreprocessing = value ?? default(bool); }

        /// <summary>SQL expression. e.g. MyProperty='ABC'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string ActionSqlExpression { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionSqlExpression; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).ActionSqlExpression = value ?? null; }

        /// <summary>Content type of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string ContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterContentType = value ?? null; }

        /// <summary>dictionary object for custom filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties CorrelationFilterProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterProperty = value ?? null /* model class */; }

        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public bool? CorrelationFilterRequiresPreprocessing { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterRequiresPreprocessing; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterRequiresPreprocessing = value ?? default(bool); }

        /// <summary>Identifier of the correlation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string CorrelationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterCorrelationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterCorrelationId = value ?? null; }

        /// <summary>Filter type that is evaluated against a BrokeredMessage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.FilterType? FilterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).FilterType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).FilterType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.FilterType)""); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>Application specific label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string Label { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterLabel = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Location; }

        /// <summary>Identifier of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string MessageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterMessageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterMessageId = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Internal Acessors for Action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IAction Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).Action = value; }

        /// <summary>Internal Acessors for CorrelationFilter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal.CorrelationFilter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilter = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleproperties Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.Ruleproperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SqlFilter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISqlFilter Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal.SqlFilter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilter = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleproperties _property;

        /// <summary>Properties of Rule resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleproperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.Ruleproperties()); set => this._property = value; }

        /// <summary>Address of the queue to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string ReplyTo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterReplyTo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterReplyTo = value ?? null; }

        /// <summary>Session identifier to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string ReplyToSessionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterReplyToSessionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterReplyToSessionId = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Session identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string SessionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterSessionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterSessionId = value ?? null; }

        /// <summary>The SQL expression. e.g. MyProperty='ABC'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string SqlExpression { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterSqlExpression; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterSqlExpression = value ?? null; }

        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public int? SqlFilterCompatibilityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterCompatibilityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterCompatibilityLevel = value ?? default(int); }

        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public bool? SqlFilterRequiresPreprocessing { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterRequiresPreprocessing; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).SqlFilterRequiresPreprocessing = value ?? default(bool); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemData _systemData;

        /// <summary>The system meta data relating to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType)""); }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType)""); }

        /// <summary>Address to send to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inlined)]
        public string To { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterTo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRulepropertiesInternal)Property).CorrelationFilterTo = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.EventHub/Namespaces" or "Microsoft.EventHub/Namespaces/EventHubs"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Rule" /> instance.</summary>
        public Rule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Description of Rule Resource.
    public partial interface IRule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResource
    {
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.",
        SerializedName = @"compatibilityLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? ActionCompatibilityLevel { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value that indicates whether the rule action requires preprocessing.",
        SerializedName = @"requiresPreprocessing",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ActionRequiresPreprocessing { get; set; }
        /// <summary>SQL expression. e.g. MyProperty='ABC'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL expression. e.g. MyProperty='ABC'",
        SerializedName = @"sqlExpression",
        PossibleTypes = new [] { typeof(string) })]
        string ActionSqlExpression { get; set; }
        /// <summary>Content type of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Content type of the message.",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }
        /// <summary>dictionary object for custom filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"dictionary object for custom filters",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties CorrelationFilterProperty { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value that indicates whether the rule action requires preprocessing.",
        SerializedName = @"requiresPreprocessing",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CorrelationFilterRequiresPreprocessing { get; set; }
        /// <summary>Identifier of the correlation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the correlation.",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get; set; }
        /// <summary>Filter type that is evaluated against a BrokeredMessage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Filter type that is evaluated against a BrokeredMessage.",
        SerializedName = @"filterType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.FilterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.FilterType? FilterType { get; set; }
        /// <summary>Application specific label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application specific label.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>Identifier of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the message.",
        SerializedName = @"messageId",
        PossibleTypes = new [] { typeof(string) })]
        string MessageId { get; set; }
        /// <summary>Address of the queue to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address of the queue to reply to.",
        SerializedName = @"replyTo",
        PossibleTypes = new [] { typeof(string) })]
        string ReplyTo { get; set; }
        /// <summary>Session identifier to reply to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Session identifier to reply to.",
        SerializedName = @"replyToSessionId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplyToSessionId { get; set; }
        /// <summary>Session identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Session identifier.",
        SerializedName = @"sessionId",
        PossibleTypes = new [] { typeof(string) })]
        string SessionId { get; set; }
        /// <summary>The SQL expression. e.g. MyProperty='ABC'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL expression. e.g. MyProperty='ABC'",
        SerializedName = @"sqlExpression",
        PossibleTypes = new [] { typeof(string) })]
        string SqlExpression { get; set; }
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.",
        SerializedName = @"compatibilityLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? SqlFilterCompatibilityLevel { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value that indicates whether the rule action requires preprocessing.",
        SerializedName = @"requiresPreprocessing",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SqlFilterRequiresPreprocessing { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Address to send to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address to send to.",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(string) })]
        string To { get; set; }

    }
    /// Description of Rule Resource.
    internal partial interface IRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.IProxyResourceInternal
    {
        /// <summary>
        /// Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter
        /// expression.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IAction Action { get; set; }
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        int? ActionCompatibilityLevel { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        bool? ActionRequiresPreprocessing { get; set; }
        /// <summary>SQL expression. e.g. MyProperty='ABC'</summary>
        string ActionSqlExpression { get; set; }
        /// <summary>Content type of the message.</summary>
        string ContentType { get; set; }
        /// <summary>Properties of correlationFilter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilter CorrelationFilter { get; set; }
        /// <summary>dictionary object for custom filters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICorrelationFilterProperties CorrelationFilterProperty { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        bool? CorrelationFilterRequiresPreprocessing { get; set; }
        /// <summary>Identifier of the correlation.</summary>
        string CorrelationId { get; set; }
        /// <summary>Filter type that is evaluated against a BrokeredMessage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.FilterType? FilterType { get; set; }
        /// <summary>Application specific label.</summary>
        string Label { get; set; }
        /// <summary>Identifier of the message.</summary>
        string MessageId { get; set; }
        /// <summary>Properties of Rule resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IRuleproperties Property { get; set; }
        /// <summary>Address of the queue to reply to.</summary>
        string ReplyTo { get; set; }
        /// <summary>Session identifier to reply to.</summary>
        string ReplyToSessionId { get; set; }
        /// <summary>Session identifier.</summary>
        string SessionId { get; set; }
        /// <summary>The SQL expression. e.g. MyProperty='ABC'</summary>
        string SqlExpression { get; set; }
        /// <summary>Properties of sqlFilter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISqlFilter SqlFilter { get; set; }
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        int? SqlFilterCompatibilityLevel { get; set; }
        /// <summary>Value that indicates whether the rule action requires preprocessing.</summary>
        bool? SqlFilterRequiresPreprocessing { get; set; }
        /// <summary>The system meta data relating to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Address to send to.</summary>
        string To { get; set; }

    }
}