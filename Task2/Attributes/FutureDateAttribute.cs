using System.ComponentModel.DataAnnotations;

namespace Task2.Attributes
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateTimeValue = (DateTime)value;

            if (dateTimeValue.Date <= DateTime.Now.Date)
            {
                return new ValidationResult("Дата консультації має бути у майбутньому.");
            }
 
            return ValidationResult.Success;
        }
    }
}