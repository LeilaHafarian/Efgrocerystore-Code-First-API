﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(GroceryContext))]
    [Migration("20220222115623_controll")]
    partial class controll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Model.Campain", b =>
                {
                    b.Property<int>("CampainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampainId"), 1L, 1);

                    b.Property<decimal>("Pricedrop")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CampainId");

                    b.ToTable("Campains");

                    b.HasData(
                        new
                        {
                            CampainId = 1,
                            Pricedrop = 60m
                        },
                        new
                        {
                            CampainId = 2,
                            Pricedrop = 50m
                        },
                        new
                        {
                            CampainId = 3,
                            Pricedrop = 10m
                        },
                        new
                        {
                            CampainId = 4,
                            Pricedrop = 90m
                        });
                });

            modelBuilder.Entity("DAL.Model.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Dairy",
                            EmployeeId = 1
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "fruit",
                            EmployeeId = 2
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "pantry",
                            EmployeeId = 3
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "drinks",
                            EmployeeId = 5
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "bread",
                            EmployeeId = 4
                        },
                        new
                        {
                            DepartmentId = 6,
                            DepartmentName = "meat counter",
                            EmployeeId = 7
                        });
                });

            modelBuilder.Entity("DAL.Model.Email", b =>
                {
                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmailAddress");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            EmailAddress = "Jack.Nicholson65@gmail.com",
                            EmployeeId = 1
                        },
                        new
                        {
                            EmailAddress = "Marlon.Brando87@gmail.com",
                            EmployeeId = 2
                        },
                        new
                        {
                            EmailAddress = "Katharine.Hepburn@gmail.com",
                            EmployeeId = 3
                        },
                        new
                        {
                            EmailAddress = "William.Clark@gmail.com",
                            EmployeeId = 4
                        },
                        new
                        {
                            EmailAddress = "Ingrid.Bergman@gmail.com",
                            EmployeeId = 5
                        },
                        new
                        {
                            EmailAddress = "Elizabeth.Taylor@gmail.com",
                            EmployeeId = 6
                        },
                        new
                        {
                            EmailAddress = "Elizab.Taylor@gmail.com",
                            EmployeeId = 6
                        },
                        new
                        {
                            EmailAddress = "Ing.Bergman@gmail.com",
                            EmployeeId = 5
                        },
                        new
                        {
                            EmailAddress = "Leonardo DiCaprio@gmail.com",
                            EmployeeId = 7
                        });
                });

            modelBuilder.Entity("DAL.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FirstName = "Jack",
                            IdentityNumber = "198304274544",
                            LastName = "Nicholson"
                        },
                        new
                        {
                            EmployeeId = 2,
                            FirstName = "Marlon",
                            IdentityNumber = "197907227876",
                            LastName = "Brando"
                        },
                        new
                        {
                            EmployeeId = 3,
                            FirstName = "Katharine",
                            IdentityNumber = "198511217865",
                            LastName = "Hepburn"
                        },
                        new
                        {
                            EmployeeId = 4,
                            FirstName = "William",
                            IdentityNumber = "198408125544",
                            LastName = "Clark"
                        },
                        new
                        {
                            EmployeeId = 5,
                            FirstName = "Ingrid",
                            IdentityNumber = "198504189922",
                            LastName = "Bergman"
                        },
                        new
                        {
                            EmployeeId = 6,
                            FirstName = "Elizabeth",
                            IdentityNumber = "198310227733",
                            LastName = "Taylor"
                        },
                        new
                        {
                            EmployeeId = 7,
                            FirstName = "Leonardo",
                            IdentityNumber = "198109119911",
                            LastName = "DiCaprio"
                        });
                });

            modelBuilder.Entity("DAL.Model.Mentorship", b =>
                {
                    b.Property<int>("Mentor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mentor"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mentee")
                        .HasColumnType("int");

                    b.HasKey("Mentor");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Mentorships");

                    b.HasData(
                        new
                        {
                            Mentor = 1,
                            EmployeeId = 1,
                            ExpDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mentee = 1
                        },
                        new
                        {
                            Mentor = 2,
                            EmployeeId = 2,
                            ExpDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mentee = 2
                        },
                        new
                        {
                            Mentor = 3,
                            EmployeeId = 3,
                            ExpDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mentee = 3
                        });
                });

            modelBuilder.Entity("DAL.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CampainId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastCount")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListOfIngredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NuminStore")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CampainId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CampainId = 1,
                            EmployeeId = 4,
                            ExpDate = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastCount = new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            ListOfIngredients = "Potatoes sunflower oil salt",
                            NuminStore = 100,
                            Price = 20m,
                            ProductName = "Chips"
                        },
                        new
                        {
                            ProductId = 2,
                            CampainId = 2,
                            EmployeeId = 1,
                            ExpDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastCount = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            ListOfIngredients = "egg Sugar milk vanilla salt cream",
                            NuminStore = 2,
                            Price = 10m,
                            ProductName = "Ice cream"
                        },
                        new
                        {
                            ProductId = 3,
                            CampainId = 1,
                            EmployeeId = 2,
                            ExpDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastCount = new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            ListOfIngredients = "Flour Water batter yeast salt",
                            NuminStore = 20,
                            Price = 200m,
                            ProductName = " Beard"
                        },
                        new
                        {
                            ProductId = 4,
                            CampainId = 2,
                            EmployeeId = 3,
                            ExpDate = new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastCount = new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            ListOfIngredients = "peanut oil",
                            NuminStore = 78,
                            Price = 54m,
                            ProductName = "Peanut butter"
                        },
                        new
                        {
                            ProductId = 5,
                            CampainId = 1,
                            EmployeeId = 6,
                            ExpDate = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastCount = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            ListOfIngredients = "milk starter",
                            NuminStore = 30,
                            Price = 10m,
                            ProductName = " yoghurt"
                        });
                });

            modelBuilder.Entity("DAL.Model.ProductDepartment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("ProductDepartments");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DepartmentId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            DepartmentId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            DepartmentId = 3
                        });
                });

            modelBuilder.Entity("DAL.Model.Telephone", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("PhoneNumber");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Telephones");

                    b.HasData(
                        new
                        {
                            PhoneNumber = "198304274544",
                            EmployeeId = 1
                        },
                        new
                        {
                            PhoneNumber = "0767865533",
                            EmployeeId = 2
                        },
                        new
                        {
                            PhoneNumber = "0798765544",
                            EmployeeId = 3
                        },
                        new
                        {
                            PhoneNumber = "0765434422",
                            EmployeeId = 4
                        },
                        new
                        {
                            PhoneNumber = "078432446",
                            EmployeeId = 5
                        },
                        new
                        {
                            PhoneNumber = "0786541167",
                            EmployeeId = 6
                        },
                        new
                        {
                            PhoneNumber = "0756543388",
                            EmployeeId = 7
                        },
                        new
                        {
                            PhoneNumber = "0784324465",
                            EmployeeId = 5
                        });
                });

            modelBuilder.Entity("DAL.Model.Department", b =>
                {
                    b.HasOne("DAL.Model.Employee", "Employee")
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Model.Email", b =>
                {
                    b.HasOne("DAL.Model.Employee", "Employee")
                        .WithMany("EmailAddress")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Model.Mentorship", b =>
                {
                    b.HasOne("DAL.Model.Employee", "Employee")
                        .WithMany("Mentorships")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Model.Product", b =>
                {
                    b.HasOne("DAL.Model.Campain", "Campain")
                        .WithMany("Products")
                        .HasForeignKey("CampainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.Employee", "Employee")
                        .WithMany("Products")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campain");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Model.ProductDepartment", b =>
                {
                    b.HasOne("DAL.Model.Department", "Departments")
                        .WithMany("ProductDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Model.Product", "Products")
                        .WithMany("ProductDepartments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Model.Telephone", b =>
                {
                    b.HasOne("DAL.Model.Employee", "Employee")
                        .WithMany("Telephones")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Model.Campain", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Model.Department", b =>
                {
                    b.Navigation("ProductDepartments");
                });

            modelBuilder.Entity("DAL.Model.Employee", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("EmailAddress");

                    b.Navigation("Mentorships");

                    b.Navigation("Products");

                    b.Navigation("Telephones");
                });

            modelBuilder.Entity("DAL.Model.Product", b =>
                {
                    b.Navigation("ProductDepartments");
                });
#pragma warning restore 612, 618
        }
    }
}
