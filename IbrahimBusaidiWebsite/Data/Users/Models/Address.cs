using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using IbrahimBusaidiWebsite.Data.Users.Enums;

namespace IbrahimBusaidiWebsite.Data.Users.Models
{
    // Composite PK
    [PrimaryKey(nameof(AddressId), nameof(UserId))]
    public class Address
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;

        [Required(ErrorMessage = "Address ID is required")]
        public int AddressId { get; set; }
        [StringLength(100, ErrorMessage = "Address name must not exceed 100 characters")]
        public string? AddressName { get; set; }
        public UserEnums.AddressType AddressType { get; set; }
        public bool IsDefault { get; set; }

        [Required(ErrorMessage = "Recipient name is required")]
        [StringLength(100, ErrorMessage = "Recipient name must not exceed 100 characters")]
        public string RecipientName { get; set; } = default!;
        [Required(ErrorMessage = "Recipient phone is required")]
        [StringLength(25, ErrorMessage = "Recipient phone number must not exceed 25 characters")]
        public string RecipientPhone { get; set; } = default!;

        [Required(ErrorMessage = "Address line 1 is required")]
        [StringLength(100, ErrorMessage = "Line 1 address must not exceed 100 characters")]
        public string Line1 { get; set; } = default!;
        [StringLength(100, ErrorMessage = "Line 2 address must not exceed 100 characters")]
        public string? Line2 { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(25, ErrorMessage = "Country must not exceed 25 characters")]
        public string Country {  get; set; } = default!;
    }
}
