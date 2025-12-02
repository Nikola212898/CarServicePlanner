using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarServicePlanner.Models
{
    public class ServiceRecord : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Car")]
        public int CarId { get; set; }     // strani kljuc ka Car

        public Car? Car { get; set; }      // navigaciona veza

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Service date")]
        public DateTime ServiceDate { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Service type")]
        public string? ServiceType { get; set; }   // npr. Oil change, Inspection...

        [Display(Name = "Mileage at service (km)")]
        public int? MileageAtService { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Cost")]
        public decimal? Cost { get; set; }

        [StringLength(500)]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ServiceDate.Date > DateTime.Today)
            {
                yield return new ValidationResult(
                    "Service date cannot be in the future.",
                    new[] { nameof(ServiceDate) }
                );
            }
        }
    }
}
