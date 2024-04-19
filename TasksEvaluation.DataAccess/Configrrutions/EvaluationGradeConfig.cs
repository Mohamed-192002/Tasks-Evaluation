using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Infrastructure.Configrrutions
{
    public class EvaluationGradeConfig : IEntityTypeConfiguration<EvaluationGrade>
    {
        public void Configure(EntityTypeBuilder<EvaluationGrade> builder)
        {
            builder.Property(eg => eg.Grade)
              .IsRequired();
        }
    }
}
