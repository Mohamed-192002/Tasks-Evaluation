using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Infrastructure.Configrrutions
{
    public partial class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.FullName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(s => s.MobileNumber)
                .IsRequired();

            builder.Property(s => s.Email)
                .IsRequired();

            builder.Property(s => s.ProfilePicture)
                .HasMaxLength(255);

            builder.HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);
        }
    }
}
