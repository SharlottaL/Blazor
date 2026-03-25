using System.ComponentModel.DataAnnotations;

namespace Academy.Components.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string MiddleName { get; set; }
        [RangeAttribute(typeof(DateOnly), "1888-10-14", "9999-12-31")]
        public DateOnly BirthDate { get; set; }
        public string? Photo { get; set; }
    }
}
