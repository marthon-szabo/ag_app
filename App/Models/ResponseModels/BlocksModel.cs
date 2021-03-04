using System.Collections.Generic;
using System.ComponentModel;

namespace App.Models
{
    public struct BlocksModel
    {
        [DisplayName("main")]
        public MainBlockModel Main { get; set; }
        
        [DisplayName("body")]
        public IEnumerable<BodyModel> Body { get; set; }
    }
}