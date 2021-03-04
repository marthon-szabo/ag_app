namespace App.Services.ApiRequest
{
    public class UrlCreator : IUrlCreator
    {
        private const string _ApiKey = "7a75b617-4388-40dc-80f3-b15f4e0e42f6"; 
        public string GetBaseUri()
        {
            return $"https://content.guardianapis.com/search?show-blocks=all&api-key={_ApiKey}";
        }
    }
}