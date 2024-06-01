using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageManagmentSystem.businessLogicLayer.CustomDataAnnotations
{
    internal class GPAAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("GPA is required.");
            }

            if (double.TryParse(value.ToString(), out double gpa))
            {
                if (gpa <= 0 || gpa >= 4)
                {
                    return new ValidationResult("GPA must be between 0 and 4.");
                }
            }
            else
            {
                return new ValidationResult("GPA must be a numeric value.");
            }

            return ValidationResult.Success;
        }
    }
}
