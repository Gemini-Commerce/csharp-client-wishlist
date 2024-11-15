/*
 * Wishlist Service
 *
 * API for managing wishlists
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = wishlist.Client.OpenAPIDateConverter;

namespace wishlist.Model
{
    /// <summary>
    /// WishlistSharingResponse
    /// </summary>
    [DataContract(Name = "wishlistSharingResponse")]
    public partial class WishlistSharingResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name = "permission", EmitDefaultValue = false)]
        public WishlistPermission? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistSharingResponse" /> class.
        /// </summary>
        /// <param name="sharingId">sharingId.</param>
        /// <param name="sharingGrn">sharingGrn.</param>
        /// <param name="wishlistId">wishlistId.</param>
        /// <param name="permission">permission.</param>
        /// <param name="customerGrn">customerGrn.</param>
        /// <param name="customerAggregationId">customerAggregationId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public WishlistSharingResponse(string sharingId = default(string), string sharingGrn = default(string), string wishlistId = default(string), WishlistPermission? permission = default(WishlistPermission?), string customerGrn = default(string), string customerAggregationId = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.SharingId = sharingId;
            this.SharingGrn = sharingGrn;
            this.WishlistId = wishlistId;
            this.Permission = permission;
            this.CustomerGrn = customerGrn;
            this.CustomerAggregationId = customerAggregationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SharingId
        /// </summary>
        [DataMember(Name = "sharingId", EmitDefaultValue = false)]
        public string SharingId { get; set; }

        /// <summary>
        /// Gets or Sets SharingGrn
        /// </summary>
        [DataMember(Name = "sharingGrn", EmitDefaultValue = false)]
        public string SharingGrn { get; set; }

        /// <summary>
        /// Gets or Sets WishlistId
        /// </summary>
        [DataMember(Name = "wishlistId", EmitDefaultValue = false)]
        public string WishlistId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGrn
        /// </summary>
        [DataMember(Name = "customerGrn", EmitDefaultValue = false)]
        public string CustomerGrn { get; set; }

        /// <summary>
        /// Gets or Sets CustomerAggregationId
        /// </summary>
        [DataMember(Name = "customerAggregationId", EmitDefaultValue = false)]
        public string CustomerAggregationId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WishlistSharingResponse {\n");
            sb.Append("  SharingId: ").Append(SharingId).Append("\n");
            sb.Append("  SharingGrn: ").Append(SharingGrn).Append("\n");
            sb.Append("  WishlistId: ").Append(WishlistId).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  CustomerGrn: ").Append(CustomerGrn).Append("\n");
            sb.Append("  CustomerAggregationId: ").Append(CustomerAggregationId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
