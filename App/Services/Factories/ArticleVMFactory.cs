using System.Linq;
using App.Models;
using App.Models.ViewModels;
using App.Services.Factories.Interfaces;

namespace App.Services.Factories
{
    public class ArticleVMFactory : IArticleVMFactory
    {
        public ArticleVM Create(BlocksModel blockModels)
        {
            return new ArticleVM
            {
                BlockModel = blockModels,
                Assets = blockModels.Main.Elements.ToArray()[0].Assets,
                BodyModel = blockModels.Body.ToArray()[0],
                MainBlock = blockModels.Main
            };
        }

       
    }
}