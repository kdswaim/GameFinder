using System.ComponentModel.DataAnnotations;

namespace GameFinder.Data.Entities
{
    public class Genre
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [MaxLength(200)]
        public string Description {get; set;}
        public virtual List<Game> Games { get; set; }
    }
}