using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IbrahimBusaidiWebsite.Data.BusaidiAirlines.Models
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "IATA Code is required")]
        [StringLength(5, ErrorMessage = "IATA Code must not exceed 5 characters")]
        // Used for passengers to show airport/airline code, ie: MCT -> Muscat / WY -> Oman Air
        public string IataCode { get; set; } = default!;

        [StringLength(5, ErrorMessage = "ICAO Code must not exceed 5 characters")]
        // Used by air traffic control/pilots/operations as code for airports/airlines, ie: OOMS -> Oman / OMA -> Oman Air
        public string? IcaoCode { get; set; }

        [Required(ErrorMessage = "Airport name is required")]
        [StringLength(100, ErrorMessage = "Airport name must not exceed 100 characters")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Airport country name is required")]
        [StringLength(10, ErrorMessage = "Airport country name must not exceed 10 characters")]
        public string CountryCode { get; set; } = default!;

        [Required(ErrorMessage = "Airport city name is required")]
        [StringLength(100, ErrorMessage = "Airport city name must not exceed 100 characters")]
        public string City { get; set; } = default!;

        public bool IsActive { get; set; } = true;

        public string TimeZoneId { get; set; } = default!;

        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }
}
