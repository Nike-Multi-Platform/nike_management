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
            token = ConfigurationManager.AppSettings["Token"];
            shopId = int.Parse(ConfigurationManager.AppSettings["ShopID"]);
            if (!int.TryParse(ConfigurationManager.AppSettings["GHNServiceShopId"], out shopId))
            {
                throw new ConfigurationErrorsException("Invalid ShopId in configuration.");
            }

            if (string.IsNullOrEmpty(token))
            {
                throw new ConfigurationErrorsException("Token is missing in configuration.");
            }

            if (shopId == 0)
            {
                throw new ConfigurationErrorsException("ShopId is missing in configuration.");
            }

        }

        public async Task<GHNOrderResponse> CreateOrderGHN(object orderData)
        {
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/shipping-order/create";
            client.DefaultRequestHeaders.Add("Token", token);
            client.DefaultRequestHeaders.Add("ShopId", shopId.ToString());
            var content = new StringContent(JsonConvert.SerializeObject(orderData), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GHNOrderResponse>(responseString);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create order", ex);
            }
        }

        public async Task<GHNOrderResponse> GetOrderDetailGHN(string orderCode)
        {
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/shipping-order/detail";
            var content = new StringContent(JsonConvert.SerializeObject(new { order_code = orderCode }), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GHNOrderResponse>(responseString);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve order details", ex);
            }
        }

        public async Task<GHNOrderResponse> CancelOrderGHN(List<string> orderCodes)
        {
            EnsureValidConfiguration();
            var url = $"{BaseUrl}/switch-status/cancel";
            var content = new StringContent(JsonConvert.SerializeObject(new { order_codes = orderCodes, shop_id = ShopId }), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GHNOrderResponse>(responseString);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to cancel order", ex);
            }
        }
    }

}
