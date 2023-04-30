using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class HistoryContext : DbContext
    {
        public DbSet<History> Histories { get; set; }
        public DbSet<AnswersResult> Results { get; set; }
        public HistoryContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Filename=History.db");
    }
}
