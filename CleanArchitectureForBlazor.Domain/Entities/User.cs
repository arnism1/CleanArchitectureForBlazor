using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureForBlazor.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; } // Primary key
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }

        // Navigation property
        public ICollection<Review> Reviews { get; set; }
    }

}
