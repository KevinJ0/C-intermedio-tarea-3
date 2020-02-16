using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.Data
{
    public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext (DbContextOptions<SchoolSystemContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolSystem.Models.Student> Student { get; set; }
    }
}
