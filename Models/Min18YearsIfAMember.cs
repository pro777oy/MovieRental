
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId==MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
               return ValidationResult.Success;
            }
            else
            {
                if (customer.Birthdate == null)
                {
                    return new ValidationResult("Please enter the birthdate");
                }

                var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

                return (age >= 18) 
                    ? ValidationResult.Success 
                    : new ValidationResult("Customer should be atlease 18 years old to go on a membership");
            }
        }

    }
}