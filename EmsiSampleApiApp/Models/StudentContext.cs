using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmsiSampleApiApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) 
            : base(options)
        {
        
        }

        public StudentContext()
        {}


        public DbSet<Student> Students { get; set; }
    }
}
