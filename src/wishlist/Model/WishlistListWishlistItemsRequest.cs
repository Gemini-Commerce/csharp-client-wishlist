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
    /// WishlistListWishlistItemsRequest
    /// </summary>
    [DataContract(Name = "wishlistListWishlistItemsRequest")]
    public partial class WishlistListWishlistItemsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistListWishlistItemsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WishlistListWishlistItemsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistListWishlistItemsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="wishlistId">wishlistId (required).</param>
        /// <param name="customerGrn">customerGrn.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageToken">pageToken.</param>
        public WishlistListWishlistItemsRequest(string tenantId = default(string), string wishlistId = default(string), string customerGrn = default(string), long pageSize = default(long), string pageToken = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for WishlistListWishlistItemsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "wishlistId" is required (not null)
            if (wishlistId == null)
            {
                throw new ArgumentNullException("wishlistId is a required property for WishlistListWishlistItemsRequest and cannot be null");
            }
            this.WishlistId = wishlistId;
            this.CustomerGrn = customerGrn;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets WishlistId
        /// </summary>
        [DataMember(Name = "wishlistId", IsRequired = true, EmitDefaultValue = true)]
        public string WishlistId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGrn
        /// </summary>
        [DataMember(Name = "customerGrn", EmitDefaultValue = false)]
        public string CustomerGrn { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WishlistListWishlistItemsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  WishlistId: ").Append(WishlistId).Append("\n");
            sb.Append("  CustomerGrn: ").Append(CustomerGrn).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}