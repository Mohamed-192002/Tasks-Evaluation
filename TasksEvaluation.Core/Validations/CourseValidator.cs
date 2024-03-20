using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Title)
               .NotEmpty().WithMessage("Title is required")
               .MaximumLength(100).WithMessage("Title must not exceed 100 characters!");

            RuleFor(c => c.IsCompleted)
                .NotNull().WithMessage("IsCompleted must not be null.");

        }
    }
}
