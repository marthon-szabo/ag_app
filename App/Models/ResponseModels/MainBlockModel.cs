using System.Collections.Generic;
using System.ComponentModel;
using App.Models.ResponseModels;

namespace App.Models
{
    public struct MainBlockModel
    {
        public string Id { get; set; }

        public string BodyHtml { get; set; }

        public string PublishedDate { get; set; }

        public string LastModifiedDate { get; set; }

        public IEnumerable<ElementsModel> Elements { get; set; }
    }
}