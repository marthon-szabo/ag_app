using System.Collections.Generic;
using System.Text.Json;
using App.Services.Factories.Interfaces;
using App.ViewModels;

namespace App.Services.Factories
{
    public class ArticleViewModelFactory : IArticleViewModelFactory
    {
        public IEnumerable<ArticleViewModel> Create(string[] results)
        {
            throw new System.NotImplementedException();
        }

        private ResultViewModel CreateResultVM(string result)
        {
            return JsonSerializer.Deserialize<ResultViewModel>(result);
        }
    }
}