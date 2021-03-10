using Microsoft.Extensions.Configuration;

namespace App.Services.ApiRequest
{
    public class UrlCreator : IUrlCreator
    {
        private readonly IConfiguration _Config;
        private readonly string _ApiKey;

        public UrlCreator(IConfiguration config)
        {
            _Config = config;
            _ApiKey = _Config["UrlCreator:ApiKey"];
        }

        

        public string GetBaseUri()
        {
            return $"https://content.guardianapis.com/search?show-blocks=all&api-key={_ApiKey}&show-fields=all&page-size=12";
        }
    }
}