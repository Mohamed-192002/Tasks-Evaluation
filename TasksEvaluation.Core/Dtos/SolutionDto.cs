namespace TasksEvaluation.Core.Dtos
{
    public class SolutionDto : BaseModelDto
    {
        public string SolutionFile { get; set; }
        public string Notes { get; set; }
        public int Grade { get; set; }
        public string StudentName { get; set; }
        public string AssignmentDescription { get; set; }
    }
}
