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
    }
}