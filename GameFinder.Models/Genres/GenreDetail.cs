using System.ComponentModel.DataAnnotations;
using GameFinder.Models.Models;

namespace GameFinder.Models.Genres
{
    public class GenreDetail
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [MaxLength(200)]
        public string Description {get; set;}
        public virtual List<GameListItem> Games { get; set; }
    }
}