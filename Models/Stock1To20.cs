using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class Stock1To20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movies = (Movie)validationContext.ObjectInstance;

            if (movies.NumberInStock >=1)
            {
                return ValidationResult.Success;
            }
            else if 

            (movies.NumberInStock == 0)
            {
                return new ValidationResult("Please enter the Number in Stock");
            }

            return ValidationResult.Success;
        }    
    }
}
