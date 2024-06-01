using CollageManagmentSystem.businessLogicLayer.MagicData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CollageManagmentSystem.businessLogicLayer.CustomDataAnnotations
{
    internal class MajorAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Major is Required .. ");
            }
            string inputValue = Regex.Replace(value.ToString().ToLower(), @"\s+", "");

            foreach (string major in MagicLists.MajorList)
            {
                string processedMajor = Regex.Replace(major.ToLower(), @"\s+", "");
                if (processedMajor == inputValue)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Invalid Major...");




            return ValidationResult.Success;
        }
    }
}
