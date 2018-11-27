using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;

namespace WpfApp1
{
    class Validator : AbstractValidator<Person>
    {
        public Validator()
        {
            RuleFor(Person => Person.Name).NotEmpty().WithMessage("Křesní jméno nesmí být prázdné");
            RuleFor(Person => Person.Name).NotEqual(Person => Person.Surname).WithMessage("Příjmení se nemůže rovnat s křesním jménem");
            RuleFor(Person => Person.Surname).NotEmpty().WithMessage("Přijmení nesmí být prázdné");
            RuleFor(Person => Person.Surname).NotEqual(Person => Person.Name).WithMessage("Příjmení se nemůže rovnat s křesním jménem");
            RuleFor(Person => Person.Email).EmailAddress().WithMessage("Zadejte validní Email");
        }

        internal void ValidateAndThrow(object customer)
        {
            throw new NotImplementedException();
        }



    }
}
