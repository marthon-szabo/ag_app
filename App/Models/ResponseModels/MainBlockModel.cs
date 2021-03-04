using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models
{
    public struct MainBlockModel
    {
        [DisplayName("id")]
        public string Id { get; set; }

        [DisplayName("bodyHtml")]
        public string LeadImage { get; set; }

        [DisplayName("publishedDate")]
        public string PublishedDate { get; set; }

        [DisplayName("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [DisplayName("elements")]
        public IEnumerable<ElementsModel> Elements { get; set; }
    }
}