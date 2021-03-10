using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using App.Models.ResponseModels;

namespace App.Models.ViewModels
{
    public struct ArticleVM
    {
        public IEnumerable<AssetModel> Assets { get; set; }
        public BlocksModel BlockModel { get; set; }
        public MainBlockModel MainBlock { get; set; }
        public BodyModel BodyModel { get; set; }
        public string WebTitle { get; set; }
        public string LeadImage { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public string Thumbnail { get; set; }

        public string TrailText { get; set; }
    }
}