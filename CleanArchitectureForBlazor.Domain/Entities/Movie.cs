using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureForBlazor.Domain.Entities
{
    public class Movie
    {
        public int MovieId { get; set; } // Primary key
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }

        // Navigation properties
        public int? StudioId { get; set; }
        public Studio Studio { get; set; }

        // Relationship with Review
        public ICollection<Review>? Reviews { get; set; }

        // Relationship with Actor
        public ICollection<MovieActor>? MovieActors { get; set; }
    }

}
