using System.ComponentModel.DataAnnotations;

namespace MMSWebApp2.Validation
{
    public class MaxDateToday : ValidationAttribute
    {
        public MaxDateToday() : base("The date cannot be in the future.") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date <= DateTime.Today)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage); // Or a specific error message
                }
            }
            return ValidationResult.Success; // Or handle non-DateTime types if needed
        }
    }
}
