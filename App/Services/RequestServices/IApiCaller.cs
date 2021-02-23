using System.Threading.Tasks;
using App.ViewModels;

namespace App.Services.RequestServices
{
    public interface IApiCaller
    {
        Task<ApiResponseViewModel> CallAPI(string querystring);
    }
}