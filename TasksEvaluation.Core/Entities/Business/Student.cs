using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Student : BaseModel
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
