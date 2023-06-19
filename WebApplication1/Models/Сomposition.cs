namespace WebApplication1.Models
{
    public class Сomposition
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<BookComposition> BookCompositions { get; set; }
        
    } 
}
