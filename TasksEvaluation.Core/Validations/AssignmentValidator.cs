using FluentValidation;
using TasksEvaluation.Core.Dtos;

namespace TasksEvaluation.Core.Validations
{
    public class AssignmentValidator : AbstractValidator<AssignmentDto>
    {
        public AssignmentValidator()
        {
            RuleFor(a => a.Title)
                           .NotEmpty().WithMessage("Title is required.")
                           .MaximumLength(50).WithMessage("Title must not exceed 50 characters.");

            RuleFor(a => a.Description)
                .MaximumLength(1000).WithMessage("Description must not exceed 1000 characters.");

            RuleFor(a => a.GroupName)
                .NotEmpty().WithMessage("Group name is required.")
                .MaximumLength(50).WithMessage("Title must not exceed 50 characters.");
        }
    }
}
