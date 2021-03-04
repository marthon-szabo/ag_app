using System.Runtime.InteropServices.ComTypes;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using App.Models;

namespace App.Services.ApiRequest
{
    public class ApiRequestService : IApiRequestService
    {
        private readonly HttpClient Client = new HttpClient();
        private readonly IUrlCreator _UrlCreator;

        public ApiRequestService(IUrlCreator urlCreator)
        {
            _UrlCreator = urlCreator;
        }
    
        public async Task<IEnumerable<ResultsModel>> Call()
        {
            Client.BaseAddress = new Uri(_UrlCreator.GetBaseUri());
            ResponseRootModel root;
            HttpResponseMessage httpResponseMessage = Client.GetAsync(_UrlCreator.GetBaseUri()).Result;
            
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                root = await httpResponseMessage.Content.ReadAsAsync<ResponseRootModel>();
                Client.Dispose();

                System.Console.WriteLine(root);

                return root.Response.Results;
            }
            else
            {
                Client.Dispose();

                return null;
            }

            
        }
    }
}