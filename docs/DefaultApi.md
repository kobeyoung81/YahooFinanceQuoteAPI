# YahooFinance.Quote.Api.DefaultApi

All URIs are relative to *https://query1.finance.yahoo.com/v7/finance*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetQuote**](DefaultApi.md#getquote) | **GET** /quote | get quote for symbol

<a name="getquote"></a>
# **GetQuote**
> QuoteResponseContent GetQuote (string symbols)

get quote for symbol

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using YahooFinance.Quote.Api;
using YahooFinance.Quote.Client;
using YahooFinance.Quote.Model;

namespace Example
{
    public class GetQuoteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var symbols = symbols_example;  // string | pass an optional search string for looking up inventory

            try
            {
                // get quote for symbol
                QuoteResponseContent result = apiInstance.GetQuote(symbols);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbols** | **string**| pass an optional search string for looking up inventory | 

### Return type

[**QuoteResponseContent**](QuoteResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
