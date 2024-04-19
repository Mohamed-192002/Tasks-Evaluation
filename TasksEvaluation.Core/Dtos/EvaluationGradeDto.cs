namespace TasksEvaluation.Core.Dtos
{
    public class EvaluationGradeDto : BaseModelDto
    {
        public string Grade { get; set; }
        public IEnumerable<SolutionDto> Solutions { get; set; }
    }
}
