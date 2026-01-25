using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IbrahimBusaidiWebsite.Data.Users.Enums;

namespace IbrahimBusaidiWebsite.Data.Users.Models
{
    public class Settings
    {
        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;

        public bool EmailNotificationsEnabled { get; set; } = false;
        public bool MarketingEmailsEnabled { get; set; } = false;
        public bool TermsOfServiceAccepted { get; set; } = false;
        public UserEnums.MfaMethod PrefMfaMethod { get; set; } = UserEnums.MfaMethod.None;
    }
}
