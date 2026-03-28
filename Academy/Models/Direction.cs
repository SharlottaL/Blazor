using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Direction
    {
        [Key]
        public byte direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
        public override bool Equals(object? obj)
        {
            return this.Equals(obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(direction_name);
        }
    }
}
