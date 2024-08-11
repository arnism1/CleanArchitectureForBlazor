using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureForBlazor.Domain.Entities
{
    public class Actor
    {
        public int ActorId { get; set; } // Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Biography { get; set; }

        // Relationship with Movie
        public ICollection<MovieActor> MovieActors { get; set; }
    }

}
