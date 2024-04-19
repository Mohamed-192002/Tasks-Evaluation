namespace TasksEvaluation.Core.Dtos
{
    public class StudentDto : BaseModelDto
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string GroupName { get; set; }
    }
}
