using System.ComponentModel.DataAnnotations;

namespace Task2.Attributes
{
    public class NoWeekendAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateTimeValue = (DateTime)value;

            if (dateTimeValue.DayOfWeek == DayOfWeek.Saturday || dateTimeValue.DayOfWeek == DayOfWeek.Sunday)
            {
                return new ValidationResult("Дата консультації не повинна потрапляти на вихідні дні.");
            }

            return ValidationResult.Success;
        }
    }
}