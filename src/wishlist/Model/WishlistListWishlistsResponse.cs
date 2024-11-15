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
    /// WishlistListWishlistsResponse
    /// </summary>
    [DataContract(Name = "wishlistListWishlistsResponse")]
    public partial class WishlistListWishlistsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistListWishlistsResponse" /> class.
        /// </summary>
        /// <param name="wishlist">wishlist.</param>
        /// <param name="nextPageToken">nextPageToken.</param>
        public WishlistListWishlistsResponse(List<WishlistWishlistResponse> wishlist = default(List<WishlistWishlistResponse>), string nextPageToken = default(string))
        {
            this.Wishlist = wishlist;
            this.NextPageToken = nextPageToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Wishlist
        /// </summary>
        [DataMember(Name = "wishlist", EmitDefaultValue = false)]
        public List<WishlistWishlistResponse> Wishlist { get; set; }

        /// <summary>
        /// Gets or Sets NextPageToken
        /// </summary>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

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
            sb.Append("class WishlistListWishlistsResponse {\n");
            sb.Append("  Wishlist: ").Append(Wishlist).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
