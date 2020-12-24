using Contact_App.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.Validators
{
    class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().MinimumLength(8);
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor()
        }
    }
}
