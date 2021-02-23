using System.Collections.Generic;
using App.ViewModels;

namespace App.Services.Factories.Interfaces
{
    public interface IArticleViewModelFactory
    {
        IEnumerable<ArticleViewModel> Create(ApiResponseViewModel results);
    }
}