using System.ComponentModel;

namespace App.Models
{
    public struct TypeDataModel
    {
        [DisplayName("aspectRatio")]
        public string AspectRatio { get; set; }

        [DisplayName("width")]
        public int Width { get; set; }

        [DisplayName("height")]
        public int Height { get; set; }
    }
}