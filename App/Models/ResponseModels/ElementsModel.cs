using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models.ResponseModels
{
    public struct ElementsModel
    {
        [DisplayName("assets")]
        public IEnumerable<AssetModel> Assets { get; set; }
    }
}