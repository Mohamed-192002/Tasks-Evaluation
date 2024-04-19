using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Infrastructure.Configrrutions
{
    public class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.Property(a => a.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Description)
                .HasMaxLength(1000);

            builder.Property(a => a.Deadline)
                .IsRequired();

            builder.HasOne(a => a.Group)
                .WithMany(g => g.Assignments)
                .HasForeignKey(a => a.GroupId);

            builder.HasMany(a => a.Solutions)
                .WithOne(s => s.Assignment)
                .HasForeignKey(s => s.AssignmentId);
        }
    }
}
