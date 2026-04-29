using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy2.Models
{
    public class Human
    {

        [Required, Display(Name = "Фамилия")]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        [Display(Name = "Отчество")]
        public string? middle_name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly birth_date { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        [Column(TypeName = "image")]
        public byte[]? photo { get; set; }
        public int year => DateTime.Now.Year - birth_date.Year;
        public int Age
        {
            get => DateTime.Now.Month > birth_date.Month  || DateTime.Now.Month == birth_date.Month && DateTime.Now.Day >= birth_date.Day  ? year : year - 1;
        }


    }
}
