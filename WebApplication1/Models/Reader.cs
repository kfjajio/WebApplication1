namespace WebApplication1.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public int Number { get; set; }
        public string address { get; set; }
        public int NumberTiсket { get; set; }
        public DateTime DateRegistre { get; set; }
        public ICollection <InventoryNumber> InventoryNumbers { get; set; }

    }
}
