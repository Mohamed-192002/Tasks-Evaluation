using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class AssignmentValidator : AbstractValidator<Assignment>
    {
        public AssignmentValidator()
        {
            RuleFor(a => a.Title)
                           .NotEmpty().WithMessage("Title is required.")
                           .MaximumLength(255).WithMessage("Title must not exceed 255 characters.");

            RuleFor(a => a.Description)
                .MaximumLength(1000).WithMessage("Description must not exceed 1000 characters.");

        }
    }
}
