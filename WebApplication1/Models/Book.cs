namespace WebApplication1.Models
{
    public class Book
    {
        public int id_book { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public ICollection<BookAuthor> BookAuthor { get; set;}
        public ICollection<BookField> BookField { get; set;}
        public ICollection<InventoryNumber> InventoryNumbers { get; set;}
        public ICollection<BookComposition>  BookCompositions { get; set;}  

    }
}
