using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Solution : BaseModel
    {
        public string SolutionFile { get; set; }
        [MaxLength(100, ErrorMessage = "Notes must not exceed 100 characters.")]
        public string Notes { get; set; }
        public int? GradeId { get; set; }
        public EvaluationGrade Grade { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        public int? AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

    }
}
