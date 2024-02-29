# wishlist.Api.WishlistApi

All URIs are relative to *https://wishlist.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WishlistAddItemToWishlist**](WishlistApi.md#wishlistadditemtowishlist) | **POST** /wishlist.Wishlist/AddItemToWishlist |  |
| [**WishlistAreItemsInWishlists**](WishlistApi.md#wishlistareitemsinwishlists) | **POST** /wishlist.Wishlist/AreItemsInWishlists |  |
| [**WishlistBulkCreateSharing**](WishlistApi.md#wishlistbulkcreatesharing) | **POST** /wishlist.Wishlist/BulkCreateSharing | Sharing endpoints |
| [**WishlistBulkRemoveItemsFromWishlists**](WishlistApi.md#wishlistbulkremoveitemsfromwishlists) | **POST** /wishlist.Wishlist/BulkRemoveItemsFromWishlists | BulkRemoveItemsFromWishlists removes items from wishlists. |
| [**WishlistBulkRevokeSharing**](WishlistApi.md#wishlistbulkrevokesharing) | **POST** /wishlist.Wishlist/BulkRevokeSharing |  |
| [**WishlistCreateWishlist**](WishlistApi.md#wishlistcreatewishlist) | **POST** /wishlist.Wishlist/CreateWishlist |  |
| [**WishlistDeleteWishlist**](WishlistApi.md#wishlistdeletewishlist) | **POST** /wishlist.Wishlist/DeleteWishlist |  |
| [**WishlistGetItemFromWishlist**](WishlistApi.md#wishlistgetitemfromwishlist) | **POST** /wishlist.Wishlist/GetItemFromWishlist |  |
| [**WishlistGetWishlistById**](WishlistApi.md#wishlistgetwishlistbyid) | **POST** /wishlist.Wishlist/GetWishlistById |  |
| [**WishlistGetWishlistBySharedCode**](WishlistApi.md#wishlistgetwishlistbysharedcode) | **POST** /wishlist.Wishlist/GetWishlistBySharedCode |  |
| [**WishlistListWishlistItems**](WishlistApi.md#wishlistlistwishlistitems) | **POST** /wishlist.Wishlist/ListWishlistItems |  |
| [**WishlistListWishlists**](WishlistApi.md#wishlistlistwishlists) | **POST** /wishlist.Wishlist/ListWishlists |  |
| [**WishlistMergeWishlists**](WishlistApi.md#wishlistmergewishlists) | **POST** /wishlist.Wishlist/MergeWishlists |  |
| [**WishlistRemoveItemFromWishlist**](WishlistApi.md#wishlistremoveitemfromwishlist) | **POST** /wishlist.Wishlist/RemoveItemFromWishlist |  |
| [**WishlistUpdateItemInWishlist**](WishlistApi.md#wishlistupdateiteminwishlist) | **POST** /wishlist.Wishlist/UpdateItemInWishlist |  |
| [**WishlistUpdateWishlist**](WishlistApi.md#wishlistupdatewishlist) | **POST** /wishlist.Wishlist/UpdateWishlist |  |

<a id="wishlistadditemtowishlist"></a>
# **WishlistAddItemToWishlist**
> WishlistWishlistItemResponse WishlistAddItemToWishlist (WishlistAddItemToWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistAddItemToWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistAddItemToWishlistRequest(); // WishlistAddItemToWishlistRequest | 

            try
            {
                WishlistWishlistItemResponse result = apiInstance.WishlistAddItemToWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistAddItemToWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistAddItemToWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistItemResponse> response = apiInstance.WishlistAddItemToWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistAddItemToWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistAddItemToWishlistRequest**](WishlistAddItemToWishlistRequest.md) |  |  |

### Return type

[**WishlistWishlistItemResponse**](WishlistWishlistItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistareitemsinwishlists"></a>
# **WishlistAreItemsInWishlists**
> WishlistAreItemsInWishlistsResponse WishlistAreItemsInWishlists (WishlistAreItemsInWishlistsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistAreItemsInWishlistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistAreItemsInWishlistsRequest(); // WishlistAreItemsInWishlistsRequest | 

            try
            {
                WishlistAreItemsInWishlistsResponse result = apiInstance.WishlistAreItemsInWishlists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistAreItemsInWishlists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistAreItemsInWishlistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistAreItemsInWishlistsResponse> response = apiInstance.WishlistAreItemsInWishlistsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistAreItemsInWishlistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistAreItemsInWishlistsRequest**](WishlistAreItemsInWishlistsRequest.md) |  |  |

### Return type

[**WishlistAreItemsInWishlistsResponse**](WishlistAreItemsInWishlistsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistbulkcreatesharing"></a>
# **WishlistBulkCreateSharing**
> WishlistBulkCreateSharingResponse WishlistBulkCreateSharing (WishlistBulkCreateSharingRequest body)

Sharing endpoints

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistBulkCreateSharingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistBulkCreateSharingRequest(); // WishlistBulkCreateSharingRequest | 

            try
            {
                // Sharing endpoints
                WishlistBulkCreateSharingResponse result = apiInstance.WishlistBulkCreateSharing(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistBulkCreateSharing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistBulkCreateSharingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sharing endpoints
    ApiResponse<WishlistBulkCreateSharingResponse> response = apiInstance.WishlistBulkCreateSharingWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistBulkCreateSharingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistBulkCreateSharingRequest**](WishlistBulkCreateSharingRequest.md) |  |  |

### Return type

[**WishlistBulkCreateSharingResponse**](WishlistBulkCreateSharingResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistbulkremoveitemsfromwishlists"></a>
# **WishlistBulkRemoveItemsFromWishlists**
> Object WishlistBulkRemoveItemsFromWishlists (WishlistBulkRemoveItemsFromWishlistsRequest body)

BulkRemoveItemsFromWishlists removes items from wishlists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistBulkRemoveItemsFromWishlistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistBulkRemoveItemsFromWishlistsRequest(); // WishlistBulkRemoveItemsFromWishlistsRequest | 

            try
            {
                // BulkRemoveItemsFromWishlists removes items from wishlists.
                Object result = apiInstance.WishlistBulkRemoveItemsFromWishlists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistBulkRemoveItemsFromWishlists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistBulkRemoveItemsFromWishlistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BulkRemoveItemsFromWishlists removes items from wishlists.
    ApiResponse<Object> response = apiInstance.WishlistBulkRemoveItemsFromWishlistsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistBulkRemoveItemsFromWishlistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistBulkRemoveItemsFromWishlistsRequest**](WishlistBulkRemoveItemsFromWishlistsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistbulkrevokesharing"></a>
# **WishlistBulkRevokeSharing**
> Object WishlistBulkRevokeSharing (WishlistBulkRevokeSharingRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistBulkRevokeSharingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistBulkRevokeSharingRequest(); // WishlistBulkRevokeSharingRequest | 

            try
            {
                Object result = apiInstance.WishlistBulkRevokeSharing(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistBulkRevokeSharing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistBulkRevokeSharingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.WishlistBulkRevokeSharingWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistBulkRevokeSharingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistBulkRevokeSharingRequest**](WishlistBulkRevokeSharingRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistcreatewishlist"></a>
# **WishlistCreateWishlist**
> WishlistWishlistResponse WishlistCreateWishlist (WishlistCreateWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistCreateWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistCreateWishlistRequest(); // WishlistCreateWishlistRequest | 

            try
            {
                WishlistWishlistResponse result = apiInstance.WishlistCreateWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistCreateWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistCreateWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistResponse> response = apiInstance.WishlistCreateWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistCreateWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistCreateWishlistRequest**](WishlistCreateWishlistRequest.md) |  |  |

### Return type

[**WishlistWishlistResponse**](WishlistWishlistResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistdeletewishlist"></a>
# **WishlistDeleteWishlist**
> Object WishlistDeleteWishlist (WishlistDeleteWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistDeleteWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistDeleteWishlistRequest(); // WishlistDeleteWishlistRequest | 

            try
            {
                Object result = apiInstance.WishlistDeleteWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistDeleteWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistDeleteWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.WishlistDeleteWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistDeleteWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistDeleteWishlistRequest**](WishlistDeleteWishlistRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistgetitemfromwishlist"></a>
# **WishlistGetItemFromWishlist**
> WishlistWishlistItemResponse WishlistGetItemFromWishlist (WishlistGetItemFromWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistGetItemFromWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistGetItemFromWishlistRequest(); // WishlistGetItemFromWishlistRequest | 

            try
            {
                WishlistWishlistItemResponse result = apiInstance.WishlistGetItemFromWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistGetItemFromWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistGetItemFromWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistItemResponse> response = apiInstance.WishlistGetItemFromWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistGetItemFromWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistGetItemFromWishlistRequest**](WishlistGetItemFromWishlistRequest.md) |  |  |

### Return type

[**WishlistWishlistItemResponse**](WishlistWishlistItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistgetwishlistbyid"></a>
# **WishlistGetWishlistById**
> WishlistWishlistResponse WishlistGetWishlistById (WishlistGetWishlistByIdRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistGetWishlistByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistGetWishlistByIdRequest(); // WishlistGetWishlistByIdRequest | 

            try
            {
                WishlistWishlistResponse result = apiInstance.WishlistGetWishlistById(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistGetWishlistById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistGetWishlistByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistResponse> response = apiInstance.WishlistGetWishlistByIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistGetWishlistByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistGetWishlistByIdRequest**](WishlistGetWishlistByIdRequest.md) |  |  |

### Return type

[**WishlistWishlistResponse**](WishlistWishlistResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistgetwishlistbysharedcode"></a>
# **WishlistGetWishlistBySharedCode**
> WishlistWishlistResponse WishlistGetWishlistBySharedCode (WishlistGetWishlistBySharedCodeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistGetWishlistBySharedCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistGetWishlistBySharedCodeRequest(); // WishlistGetWishlistBySharedCodeRequest | 

            try
            {
                WishlistWishlistResponse result = apiInstance.WishlistGetWishlistBySharedCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistGetWishlistBySharedCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistGetWishlistBySharedCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistResponse> response = apiInstance.WishlistGetWishlistBySharedCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistGetWishlistBySharedCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistGetWishlistBySharedCodeRequest**](WishlistGetWishlistBySharedCodeRequest.md) |  |  |

### Return type

[**WishlistWishlistResponse**](WishlistWishlistResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistlistwishlistitems"></a>
# **WishlistListWishlistItems**
> WishlistListWishlistItemsResponse WishlistListWishlistItems (WishlistListWishlistItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistListWishlistItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistListWishlistItemsRequest(); // WishlistListWishlistItemsRequest | 

            try
            {
                WishlistListWishlistItemsResponse result = apiInstance.WishlistListWishlistItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistListWishlistItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistListWishlistItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistListWishlistItemsResponse> response = apiInstance.WishlistListWishlistItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistListWishlistItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistListWishlistItemsRequest**](WishlistListWishlistItemsRequest.md) |  |  |

### Return type

[**WishlistListWishlistItemsResponse**](WishlistListWishlistItemsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistlistwishlists"></a>
# **WishlistListWishlists**
> WishlistListWishlistsResponse WishlistListWishlists (WishlistListWishlistsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistListWishlistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistListWishlistsRequest(); // WishlistListWishlistsRequest | 

            try
            {
                WishlistListWishlistsResponse result = apiInstance.WishlistListWishlists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistListWishlists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistListWishlistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistListWishlistsResponse> response = apiInstance.WishlistListWishlistsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistListWishlistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistListWishlistsRequest**](WishlistListWishlistsRequest.md) |  |  |

### Return type

[**WishlistListWishlistsResponse**](WishlistListWishlistsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistmergewishlists"></a>
# **WishlistMergeWishlists**
> WishlistWishlistResponse WishlistMergeWishlists (WishlistMergeWishlistsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistMergeWishlistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistMergeWishlistsRequest(); // WishlistMergeWishlistsRequest | 

            try
            {
                WishlistWishlistResponse result = apiInstance.WishlistMergeWishlists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistMergeWishlists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistMergeWishlistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistResponse> response = apiInstance.WishlistMergeWishlistsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistMergeWishlistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistMergeWishlistsRequest**](WishlistMergeWishlistsRequest.md) |  |  |

### Return type

[**WishlistWishlistResponse**](WishlistWishlistResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistremoveitemfromwishlist"></a>
# **WishlistRemoveItemFromWishlist**
> Object WishlistRemoveItemFromWishlist (WishlistRemoveItemFromWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistRemoveItemFromWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistRemoveItemFromWishlistRequest(); // WishlistRemoveItemFromWishlistRequest | 

            try
            {
                Object result = apiInstance.WishlistRemoveItemFromWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistRemoveItemFromWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistRemoveItemFromWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.WishlistRemoveItemFromWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistRemoveItemFromWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistRemoveItemFromWishlistRequest**](WishlistRemoveItemFromWishlistRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistupdateiteminwishlist"></a>
# **WishlistUpdateItemInWishlist**
> WishlistWishlistItemResponse WishlistUpdateItemInWishlist (WishlistUpdateItemInWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistUpdateItemInWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistUpdateItemInWishlistRequest(); // WishlistUpdateItemInWishlistRequest | 

            try
            {
                WishlistWishlistItemResponse result = apiInstance.WishlistUpdateItemInWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistUpdateItemInWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistUpdateItemInWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistItemResponse> response = apiInstance.WishlistUpdateItemInWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistUpdateItemInWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistUpdateItemInWishlistRequest**](WishlistUpdateItemInWishlistRequest.md) |  |  |

### Return type

[**WishlistWishlistItemResponse**](WishlistWishlistItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="wishlistupdatewishlist"></a>
# **WishlistUpdateWishlist**
> WishlistWishlistResponse WishlistUpdateWishlist (WishlistUpdateWishlistRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using wishlist.Api;
using wishlist.Client;
using wishlist.Model;

namespace Example
{
    public class WishlistUpdateWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://wishlist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WishlistApi(config);
            var body = new WishlistUpdateWishlistRequest(); // WishlistUpdateWishlistRequest | 

            try
            {
                WishlistWishlistResponse result = apiInstance.WishlistUpdateWishlist(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.WishlistUpdateWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WishlistUpdateWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WishlistWishlistResponse> response = apiInstance.WishlistUpdateWishlistWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.WishlistUpdateWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WishlistUpdateWishlistRequest**](WishlistUpdateWishlistRequest.md) |  |  |

### Return type

[**WishlistWishlistResponse**](WishlistWishlistResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

