using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models
{
    public struct ResponseModel
    {
        [DisplayName("results")]
        public IEnumerable<ResultsModel> Results { get; set; }
    }
}