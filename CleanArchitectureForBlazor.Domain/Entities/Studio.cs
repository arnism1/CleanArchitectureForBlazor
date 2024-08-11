using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureForBlazor.Domain.Entities
{
    public class Studio
    {
        public int StudioId { get; set; } // Primary key
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation property
        public ICollection<Movie> Movies { get; set; }
    }

}
