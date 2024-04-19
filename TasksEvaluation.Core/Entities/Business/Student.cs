using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.General;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Student : BaseModel
    {
        [MaxLength(50, ErrorMessage = "Title must not exceed 50 characters.")]
        public string FullName { get; set; }

        [RegularExpression("^01[0,1,2,5]{1}[0-9]{8}$", ErrorMessage = "Mobile Number must contain only digits.")]
        public string MobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(255, ErrorMessage = "Profile Picture Url must not exceed 255 characters.")]
        public string ProfilePicture { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Solution> Solutions { get; set; } = [];
    }
}
