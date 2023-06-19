using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ElectricLibrary;Trusted_Connection=true;TrustServerCercificate=true;");
        }
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookAuthor> bookAuthors { get; set; }     
        public DbSet<BookComposition> bookCompositions { get; set; }
        public DbSet<BookField> bookFields { get; set; }
        public DbSet<FieldKnowledge> fieldKnowledges { get; set; }
        public DbSet<InventoryNumber> inventoryNumbers { get; set; }
        public DbSet<PlacePublication> placePublications { get; set; }
        public DbSet<Publishment> publishments { get; set; }
        public DbSet<Reader> readers { get; set; }
        public DbSet<Сomposition> compositions { get; set; }
    }
}
