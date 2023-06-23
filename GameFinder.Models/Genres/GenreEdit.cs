using System.ComponentModel.DataAnnotations;

namespace GameFinder.Models.Genres
{
    public class GenreEdit
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [MaxLength(200)]
        public string Description {get; set;}
    }
}