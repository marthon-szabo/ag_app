using System.Collections.Generic;

namespace App.Models.ViewModels
{
    public struct MultipleArticleVM
    {
        public IEnumerable<ArticleVM> Articles { get; set; }
    }
}