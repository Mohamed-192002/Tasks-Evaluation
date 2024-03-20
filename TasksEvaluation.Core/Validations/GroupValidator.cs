using FluentValidation;
using TasksEvaluation.Core.Entities.Business;
namespace TasksEvaluation.Core.Validations
{
    public class GroupValidator : AbstractValidator<Group>
    {
        public GroupValidator()
        {
            RuleFor(g => g.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters!");

        }
    }
}
