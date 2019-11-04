using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CP_CoreRazorContoso.Models;

namespace CP_CoreRazorContoso.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<CP_CoreRazorContoso.Models.Student> Student { get; set; }

        public DbSet<CP_CoreRazorContoso.Models.Course> Course { get; set; }

        public DbSet<CP_CoreRazorContoso.Models.Enrollment> Enrollment { get; set; }
    }
}
