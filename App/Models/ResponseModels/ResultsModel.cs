using System.ComponentModel;

namespace App.Models
{
    public struct ResultsModel
    {
        [DisplayName("type")]
        public string Type { get; set; }

        [DisplayName("blocks")]
        public BlocksModel Blocks { get; set; }
        public string PublishedDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string WebTitle { get; set; }
    }
}