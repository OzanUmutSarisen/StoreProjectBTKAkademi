namespace StoreApp.Models
{
    public class Pagination
    {
        public int TotalItem { get; set; }
        public int ItemsPerpage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItem/ItemsPerpage);
    }
}