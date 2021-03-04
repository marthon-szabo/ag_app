using System.ComponentModel;

namespace App.Models
{
    public struct BodyModel
    {
        [DisplayName("id")]
        public string Id { get; set; }
        
        [DisplayName("bodyHtml")]
        public string BodyHtml { get; set; }
    }
}