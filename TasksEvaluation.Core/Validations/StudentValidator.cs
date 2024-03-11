using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s=>s.FullName).NotEmpty().NotNull();
            RuleFor(s => s.MobileNumber).NotEmpty().NotNull();
            RuleFor(s => s.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(s => s.ProfilePicture).NotNull();

        }
    }
}
