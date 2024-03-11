

using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Group : BaseModel
    {
        public string Title { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; } = [];
        public ICollection<Assignment> Assignments { get; set; } = [];

    }
}
