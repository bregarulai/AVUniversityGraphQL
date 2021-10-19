using Microsoft.EntityFrameworkCore;
using System;

namespace AVUniversityGraphQL.DB
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
            

    }
}
