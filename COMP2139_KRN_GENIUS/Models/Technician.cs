using System.ComponentModel.DataAnnotations;

namespace COMP2139_KRN_GENIUS.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the technician")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter the phone number")]
        public string? Phone { get; set; }
    }
}
