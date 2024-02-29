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
    /// WishlistUpdateWishlistRequest
    /// </summary>
    [DataContract(Name = "wishlistUpdateWishlistRequest")]
    public partial class WishlistUpdateWishlistRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistUpdateWishlistRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WishlistUpdateWishlistRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistUpdateWishlistRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="payload">payload (required).</param>
        /// <param name="payloadMask">payloadMask (required).</param>
        public WishlistUpdateWishlistRequest(string tenantId = default(string), string id = default(string), WishlistUpdateWishlistRequestPayload payload = default(WishlistUpdateWishlistRequestPayload), string payloadMask = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for WishlistUpdateWishlistRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for WishlistUpdateWishlistRequest and cannot be null");
            }
            this.Id = id;
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for WishlistUpdateWishlistRequest and cannot be null");
            }
            this.Payload = payload;
            // to ensure "payloadMask" is required (not null)
            if (payloadMask == null)
            {
                throw new ArgumentNullException("payloadMask is a required property for WishlistUpdateWishlistRequest and cannot be null");
            }
            this.PayloadMask = payloadMask;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public WishlistUpdateWishlistRequestPayload Payload { get; set; }

        /// <summary>
        /// Gets or Sets PayloadMask
        /// </summary>
        [DataMember(Name = "payloadMask", IsRequired = true, EmitDefaultValue = true)]
        public string PayloadMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WishlistUpdateWishlistRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  PayloadMask: ").Append(PayloadMask).Append("\n");
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