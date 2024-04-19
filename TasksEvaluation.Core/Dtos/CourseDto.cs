using System.Text.RegularExpressions;

namespace TasksEvaluation.Core.Dtos
{
    public class CourseDto : BaseModelDto
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public IEnumerable<GroupDto> Groups { get; set; }
    }
}
