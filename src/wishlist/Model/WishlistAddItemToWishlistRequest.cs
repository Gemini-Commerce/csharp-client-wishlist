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
    /// WishlistAddItemToWishlistRequest
    /// </summary>
    [DataContract(Name = "wishlistAddItemToWishlistRequest")]
    public partial class WishlistAddItemToWishlistRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistAddItemToWishlistRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WishlistAddItemToWishlistRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistAddItemToWishlistRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="wishlistId">wishlistId (required).</param>
        /// <param name="itemGrn">itemGrn (required).</param>
        /// <param name="preferredQuantity">preferredQuantity.</param>
        /// <param name="description">description.</param>
        /// <param name="customerGrn">customerGrn.</param>
        public WishlistAddItemToWishlistRequest(string tenantId = default(string), string wishlistId = default(string), string itemGrn = default(string), string preferredQuantity = default(string), WishlistLocalizedText description = default(WishlistLocalizedText), string customerGrn = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for WishlistAddItemToWishlistRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "wishlistId" is required (not null)
            if (wishlistId == null)
            {
                throw new ArgumentNullException("wishlistId is a required property for WishlistAddItemToWishlistRequest and cannot be null");
            }
            this.WishlistId = wishlistId;
            // to ensure "itemGrn" is required (not null)
            if (itemGrn == null)
            {
                throw new ArgumentNullException("itemGrn is a required property for WishlistAddItemToWishlistRequest and cannot be null");
            }
            this.ItemGrn = itemGrn;
            this.PreferredQuantity = preferredQuantity;
            this.Description = description;
            this.CustomerGrn = customerGrn;
            this.AdditionalProperties = new Dictionary<string, object>();
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
        /// Gets or Sets ItemGrn
        /// </summary>
        [DataMember(Name = "itemGrn", IsRequired = true, EmitDefaultValue = true)]
        public string ItemGrn { get; set; }

        /// <summary>
        /// Gets or Sets PreferredQuantity
        /// </summary>
        [DataMember(Name = "preferredQuantity", EmitDefaultValue = false)]
        public string PreferredQuantity { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public WishlistLocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGrn
        /// </summary>
        [DataMember(Name = "customerGrn", EmitDefaultValue = false)]
        public string CustomerGrn { get; set; }

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
            sb.Append("class WishlistAddItemToWishlistRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  WishlistId: ").Append(WishlistId).Append("\n");
            sb.Append("  ItemGrn: ").Append(ItemGrn).Append("\n");
            sb.Append("  PreferredQuantity: ").Append(PreferredQuantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CustomerGrn: ").Append(CustomerGrn).Append("\n");
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
