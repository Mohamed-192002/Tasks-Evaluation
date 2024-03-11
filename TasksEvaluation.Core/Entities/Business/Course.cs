
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Course:BaseModel
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = default;

        public ICollection<Group> Groups { get; set; } = [];
    }
}
