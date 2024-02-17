using Task3.Attributes;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace Task3.Models
{
    public class RegistrationFormModel
    {
        [Required]
        [StringLength(70)]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Час регістрації на прийом")]
        [UIHint("DateTime-local")]
        [FutureDate(ErrorMessage = "Дата має бути у майбутньому.")]
        [NoWeekend(ErrorMessage = "Дата не повинна потрапляти на вихідні дні.")]
        public DateTime RegistrationTime { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
