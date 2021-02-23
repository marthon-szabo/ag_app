using System;
using System.Collections.Generic;

namespace App.ViewModels
{
    public struct ArticleViewModel
    {
        public string Id { get; set; }
        public IEnumerable<ArticleAssetViewModel> Assets { get; set; }
        public string BodyHtml { get; set; }
        public string Type { get; set; }
        public string SectionName { get; set; }
        public DateTime WebPublicationDate { get; set; }
        public DateTime WebTitle { get; set; }

    }
}