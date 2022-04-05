using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuikProject.Models
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3BJ5GK9;Database=TuikDb;Integrated Security=true");
        }

        public DbSet<ConnectionClass> Connections { get; set; }
        public DbSet<MatchProduct> MatchProducts { get; set; }
        public DbSet<TuikReport> TuikReports { get; set; }
        public DbSet<TuikReportDetail> TuikReportDetails { get; set; }
        public DbSet<TuikWeb> TuikWebSite { get; set; }
        public DbSet<UCAF> UCAFs { get; set; }
        public DbSet<UCAFMatch> UCAFMatchs { get; set; }
    }
}
