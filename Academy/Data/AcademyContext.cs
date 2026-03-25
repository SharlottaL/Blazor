using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy.Components.Models;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext (DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy.Components.Models.Students> Students { get; set; } = default!;
    }
}
