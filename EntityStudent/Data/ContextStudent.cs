using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityStudent.Models;

namespace EntityStudent.Data
{
    public class ContextStudent : DbContext
    {
        public DbSet<ModelStudent> TableStudent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NG01; Database=StudentDetails; Trusted_Connection=True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
