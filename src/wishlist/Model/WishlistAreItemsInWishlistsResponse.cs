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
    /// WishlistAreItemsInWishlistsResponse
    /// </summary>
    [DataContract(Name = "wishlistAreItemsInWishlistsResponse")]
    public partial class WishlistAreItemsInWishlistsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistAreItemsInWishlistsResponse" /> class.
        /// </summary>
        /// <param name="itemGrnMap">itemGrnMap.</param>
        public WishlistAreItemsInWishlistsResponse(Dictionary<string, WishlistAreItemsInWishlistsResponsePayload> itemGrnMap = default(Dictionary<string, WishlistAreItemsInWishlistsResponsePayload>))
        {
            this.ItemGrnMap = itemGrnMap;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets ItemGrnMap
        /// </summary>
        [DataMember(Name = "itemGrnMap", EmitDefaultValue = false)]
        public Dictionary<string, WishlistAreItemsInWishlistsResponsePayload> ItemGrnMap { get; set; }

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
            sb.Append("class WishlistAreItemsInWishlistsResponse {\n");
            sb.Append("  ItemGrnMap: ").Append(ItemGrnMap).Append("\n");
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
