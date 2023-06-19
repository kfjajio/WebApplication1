namespace WebApplication1.Models
{
    public class FieldKnowledge
    {
        public string Id { get; set; }
        public string Name { get; set; }
        ICollection<BookField> BookField { get; set; }
    }
}
