using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Validation
{
    class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(20)
                .WithMessage("Custom message");

            RuleFor(x => x.Age)
                .NotEmpty();
        }
    }

    class Passport : ValidationAttribute
    {
        public Passport(string seria)
        {
            Seria = seria;
            ErrorMessage = "Invalid Passport Number";
        }
        
        public string Seria { get; set; }
        public override bool IsValid(object value)
        {
            if (value is string passpotrNumber)
            {
                var regex = new Regex(@"^[A-Z]{2}\d{7}$");
                if(regex.IsMatch(passpotrNumber))
                {
                    if (!string.IsNullOrWhiteSpace(Seria))
                    {
                        return passpotrNumber.StartsWith(Seria);
                    }
                }
            }
            return false;
        }
    }

    class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public bool Check()
        {
            return string.IsNullOrWhiteSpace(Name);
        }
    }
    class Person
    {
        [Author(Name ="Afti")]
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[0-9]{16}$", ErrorMessage = "Invalid Card Number")]
        public string BankCard { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [Range(0,100)]
        public int Age { get; set; }
        [Passport("AA")]
        public string Passport { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "A",
                Surname = "",
                Email = "a@a.a",
                BankCard = "4286531213451234",
                Phone = "324242",
                Age = 10,
                Passport = "AZ1234567"                
            };

            var personValidator = new PersonValidator();
            var result = personValidator.Validate(person);
            Console.WriteLine($"Is Valid: {result.IsValid}");
            if (!result.IsValid)
            {
                foreach (var res in result.Errors)
                {
                    Console.WriteLine(res.ErrorMessage);
                }
            }

            //var context = new ValidationContext(person);

            //var results = new List<ValidationResult>();
            //var isValid = Validator.TryValidateObject(person, context, results, true);
            //// Validator.ValidateObject(person, context, true);
            //if (!isValid)
            //{
            //    foreach (var result in results)
            //    {
            //        Console.WriteLine(result.ErrorMessage);
            //    }
            //}

            // Reflection
            //var type = typeof(Person);
            //foreach (var propInfo in type.GetProperties())
            //{
            //    Console.WriteLine(propInfo.Name);
            //    foreach (var attribute in propInfo.CustomAttributes)
            //    {
            //        Console.WriteLine("  -  " + attribute);
            //    }
            //}
           
        }
    }
}
