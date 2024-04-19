
using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Assignment : BaseModel
    {
        [MaxLength(50, ErrorMessage = "Title must not exceed 50 characters.")]
        public string Title { get; set; }

        [MaxLength(1000, ErrorMessage = "Title must not exceed 1000 characters.")]
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Solution> Solutions { get; set; } = [];
    }
}
