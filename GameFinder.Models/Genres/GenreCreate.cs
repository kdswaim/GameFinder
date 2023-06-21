using System.ComponentModel.DataAnnotations;

namespace GameFinder.Models.Genres
{
    public class GenreCreate
    {
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}

        [Required]
        [MaxLength(200)]
        public string Description {get; set;}       
    }
}