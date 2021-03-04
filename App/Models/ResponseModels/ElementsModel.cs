using System.Collections.Generic;
using System.ComponentModel;
using App.Models.ResponseModels;

namespace App.Models
{
    public struct ElementsModel
    {
        [DisplayName("assets")]
        public IEnumerable<AssetModel> Assets { get; set; }
    }
}