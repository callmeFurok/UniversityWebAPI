using System.ComponentModel.DataAnnotations;

namespace UniversityWebAPI.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;

        public Level Level { get; set; } = Level.Basic;

        // Add relation to Category table n to n
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<User> Users { get; set; } = new List<User>();



    }
}
