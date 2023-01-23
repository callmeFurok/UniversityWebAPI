using System.ComponentModel.DataAnnotations;

namespace UniversityWebAPI.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirtg { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
