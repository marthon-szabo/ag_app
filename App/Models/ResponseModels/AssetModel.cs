using System.ComponentModel;

namespace App.Models
{
    public struct AssetModel
    {
        public string File { get; set; }

        [DisplayName("typeData")]
        public TypeDataModel TypeDataModel { get; set; }
    }
}