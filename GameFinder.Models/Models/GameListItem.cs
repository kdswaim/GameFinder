using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Models
{
    public class GameListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double AverageRating { get; set; }
    }
}