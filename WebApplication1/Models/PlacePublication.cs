namespace WebApplication1.Models
{
    public class PlacePublication
    {
        public string Name { get; set; }
        ICollection<Book> Books { get; set; }
    }
}
