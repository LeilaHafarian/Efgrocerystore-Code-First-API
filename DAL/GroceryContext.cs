using DAL.Model;
using DAL.ModelExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroceryContext : DbContext
    {
        public DbSet<Campain>? Campains { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Telephone>? Telephones { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Mentorship>? Mentorships { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Email>? Emails { get; set; }
        public DbSet<ProductDepartment>? ProductDepartments { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=DESKTOP-VDHT220\SQLEXPRESS;Database=EfgrocerystoreCodeFirst;Integrated Security=True;";
            optionsBuilder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .UseLazyLoadingProxies()
                ;
        }


      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampainEntityConfig());
            modelBuilder.ApplyConfiguration(new DepartmentEntityConfig());
            modelBuilder.ApplyConfiguration(new EmailEntityConfig());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfig());
            modelBuilder.ApplyConfiguration(new MentorshipEntityConfig());
            modelBuilder.ApplyConfiguration(new ProductEntityConfig());
            modelBuilder.ApplyConfiguration(new ProductDepartmentEntityConfig());
            modelBuilder.ApplyConfiguration(new TelephoneEntityConfig());
            modelBuilder.Seed();



            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Email>()
                .HasKey(p => new { p.EmailAddress, p.EmployeeId });
                ;

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Telephone>()
                .HasKey(p => new { p.PhoneNumber, p.EmployeeId });
                ;

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Mentorship>()
                .HasKey(p => p.Mentor)
                ;

        }
}   }

