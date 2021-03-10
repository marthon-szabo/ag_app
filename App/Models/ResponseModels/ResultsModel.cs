using App.Models.ResponseModels;

namespace App.Models
{
    public struct ResultsModel
    {
        public string Type { get; set; }

        public BlocksModel Blocks { get; set; }
        
        public string WebTitle { get; set; }

        public FieldModel Fields { get; set; }
    }
}