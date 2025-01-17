// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// Azure OpenAI Content Filter.
    /// </summary>
    public partial class RaiContentFilter
    {
        /// <summary>
        /// Initializes a new instance of the RaiContentFilter class.
        /// </summary>
        public RaiContentFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RaiContentFilter class.
        /// </summary>

        /// <param name="policyName">Name of Content Filter.
        /// </param>

        /// <param name="description">Description of Content Filter.
        /// </param>

        /// <param name="filterType">Content Filter type.
        /// Possible values include: 'MultiLevel', 'Switch'</param>
        public RaiContentFilter(string policyName = default(string), string description = default(string), string filterType = default(string))

        {
            this.PolicyName = policyName;
            this.Description = description;
            this.FilterType = filterType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of Content Filter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyName")]
        public string PolicyName {get; set; }

        /// <summary>
        /// Gets or sets description of Content Filter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets content Filter type. Possible values include: &#39;MultiLevel&#39;, &#39;Switch&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filterType")]
        public string FilterType {get; set; }
    }
}