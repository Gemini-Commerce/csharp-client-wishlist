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
    /// WishlistListWishlistsRequest
    /// </summary>
    [DataContract(Name = "wishlistListWishlistsRequest")]
    public partial class WishlistListWishlistsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistListWishlistsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WishlistListWishlistsRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistListWishlistsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageToken">pageToken.</param>
        /// <param name="filter">filter.</param>
        /// <param name="filterMask">filterMask.</param>
        public WishlistListWishlistsRequest(string tenantId = default(string), long pageSize = default(long), string pageToken = default(string), ListWishlistsRequestFilter filter = default(ListWishlistsRequestFilter), string filterMask = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for WishlistListWishlistsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.Filter = filter;
            this.FilterMask = filterMask;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

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
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public ListWishlistsRequestFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets FilterMask
        /// </summary>
        [DataMember(Name = "filterMask", EmitDefaultValue = false)]
        public string FilterMask { get; set; }

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
            sb.Append("class WishlistListWishlistsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  FilterMask: ").Append(FilterMask).Append("\n");
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
