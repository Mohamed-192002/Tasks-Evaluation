using FluentValidation;
using TasksEvaluation.Core.Dtos;

namespace TasksEvaluation.Core.Validations
{
    public class CourseValidator : AbstractValidator<CourseDto>
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
