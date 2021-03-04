using System.ComponentModel;

namespace App.Models
{
    public struct ResultsModel
    {
        [DisplayName("type")]
        public string Type { get; set; }

        [DisplayName("blocks")]
        public BlocksModel Blocks { get; set; }
    }
}