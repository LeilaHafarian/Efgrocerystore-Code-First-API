using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelExtensions
{
    public static class Data
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var campain1 = new Campain { CampainId = 1, Pricedrop = 60 };
            var campain2 = new Campain { CampainId = 2, Pricedrop = 50 };
            var campain3 = new Campain { CampainId = 3, Pricedrop = 10 };
            var campain4 = new Campain { CampainId = 4, Pricedrop = 90 };
            modelBuilder.Entity<Campain>()
                .HasData(campain1, campain2, campain3, campain4);




            var department1 = new Department() { DepartmentId = 1, DepartmentName = "Dairy", EmployeeId = 1};
            var department2 = new Department() { DepartmentId = 2, DepartmentName = "fruit", EmployeeId = 2};
            var department3 = new Department() { DepartmentId = 3, DepartmentName = "pantry", EmployeeId = 3 };
            var department4 = new Department() { DepartmentId = 4, DepartmentName = "drinks", EmployeeId = 5 };
            var department5 = new Department() { DepartmentId = 5, DepartmentName = "bread", EmployeeId = 4 };
            var department6 = new Department() { DepartmentId = 6, DepartmentName = "meat counter", EmployeeId = 7 };
            modelBuilder.Entity<Department>()
                .HasData(
                department1,
                department2,
                department3,
                department4,
                department5,
                department6
                );





            var employee1 = new Employee() { EmployeeId = 1, IdentityNumber = "198304274544", FirstName = "Jack", LastName = "Nicholson",  };
            var employee2 = new Employee() { EmployeeId = 2, IdentityNumber = "197907227876", FirstName = "Marlon", LastName = "Brando" };
            var employee3 = new Employee() { EmployeeId = 3, IdentityNumber = "198511217865", FirstName = "Katharine", LastName = "Hepburn" };
            var employee4 = new Employee() { EmployeeId = 4, IdentityNumber = "198408125544", FirstName = "William", LastName = "Clark" };
            var employee5 = new Employee() { EmployeeId = 5, IdentityNumber = "198504189922", FirstName = "Ingrid", LastName = "Bergman" };
            var employee6 = new Employee() { EmployeeId = 6, IdentityNumber = "198310227733", FirstName = "Elizabeth", LastName = "Taylor" };
            var employee7 = new Employee() { EmployeeId = 7, IdentityNumber = "198109119911", FirstName = "Leonardo", LastName = "DiCaprio" };
            modelBuilder.Entity<Employee>()
                .HasData(
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7
                );




            var email1 = new Email() { EmployeeId = 1, EmailAddress = "Jack.Nicholson65@gmail.com" };
            var email2 = new Email() { EmployeeId = 2, EmailAddress = "Marlon.Brando87@gmail.com" };
            var email3 = new Email() { EmployeeId = 3, EmailAddress = "Katharine.Hepburn@gmail.com" };
            var email4 = new Email() { EmployeeId = 4, EmailAddress = "William.Clark@gmail.com" };
            var email5 = new Email() { EmployeeId = 5, EmailAddress = "Ingrid.Bergman@gmail.com" };
            var email6 = new Email() { EmployeeId = 6, EmailAddress = "Elizabeth.Taylor@gmail.com" };
            var email7 = new Email() { EmployeeId = 6, EmailAddress = "Elizab.Taylor@gmail.com" };
            var email8 = new Email() { EmployeeId = 5, EmailAddress = "Ing.Bergman@gmail.com" };
            var email9 = new Email() { EmployeeId = 7, EmailAddress = "Leonardo DiCaprio@gmail.com" };
            modelBuilder.Entity<Email>()
                .HasData(
                email1,
                email2,
                email3,
                email4,
                email5,
                email6,
                email7,
                email8,
                email9

                );



            var telephone1 = new Telephone() { EmployeeId = 1, PhoneNumber = "198304274544" };
            var telephone2 = new Telephone() { EmployeeId = 2, PhoneNumber = "0767865533" };
            var telephone3 = new Telephone() { EmployeeId = 3, PhoneNumber = "0798765544" };
            var telephone4 = new Telephone() { EmployeeId = 4, PhoneNumber = "0765434422" };
            var telephone5 = new Telephone() { EmployeeId = 5, PhoneNumber = "078432446" };
            var telephone6 = new Telephone() { EmployeeId = 6, PhoneNumber = "0786541167" };
            var telephone7 = new Telephone() { EmployeeId = 7, PhoneNumber = "0756543388" };
            var telephone8 = new Telephone() { EmployeeId = 5, PhoneNumber = "0784324465" };

            modelBuilder.Entity<Telephone>()
                .HasData(
                telephone1,
                telephone2,
                telephone3,
                telephone4,
                telephone5,
                telephone6,
                telephone7,
                telephone8
                );





            var product1 = new Product() { ProductId = 1, NuminStore = 100, Price = 20, ExpDate = DateTime.Parse("2022-12-09"), ProductName = "Chips", ListOfIngredients = "Potatoes sunflower oil salt", LastCount = DateTime.Today.AddDays(-1), EmployeeId = 4, CampainId=1 };
            var product2 = new Product() { ProductId = 2, NuminStore = 2, Price = 10, ExpDate = DateTime.Parse("2022-02-01"), ProductName = "Ice cream", ListOfIngredients = "egg Sugar milk vanilla salt cream", LastCount = DateTime.Today.AddDays(-2), EmployeeId = 1,CampainId=2 };
            var product3 = new Product() { ProductId  =3, NuminStore = 20, Price = 200, ExpDate = DateTime.Parse("2022-01-10"), ProductName = " Beard", ListOfIngredients = "Flour Water batter yeast salt", LastCount = DateTime.Today.AddDays(-3), EmployeeId = 2,CampainId=1 };
            var product4 = new Product() { ProductId = 4, NuminStore = 78, Price = 54, ExpDate = DateTime.Parse("2022-06-01"), ProductName = "Peanut butter", ListOfIngredients = "peanut oil", LastCount = DateTime.Today.AddDays(-1), EmployeeId = 3,CampainId=2};
            var product5 = new Product() { ProductId = 5, NuminStore = 30, Price = 10, ExpDate = DateTime.Parse("2022-03-01"), ProductName = " yoghurt", ListOfIngredients = "milk starter", LastCount = DateTime.Today.AddDays(-4), EmployeeId = 6,CampainId=1 };
            modelBuilder.Entity<Product>()
                .HasData(
                product1,
                product2,
                product3,
                product4,
                product5
                );



            var mentorship1 = new Mentorship { Mentor = 1, Mentee = 1, EmployeeId=1 };
            var mentorship2 = new Mentorship { Mentor = 2, Mentee = 2, EmployeeId=2 };
            var mentorship3 = new Mentorship { Mentor = 3, Mentee = 3, EmployeeId=3 };
            modelBuilder.Entity<Mentorship>()
                .HasData(
                mentorship1,
                mentorship2,
                mentorship3
                );



            var productDepartment1 = new ProductDepartment { ProductId = 1, DepartmentId = 1 };
            var productDepartment2 = new ProductDepartment { ProductId = 2, DepartmentId = 2 };
            var productDepartment3 = new ProductDepartment { ProductId = 3, DepartmentId = 3 };
            modelBuilder.Entity<ProductDepartment>()
                .HasData(
                productDepartment1,
                productDepartment2,
                productDepartment3
                );



        }

    }
}
