using System.ComponentModel.DataAnnotations;
namespace BiblioNetAPP2.Validations
{
    public class FirstCapitalLetter : ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstLettre = value.ToString()[0].ToString();
            if (firstLettre != firstLettre.ToUpper())
            {
                return new ValidationResult("The firts letter must be in  uppercase");
            }
            return ValidationResult.Success;
        }

    }
}
