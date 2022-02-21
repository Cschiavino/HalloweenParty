using System.ComponentModel.DataAnnotations;
namespace Halloween_Party.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your time of arrival")]
        [DataType(DataType.Time)]
        public DateTime ArrivalTime { get; set; }

        [Required(ErrorMessage = "Please enter whether or not you need parking")]
        public bool RequestParking { get; set; }
    }
}
