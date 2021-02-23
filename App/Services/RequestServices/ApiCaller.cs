using System;
using System.Net.Http;
using System.Threading.Tasks;
using App.ViewModels;

namespace App.Services.RequestServices
{
    public class ApiCaller : IApiCaller
    {

        public ApiCaller()
        {
            CheckClient();
        }

        private static HttpClient Client;

        public async Task<ApiResponseViewModel> CallAPI(string querystring)
        {
            HttpResponseMessage response = await Client.GetAsync(querystring);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ApiResponseViewModel>();
            }

            throw new ArgumentException("Invalid querystring!");
        }

        private void CheckClient()
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }
        }
    }
}