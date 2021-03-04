using System.Collections.Generic;
using App.Models;
using App.Models.ViewModels;

namespace App.Services.ResponseProcessor.Interfaces
{
    public interface IResponseProcessorService
    {
        MultipleArticleVM ProcessResponse(IEnumerable<ResultsModel> resultsModels);
    }
}