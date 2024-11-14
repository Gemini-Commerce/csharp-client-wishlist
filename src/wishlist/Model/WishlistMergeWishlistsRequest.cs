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
    /// WishlistMergeWishlistsRequest
    /// </summary>
    [DataContract(Name = "wishlistMergeWishlistsRequest")]
    public partial class WishlistMergeWishlistsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistMergeWishlistsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WishlistMergeWishlistsRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistMergeWishlistsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="startingWishlistId">startingWishlistId (required).</param>
        /// <param name="customerGrn">If the customer GRN is set on JWT, it will be used as default. Otherwise, it will be used the customer_grn field. (required).</param>
        /// <param name="targetWishlistId">The wishlist to merge into the starting wishlist..</param>
        public WishlistMergeWishlistsRequest(string tenantId = default(string), string startingWishlistId = default(string), string customerGrn = default(string), string targetWishlistId = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for WishlistMergeWishlistsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "startingWishlistId" is required (not null)
            if (startingWishlistId == null)
            {
                throw new ArgumentNullException("startingWishlistId is a required property for WishlistMergeWishlistsRequest and cannot be null");
            }
            this.StartingWishlistId = startingWishlistId;
            // to ensure "customerGrn" is required (not null)
            if (customerGrn == null)
            {
                throw new ArgumentNullException("customerGrn is a required property for WishlistMergeWishlistsRequest and cannot be null");
            }
            this.CustomerGrn = customerGrn;
            this.TargetWishlistId = targetWishlistId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets StartingWishlistId
        /// </summary>
        [DataMember(Name = "startingWishlistId", IsRequired = true, EmitDefaultValue = true)]
        public string StartingWishlistId { get; set; }

        /// <summary>
        /// If the customer GRN is set on JWT, it will be used as default. Otherwise, it will be used the customer_grn field.
        /// </summary>
        /// <value>If the customer GRN is set on JWT, it will be used as default. Otherwise, it will be used the customer_grn field.</value>
        [DataMember(Name = "customerGrn", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerGrn { get; set; }

        /// <summary>
        /// The wishlist to merge into the starting wishlist.
        /// </summary>
        /// <value>The wishlist to merge into the starting wishlist.</value>
        [DataMember(Name = "targetWishlistId", EmitDefaultValue = false)]
        public string TargetWishlistId { get; set; }

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
            sb.Append("class WishlistMergeWishlistsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  StartingWishlistId: ").Append(StartingWishlistId).Append("\n");
            sb.Append("  CustomerGrn: ").Append(CustomerGrn).Append("\n");
            sb.Append("  TargetWishlistId: ").Append(TargetWishlistId).Append("\n");
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
