
using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Course : BaseModel
    {
        [MaxLength(50, ErrorMessage = "Title must not exceed 50 characters.")]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public ICollection<Group> Groups { get; set; } = [];
    }
}
