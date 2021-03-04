using System.Collections.Generic;
using App.Models;
using App.Models.ResponseModels;
using App.Models.ViewModels;

namespace App.Services.Factories.Interfaces
{
    public interface IArticleVMFactory
    {
        ArticleVM Create(BlocksModel blockModels);
    }
}