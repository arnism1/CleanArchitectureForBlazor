using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureForBlazor.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; } // Primary key
        public int Rating { get; set; } // Rating out of 10
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        // Navigation properties
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
