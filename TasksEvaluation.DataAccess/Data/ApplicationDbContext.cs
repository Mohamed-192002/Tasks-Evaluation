using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TasksEvaluation.Core.Entities.Business;
using TasksEvaluation.Core.Entities.General;
using Group = TasksEvaluation.Core.Entities.Business.Group;

namespace Tasks_Evaluation.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<EvaluationGrade> EvaluationGrades { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
