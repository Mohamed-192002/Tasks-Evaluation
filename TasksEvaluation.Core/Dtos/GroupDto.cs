namespace TasksEvaluation.Core.Dtos
{
    public class GroupDto : BaseModelDto
    {
        public string Title { get; set; }
        public string CourseName { get; set; }
        public IEnumerable<StudentDto> Students { get; set; }
        public IEnumerable<AssignmentDto> Assignments { get; set; }
    }
}
