using FluentValidation;
using TasksEvaluation.Core.Entities.Business;
namespace TasksEvaluation.Core.Validations
{
    public class GroupValidator : AbstractValidator<Group>
    {
        public GroupValidator()
        {
            RuleFor(g=>g.Title).NotEmpty().NotNull();

        }
    }
}
