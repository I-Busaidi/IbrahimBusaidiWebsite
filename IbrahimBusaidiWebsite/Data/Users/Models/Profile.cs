using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IbrahimBusaidiWebsite.Data.Users.Enums;

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

        [StringLength(30, ErrorMessage = "Display name must not exceed 30 characters")]
        public string? DisplayName { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public UserEnums.PrefLanguage PreferredLanguage { get; set; }

        [StringLength(30, ErrorMessage = "Nationality name must not exceed 30 characters")]
        public string? Nationality { get; set; }
        public string? TimeZone { get; set; }
    }
}
