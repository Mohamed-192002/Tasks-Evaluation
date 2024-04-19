using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Infrastructure.Configrrutions
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Title)
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(c => c.IsCompleted)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .IsRequired();

            builder.HasMany(c => c.Groups)
                .WithOne(g => g.Course)
                .HasForeignKey(g => g.CourseId);
        }
    }
}
