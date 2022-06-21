using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataValidation.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string patientName { get; set; }

        [Required]
        [DisplayName("Appointment Request Date")]
        [DataType(DataType.Date)]
        public DateTime appointmentDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal patientNetWorth { get; set; }

        [Required]
        [DisplayName("Primary Doctor's Last Name")]
        public string doctorName { get; set; }

        [Required]
        [Range(1,10)]
        [DisplayName("patient's Perceived Level of pain (1 low to 10 high)")]
        public int painLevel { get; set; }

    }
}
