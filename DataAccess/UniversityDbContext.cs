using Microsoft.EntityFrameworkCore;

namespace UniversityWebAPI.DataAccess
{
    public class UniversityDbContext :DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options): base(options)
        {

        }

        // TODO: Add DbSets (Tables of our Data base)

    }
}
