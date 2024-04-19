using FluentValidation;
using TasksEvaluation.Core.Dtos;

namespace TasksEvaluation.Core.Validations
{
    public class EvaluationGradeValidator : AbstractValidator<EvaluationGradeDto>
    {
        public EvaluationGradeValidator()
        {
            RuleFor(e => e.Grade)
                .NotNull().WithMessage("Grade must have a value")
                .InclusiveBetween("0", "100").WithMessage("Grade must be between 0 and 100");
        }
    }
}
