using CloudinaryDotNet.Actions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.GHNService
{
    public class GHNService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://dev-online-gateway.ghn.vn/shiip/public-api/v2";
        private string token;
        private int shopId;

        public string Token
        {
            get => token;
            set => token = value;
        }

        public int ShopId
        {
            get => shopId;
            set => shopId = value;
        }

        public GHNService()
        {
            client.DefaultRequestHeaders.Clear();
        }

        private void EnsureValidConfiguration()
        {
            token = GHNServiceConfig.Token;
            shopId = GHNServiceConfig.ShopId;

            if (string.IsNullOrEmpty(token) || shopId == 0)
            {
                throw new Exception("Invalid GHN configuration");
            }
        }

        public async Task<GHNOrderResponse> CreateOrderGHN(object orderData)
         {
            if (orderData == null)
                throw new ArgumentNullException(nameof(orderData), "Order data cannot be null.");
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/shipping-order/create";
            // clear headers to avoid conflicts
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Token", token);
            client.DefaultRequestHeaders.Add("ShopId", shopId.ToString());
            var content = new StringContent(JsonConvert.SerializeObject(orderData), Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                
                if (!response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<GHNOrderResponse>(responseString) ?? new GHNOrderResponse
                    {
                        Code = response.StatusCode.ToString(),
                        Message = "Request failed but response could not be parsed."
                    };
                }
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
                var res_Data = new GHNOrderData
                {
                    order_code = jsonResponse.data.order_code
                };
                return new GHNOrderResponse
                {
                    Code = "200",
                    Message = "Order created successfully",
                    Data = res_Data
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new GHNOrderResponse
                {
                    Code = "HTTP_ERROR",
                    Message = httpEx.Message
                };
            }
            catch (Exception ex)
            {
                return new GHNOrderResponse
                {
                    Code = "500",
                    Message = "An unexpected error occurred: " + ex.Message
                };
            }
        }

        public async Task<GHNOrderResponse> GetOrderDetailGHN(string orderCode)
        {
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/shipping-order/detail";
            // clear headers to avoid conflicts
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Token", token);
            var content = new StringContent(JsonConvert.SerializeObject(new { order_code = orderCode }), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
                var res_Data = new GHNOrderData
                {
                    status = jsonResponse.data.status
                };
                return new GHNOrderResponse
                {
                    Code = "200",
                    Message = "Order details retrieved successfully",
                    Data = res_Data
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new GHNOrderResponse
                {
                    Code = "HTTP_ERROR",
                    Message = httpEx.Message
                };
            }
            catch (Exception ex)
            {
                return new GHNOrderResponse
                {
                    Code = "500",
                    Message = "An unexpected error occurred: " + ex.Message
                };
            }
        }

        public async Task<GHNOrderResponse> CancelOrderGHN(List<string> orderCodes)
        {
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/switch-status/cancel";
            // clear headers to avoid conflicts
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Token", token);
            client.DefaultRequestHeaders.Add("ShopId", shopId.ToString());
            var content = new StringContent(JsonConvert.SerializeObject(new { order_codes = orderCodes, shop_id = ShopId }), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
                var res_Data = new GHNOrderData
                {
                    status = jsonResponse.data.status
                };
                return new GHNOrderResponse
                {
                    Code = "200",
                    Message = "Order cancelled successfully",
                    Data = res_Data
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new GHNOrderResponse
                {
                    Code = "HTTP_ERROR",
                    Message = httpEx.Message
                };
            }
            catch (Exception ex)
            {
                return new GHNOrderResponse
                {
                    Code = "500",
                    Message = "An unexpected error occurred: " + ex.Message
                };

            }
        }
    }

}
