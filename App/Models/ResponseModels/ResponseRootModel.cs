using System.ComponentModel;

namespace App.Models
{
    public struct ResponseRootModel
    {
        [DisplayName("response")]
        public ResponseModel Response { get; set; }
    }
}