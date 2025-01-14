using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using PlumbersMVC.Models;

namespace PlumbersMVC.DataAccess
{
    public class PlumberDbContext:DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(t => t.Employers)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId);
        }

        public PlumberDbContext(DbContextOptions opt) : base(opt) { }
    }
}
