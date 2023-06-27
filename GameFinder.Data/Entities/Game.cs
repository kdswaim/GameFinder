using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameFinder.Data.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public double AverageRating
        {
            get
            {
                if (Ratings.Count == 0)
                    return 0;

                double total = 0.0;
                foreach (Rating rating in Ratings)
                {
                    total += rating.Score;
                }
                return total / Ratings.Count;
            }
        }
    }
}