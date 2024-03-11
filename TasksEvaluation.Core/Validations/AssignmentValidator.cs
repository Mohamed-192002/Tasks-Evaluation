using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class AssignmentValidator : AbstractValidator<Assignment>
    {
        public AssignmentValidator()
        {
            RuleFor(c => c.Title).NotEmpty().NotNull();

        }
    }
}
