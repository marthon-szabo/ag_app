namespace App.ViewModels
{
    public struct ApiResponseViewModel
    {
        public string Status { get; set; }
        public string UserTier { get; set; }
        public int Total { get; set; }
        public int StartIndex { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int Pages { get; set; }
        public string OrderBy { get; set; }
        public string[] Results { get; set; }
    }
}