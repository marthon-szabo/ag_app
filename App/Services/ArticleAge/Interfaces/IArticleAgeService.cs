using System;
namespace App.Services.ArticleAge.Interfaces
{
    public interface IArticleAgeService
    {
        string CountMyAge(DateTime lastModified);
    }
}