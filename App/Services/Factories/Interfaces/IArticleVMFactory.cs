using App.Models;
using App.Models.ViewModels;

namespace App.Services.Factories.Interfaces
{
    public interface IArticleVMFactory
    {
        ArticleVM Create(BlocksModel blockModels, string webTitle, string thumbnailUrl, string trailText);
    }
}