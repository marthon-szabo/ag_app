using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models;

namespace App.Services.ApiRequest
{
    public interface IApiRequestService
    {
        Task<IEnumerable<ResultsModel>> Call();
    }
}