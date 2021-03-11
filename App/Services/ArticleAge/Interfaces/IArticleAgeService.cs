using App.Models.ViewModels;

namespace App.Services.ArticleAge.Interfaces
{
    public interface IArticleAgeService
    {
        string CountMyAge(ArticleVM articleVM);
    }
}