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
    /// WishlistUpdateItemInWishlistRequestPayload
    /// </summary>
    [DataContract(Name = "wishlistUpdateItemInWishlistRequestPayload")]
    public partial class WishlistUpdateItemInWishlistRequestPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistUpdateItemInWishlistRequestPayload" /> class.
        /// </summary>
        /// <param name="preferredQuantity">preferredQuantity.</param>
        /// <param name="description">description.</param>
        /// <param name="customerGrn">customerGrn.</param>
        public WishlistUpdateItemInWishlistRequestPayload(string preferredQuantity = default(string), WishlistLocalizedText description = default(WishlistLocalizedText), string customerGrn = default(string))
        {
            this.PreferredQuantity = preferredQuantity;
            this.Description = description;
            this.CustomerGrn = customerGrn;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WishlistUpdateItemInWishlistRequestPayload {\n");
            sb.Append("  PreferredQuantity: ").Append(PreferredQuantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CustomerGrn: ").Append(CustomerGrn).Append("\n");
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
