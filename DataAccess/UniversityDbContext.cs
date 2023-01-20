using Microsoft.EntityFrameworkCore;
using UniversityWebAPI.Models.DataModels;

namespace UniversityWebAPI.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        // 1. Add DbSets (Tables of our Data base)
        public DbSet<User> Users { get; set; }


    }
}
