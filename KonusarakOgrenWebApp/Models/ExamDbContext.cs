using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenWebApp.Models
{
    public class ExamDbContext: DbContext
    {
        public DbSet<ExamModel> ExamModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Exam.db");
    }
}
