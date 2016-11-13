using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Games.Models
{
    //properties for the Games
    public class Game
    {
        public int ID { get; set; }
        //Added validation
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Platform { get; set; }
        [Range(0.01, 100000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
    //for entity
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}