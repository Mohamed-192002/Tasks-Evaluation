using TasksEvaluation.Core.Dtos;

namespace TasksEvaluation.Core.Interfaces.IServices
{
    public interface ICourseServices
    {
        Task<IEnumerable<CourseDto>> GetCourses();
        Task<CourseDto> GetCourse(int id);
        Task<CourseDto> Create(CourseDto model);
        Task Update(CourseDto model);
        Task Delete(int id);
    }
}
