using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RoleModel> RoleModels { get; set; }
        public DbSet<ClassModel> ClassModels { get; set; }
        public DbSet<ExemptionsModel> ExemptionsModels { get; set; }
        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<TariffModel> TariffModels { get; set; }
        public DbSet<TeacherModel> TeacherModels { get; set; }
        public DbSet<TimekeepingModel> TimekeepingModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
    }
}
