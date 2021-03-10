using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models
{
    public struct ResponseModel
    {
        public IEnumerable<ResultsModel> Results { get; set; }
    }
}