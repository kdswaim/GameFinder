using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Data.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Game")]
        public int GameId { get; set; }

        [Required]
        public double Score { get; set; }
    }
}