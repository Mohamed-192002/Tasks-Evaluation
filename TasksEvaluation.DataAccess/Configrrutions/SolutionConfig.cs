using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Infrastructure.Configrrutions
{
    public class SolutionConfig : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.Property(s => s.SolutionFile)
                .IsRequired()
               .HasMaxLength(255)
               .HasAnnotation("FileNamePattern", new Regex(@"\.(pdf|zip|jpeg|jpg|png)$", RegexOptions.IgnoreCase).ToString());

            builder.Property(s => s.Notes)
                .HasMaxLength(100);

            builder.HasOne(s => s.Grade)
                .WithMany(g => g.Solutions)
                .HasForeignKey(s => s.GradeId);

            builder.HasOne(s => s.Student)
                .WithMany(s => s.Solutions)
                .HasForeignKey(s => s.StudentId);

            builder.HasOne(s => s.Assignment)
                .WithMany(a => a.Solutions)
                .HasForeignKey(s => s.AssignmentId);
        }
    }
}
