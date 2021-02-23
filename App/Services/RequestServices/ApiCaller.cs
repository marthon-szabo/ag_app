using System.Net.Http;
using App.ViewModels;

namespace App.Services.RequestServices
{
    public class ApiCaller : IApiCaller
    {

        private static HttpClient Client;

        public ArticleViewModel CallAPI(string querystring)
        {
            throw new System.NotImplementedException();
        }

        private void CreateClient()
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }
        }
    }
}