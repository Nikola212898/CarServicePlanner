using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace CarServicePlanner.Models
{
    public class Car : IValidatableObject
    {
         public int Id { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; } = string.Empty;

        [Range(1950, 2100)]
        [Display(Name = "Year")]
        public int Year { get; set; } 

        [Range(0, int.MaxValue)]
        [Display(Name = "Mileage (km)")]
        public int Mileage { get; set; } //kilometraza

        [Required]
        [Display(Name = "Registration number")]
        public string RegistrationNumber { get; set; } = string.Empty;

        public string? Vin {  get; set; }     // VIN broj

        [Display(Name = "Next service date")]
        public DateTime? NextServiceData { get; set; }// Datum sledeceg servisa (moze biti null)

        [Display(Name = "Notes")]
        public string? Notes { get; set; } // Dodatne napomene

        public ICollection<ServiceRecord>? ServiceRecords { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NextServiceData.HasValue && NextServiceData.Value.Date < DateTime.Today)
            {
                yield return new ValidationResult(
                    "Next service date cannot be in the past.",
                    new[] { nameof(NextServiceData) }
                );
            }
        }

    }
}
