using FluentValidation;
using TasksEvaluation.Core.Dtos;
namespace TasksEvaluation.Core.Validations
{
    public class GroupValidator : AbstractValidator<GroupDto>
    {
        public GroupValidator()
        {
            RuleFor(g => g.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters!");

            RuleFor(g => g.CourseName)
                .NotEmpty().WithMessage("Course name is required.");
        }
    }
}
