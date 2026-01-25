using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IbrahimBusaidiWebsite.Data.Users.Models
{
    // inherits the user model from AspNetCore Identity package
    public class User : IdentityUser
    {
        // Adding a User Profile & Addresses for each user
        public Profile? Profile { get; set; }
        public Settings? Settings { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
