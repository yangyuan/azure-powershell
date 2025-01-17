// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Patchable Quota Rule of a Volume
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VolumeQuotaRulePatch
    {
        /// <summary>
        /// Initializes a new instance of the VolumeQuotaRulePatch class.
        /// </summary>
        public VolumeQuotaRulePatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeQuotaRulePatch class.
        /// </summary>

        /// <param name="tags">Resource tags
        /// </param>

        /// <param name="provisioningState">Gets the status of the VolumeQuotaRule at the time the operation was
        /// called.
        /// Possible values include: 'Accepted', 'Creating', 'Patching', 'Deleting',
        /// 'Moving', 'Failed', 'Succeeded'</param>

        /// <param name="quotaSizeInKiBs">Size of quota
        /// </param>

        /// <param name="quotaType">Type of quota
        /// Possible values include: 'DefaultUserQuota', 'DefaultGroupQuota',
        /// 'IndividualUserQuota', 'IndividualGroupQuota'</param>

        /// <param name="quotaTarget">UserID/GroupID/SID based on the quota target type. UserID and groupID can
        /// be found by running ‘id’ or ‘getent’ command for the user or group and SID
        /// can be found by running &lt;wmic useraccount where name=&#39;user-name&#39; get sid&gt;
        /// </param>
        public VolumeQuotaRulePatch(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ProvisioningState? provisioningState = default(ProvisioningState?), long? quotaSizeInKiBs = default(long?), string quotaType = default(string), string quotaTarget = default(string))

        {
            this.Tags = tags;
            this.ProvisioningState = provisioningState;
            this.QuotaSizeInKiBs = quotaSizeInKiBs;
            this.QuotaType = quotaType;
            this.QuotaTarget = quotaTarget;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets gets the status of the VolumeQuotaRule at the time the operation was
        /// called. Possible values include: &#39;Accepted&#39;, &#39;Creating&#39;, &#39;Patching&#39;, &#39;Deleting&#39;, &#39;Moving&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets size of quota
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.quotaSizeInKiBs")]
        public long? QuotaSizeInKiBs {get; set; }

        /// <summary>
        /// Gets or sets type of quota Possible values include: &#39;DefaultUserQuota&#39;, &#39;DefaultGroupQuota&#39;, &#39;IndividualUserQuota&#39;, &#39;IndividualGroupQuota&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.quotaType")]
        public string QuotaType {get; set; }

        /// <summary>
        /// Gets or sets userID/GroupID/SID based on the quota target type. UserID and
        /// groupID can be found by running ‘id’ or ‘getent’ command for the user or
        /// group and SID can be found by running &lt;wmic useraccount where
        /// name=&#39;user-name&#39; get sid&gt;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.quotaTarget")]
        public string QuotaTarget {get; set; }
    }
}