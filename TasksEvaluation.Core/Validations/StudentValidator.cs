using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FullName)
              .NotEmpty().WithMessage("Full Name is required.")
              .MaximumLength(255).WithMessage("Full Name must not exceed 255 characters.");

            RuleFor(s => s.MobileNumber)
                .NotEmpty().WithMessage("Mobile Number is required.")
                .Matches("^01[0,1,2,5]{1}[0-9]{8}$").WithMessage("Mobile Number must contain only digits.");

            RuleFor(s => s.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Must enter a valid email address.");

            RuleFor(s => s.ProfilePicture)
                .MaximumLength(255).WithMessage("Profile Picture Url must not exceed 255 characters.");

        }
    }
}
