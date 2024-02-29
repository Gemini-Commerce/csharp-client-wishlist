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
    /// Defines wishlistPrivacy
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WishlistPrivacy
    {
        /// <summary>
        /// Enum UNKNOWN for value: PRIVACY_UNKNOWN
        /// </summary>
        [EnumMember(Value = "PRIVACY_UNKNOWN")]
        UNKNOWN = 1,

        /// <summary>
        /// Enum PUBLIC for value: PRIVACY_PUBLIC
        /// </summary>
        [EnumMember(Value = "PRIVACY_PUBLIC")]
        PUBLIC = 2,

        /// <summary>
        /// Enum PRIVATE for value: PRIVACY_PRIVATE
        /// </summary>
        [EnumMember(Value = "PRIVACY_PRIVATE")]
        PRIVATE = 3,

        /// <summary>
        /// Enum SHARED for value: PRIVACY_SHARED
        /// </summary>
        [EnumMember(Value = "PRIVACY_SHARED")]
        SHARED = 4
    }

}