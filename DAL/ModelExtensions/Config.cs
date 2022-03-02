using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.ModelExtensions
{
   
        public class CampainEntityConfig : IEntityTypeConfiguration<Campain>
        {
            public void Configure(EntityTypeBuilder<Campain> builder)
            {
          
            }
        }


    public class DepartmentEntityConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(e => e.Employee)
                .WithMany(d => d.Departments)
                .HasForeignKey(a => a.EmployeeId);
        }

    }



    public class EmailEntityConfig : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmailAddress)
                .HasForeignKey(e => e.EmployeeId);

        }

    }


    public class EmployeeEntityConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(I => I.IdentityNumber).IsUnique();
           
        }

    }

  
    

    public class MentorshipEntityConfig : IEntityTypeConfiguration<Mentorship>
    {
        public void Configure(EntityTypeBuilder<Mentorship> builder)
        {
            builder.HasOne(e => e.Employee)
                            .WithMany(m => m.Mentorships)
                            .HasForeignKey(e => e.EmployeeId);
        }

    }


    public class ProductEntityConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(e => e.Employee)
                .WithMany(p => p.Products)
                .HasForeignKey(a => a.EmployeeId);



            builder.HasOne(c => c.Campain)
                .WithMany(p => p.Products)
                .HasForeignKey(a => a.CampainId);


        }

    }


    public class ProductDepartmentEntityConfig : IEntityTypeConfiguration<ProductDepartment>
    {
        public void Configure(EntityTypeBuilder<ProductDepartment> builder)
        {

         builder.HasKey(b => new { b.ProductId, b.DepartmentId });

            builder.HasOne(P => P.Products)
                .WithMany(d => d.ProductDepartments)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Departments)
                .WithMany(p => p.ProductDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }

            
        


    internal class TelephoneEntityConfig : IEntityTypeConfiguration<Telephone>
    {
        public void Configure(EntityTypeBuilder<Telephone> builder)
        {
            builder.HasOne(e => e.Employee)
                .WithMany(e => e.Telephones)
                .HasForeignKey(e => e.EmployeeId);

        }
    }

    
        
        
}






