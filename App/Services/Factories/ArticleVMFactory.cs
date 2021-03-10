using System.Text.RegularExpressions;
using System;
using System.Linq;
using App.Models;
using App.Models.ViewModels;
using App.Services.Factories.Interfaces;

namespace App.Services.Factories
{
    public class ArticleVMFactory : IArticleVMFactory
    {

        public ArticleVM Create(BlocksModel blockModels, string webTitle, string thumbnailUrl, string trailText)
        {
            trailText ??= "No description available";

            string picture = Regex.Replace(blockModels.Main.BodyHtml, @"\\", "");

            return new ArticleVM
            {
                BlockModel = blockModels,
                Assets = blockModels.Main.Elements.ToArray()[0].Assets,
                BodyModel = blockModels.Body.ToArray()[0],
                MainBlock = blockModels.Main,
                WebTitle = webTitle,
                PublishedDate = (blockModels.Main.PublishedDate != null) ? DateTime.Parse(blockModels.Main.PublishedDate) : null,
                LeadImage = picture,
                LastModified = (blockModels.Main.LastModifiedDate != null) ? DateTime.Parse(blockModels.Main.LastModifiedDate) : null,
                Thumbnail = thumbnailUrl,
                TrailText = trailText
            };
        }

       
    }
}