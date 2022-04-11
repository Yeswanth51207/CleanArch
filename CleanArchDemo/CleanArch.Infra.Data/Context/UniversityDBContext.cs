using CleanArch.Doman.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data
{
    public class UniversityDBContext:  DbContext
    {
        public UniversityDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Course> Courses { get; set; }
        
    }
}
