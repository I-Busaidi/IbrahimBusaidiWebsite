using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IbrahimBusaidiWebsite.Data.Users.Models
{
    public class Profile
    {
        // Shared PK + FK
        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = default!;
        // one-to-one relation between User & UserProfile
        public User User { get; set; } = default!;

        public string? DisplayName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? Nationality { get; set; }
        public string? TimeZone { get; set; }
    }
}
