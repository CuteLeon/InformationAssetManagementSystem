using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IAMS.Client.Utils
{
    public static class WebHelper
    {
        private static HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(5000) };

        public static void SetSessionKey(string key)
        {
            httpClient.DefaultRequestHeaders.Add("SessionKey", key);
        }

        public static async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            try
            {
                return await httpClient.GetAsync(requestUri);
            }
            catch
            {
                throw;
            }
        }

        public static async Task<string> GetStringAsync(string requestUri)
        {
            try
            {
                return await httpClient.GetStringAsync(requestUri);
            }
            catch
            {
                throw;
            }
        }

        public static async Task<HttpResponseMessage> PostAsync(string requestUri, string formValue, string formKey = "value")
        {
            try
            {
                var form = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>(formKey, formValue) });
                return await httpClient.PostAsync(requestUri, form);
            }
            catch
            {
                throw;
            }
        }
    }
}
