// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The detail of a user.
    /// </summary>
    public partial class UserSet
    {
        /// <summary>
        /// Initializes a new instance of the UserSet class.
        /// </summary>
        public UserSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserSet class.
        /// </summary>
        /// <param name="userType">The type of user. Possible values include:
        /// 'User', 'Group'</param>
        /// <param name="isBackup">The value indicating whether the user is a
        /// backup fallback approver</param>
        /// <param name="id">The object id of the user.</param>
        /// <param name="description">The description of the user.</param>
        public UserSet(string userType = default(string), bool? isBackup = default(bool?), string id = default(string), string description = default(string))
        {
            UserType = userType;
            IsBackup = isBackup;
            Id = id;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of user. Possible values include: 'User',
        /// 'Group'
        /// </summary>
        [JsonProperty(PropertyName = "userType")]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the user is a backup
        /// fallback approver
        /// </summary>
        [JsonProperty(PropertyName = "isBackup")]
        public bool? IsBackup { get; set; }

        /// <summary>
        /// Gets or sets the object id of the user.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the user.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
