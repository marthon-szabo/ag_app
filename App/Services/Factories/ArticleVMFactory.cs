using System;
using System.Linq;
using App.Models;
using App.Models.ViewModels;
using App.Services.Factories.Interfaces;

namespace App.Services.Factories
{
    public class ArticleVMFactory : IArticleVMFactory
    {

        public ArticleVM Create(BlocksModel blockModels, string webTitle, string publishedDate, string lastModified)
        {
            return new ArticleVM
            {
                BlockModel = blockModels,
                Assets = blockModels.Main.Elements.ToArray()[0].Assets,
                BodyModel = blockModels.Body.ToArray()[0],
                MainBlock = blockModels.Main,
                WebTitle = webTitle,
                PublishedDate = DateTime.Parse(publishedDate),
                LastModified = DateTime.Parse(publishedDate)
            };
        }

       
    }
}