using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//To use ValidationAttribute
using System.Text;

namespace CLib_MEmp.CustomizeValidation
{
    ///* The hardcoded case for the domain */ 
    //public class Validate_EmailDomain : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object valueToValidate, ValidationContext VContext)
    //    {
    //        string[] strDomain = valueToValidate.ToString().Split('@');
    //        if (strDomain[1].ToLower() == "pbtech.com")
    //            return null;
    //        return new ValidationResult("The domain must be PBTech.com",
    //               new[] { VContext.MemberName });
    //    }
    //}

    /* Make the domain more reusable by passing it as a parameter */
    public class Validate_EmailDomain : ValidationAttribute
    {
        public string AllowedDOMAIN { get; set; }

        protected override ValidationResult IsValid(object valueToValidate, ValidationContext VContext)
        {
            if (valueToValidate != null)
            {
                string[] strDomain = valueToValidate.ToString().Split('@');
                if (strDomain.Length > 1 &&
                    strDomain[1].ToLower() == AllowedDOMAIN.ToLower())
                    return null;
                return new ValidationResult($"The domain must be {AllowedDOMAIN}",
                       new[] { VContext.MemberName });
            }
            return null;
        }
    }
}
