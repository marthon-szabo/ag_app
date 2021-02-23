using System.Collections.Generic;
using App.Services.Factories.Interfaces;
using App.ViewModels;

namespace App.Services.RequestServices
{
    public class ArticleViewModelFactory : IArticleViewModelFactory
    {
        public IEnumerable<ArticleViewModel> Create(string[] results)
        {
            throw new System.NotImplementedException();
        }
    }
}