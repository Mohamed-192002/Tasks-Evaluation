namespace TasksEvaluation.Core.Dtos
{
    public class AssignmentDto : BaseModelDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public IEnumerable<SolutionDto> Solutions { get; set; }
    }
}
