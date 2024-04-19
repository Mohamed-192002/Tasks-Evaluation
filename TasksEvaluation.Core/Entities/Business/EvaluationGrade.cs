
using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class EvaluationGrade : BaseModel
    {
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Grade { get; set; }

        public ICollection<Solution> Solutions { get; set; } = [];
    }
}
