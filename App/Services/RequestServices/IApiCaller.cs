using App.ViewModels;

namespace App.Services.RequestServices
{
    public interface IApiCaller
    {
        ApiViewModel CallAPI(string querystring);
    }
}