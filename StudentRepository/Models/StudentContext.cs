using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository.Models
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SHUBHAMTGS\\TGS;Database=Dec2023_StudentDB;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
