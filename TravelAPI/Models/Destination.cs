using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        [Required]
        [StringLength(20)]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Please enter a value between 0 and 5.")]
        public int Rating { get; set; }
        [Required]
        public string Review { get; set; }
        public string Date { get; set; }

    }

}