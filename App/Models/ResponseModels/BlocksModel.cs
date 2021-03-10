using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models
{
    public struct BlocksModel
    {
        public MainBlockModel Main { get; set; }
        
        public IEnumerable<BodyModel> Body { get; set; }
    }
}