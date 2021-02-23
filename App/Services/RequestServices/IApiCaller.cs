using App.ViewModels;

namespace App.Services.RequestServices
{
    public interface IApiCaller
    {
        ArticleViewModel CallAPI(string querystring);
    }
}