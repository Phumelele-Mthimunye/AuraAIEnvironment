using FluentValidation;

namespace Aura.Application.Users.Commands.CreateUser;

public class CreateUserValidator 
    : AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();


        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100);


        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(100);
    }
}