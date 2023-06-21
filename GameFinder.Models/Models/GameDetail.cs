using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data.Entities;

namespace GameFinder.Models.Models
{
    public class GameDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Rating> Ratings { get; set; }

        public double AverageRating 
        {
            get
            {
                if(Ratings.Count == 0)
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