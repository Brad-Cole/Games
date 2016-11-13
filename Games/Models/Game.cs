using System.Data.Entity;

namespace Games.Models
{
    //properties for the Games
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
    }
    //for entity
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}