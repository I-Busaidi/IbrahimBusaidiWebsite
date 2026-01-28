using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IbrahimBusaidiWebsite.Data.Shared.Models
{
    public class TimeZoneCatalogItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Time zone ID must not exceed 100 characters")]
        public string TimeZoneId { get; set; } = default!;

        [StringLength(100, ErrorMessage = "Time zone label name must not exceed 100 characters")]
        public string Label { get; set; } = default!;
        public bool IsEnabled { get; set; } = true;
        public int SortOrder { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
