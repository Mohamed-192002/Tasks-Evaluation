namespace TasksEvaluation.Core.Entities.General
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpDate { get; set; }
        public bool IsDeleted { get; set; } = default;
    }
}
