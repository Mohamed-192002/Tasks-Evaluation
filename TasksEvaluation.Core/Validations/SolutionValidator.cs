using FluentValidation;
using TasksEvaluation.Core.Dtos;

namespace TasksEvaluation.Core.Validations
{
    public class SolutionValidator : AbstractValidator<SolutionDto>
    {
        public SolutionValidator()
        {
            RuleFor(s => s.Notes)
               .MaximumLength(150).WithMessage("Title must not exceed 150 characters!");

            RuleFor(s => s.StudentName)
                .NotEmpty().WithMessage("Student name is required.")
                .MaximumLength(50).WithMessage("Title must not exceed 50 characters!");

            RuleFor(s => s.AssignmentDescription)
                .NotEmpty().WithMessage("Assignment description is required.")
                .MaximumLength(1000).WithMessage("Title must not exceed 1000 characters!");

            RuleFor(s => s.Grade)
                .NotEmpty().WithMessage("Grade is required.");

            RuleFor(s => s.SolutionFile).NotNull().NotEmpty()
                .Must(file =>
                file.EndsWith(".pdf") || file.EndsWith(".zip") || file.EndsWith(".jpeg") || file.EndsWith(".jpg") || file.EndsWith(".png"))
               .WithMessage("Solution file must end with '.pdf' , '.zip' , '.jpeg' , '.jpg' or '.png'");
        }
    }
}
