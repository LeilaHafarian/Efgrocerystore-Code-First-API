using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campains",
                columns: table => new
                {
                    CampainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pricedrop = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campains", x => x.CampainId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailAddress);
                    table.ForeignKey(
                        name: "FK_Emails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentorships",
                columns: table => new
                {
                    Mentor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mentee = table.Column<int>(type: "int", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorships", x => x.Mentor);
                    table.ForeignKey(
                        name: "FK_Mentorships_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NuminStore = table.Column<int>(type: "int", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCount = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListOfIngredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CampainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Campains_CampainId",
                        column: x => x.CampainId,
                        principalTable: "Campains",
                        principalColumn: "CampainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.PhoneNumber);
                    table.ForeignKey(
                        name: "FK_Telephones_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDepartments",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDepartments", x => new { x.ProductId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_ProductDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductDepartments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Campains",
                columns: new[] { "CampainId", "Pricedrop" },
                values: new object[,]
                {
                    { 1, 60m },
                    { 2, 50m },
                    { 3, 10m },
                    { 4, 90m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "IdentityNumber", "LastName" },
                values: new object[,]
                {
                    { 1, "Jack", "198304274544", "Nicholson" },
                    { 2, "Marlon", "197907227876", "Brando" },
                    { 3, "Katharine", "198511217865", "Hepburn" },
                    { 4, "William", "198408125544", "Clark" },
                    { 5, "Ingrid", "198504189922", "Bergman" },
                    { 6, "Elizabeth", "198310227733", "Taylor" },
                    { 7, "Leonardo", "198109119911", "DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "EmployeeId" },
                values: new object[,]
                {
                    { 1, "Dairy", 1 },
                    { 2, "fruit", 2 },
                    { 3, "pantry", 3 },
                    { 4, "drinks", 5 },
                    { 5, "bread", 4 },
                    { 6, "meat counter", 7 }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailAddress", "EmployeeId" },
                values: new object[,]
                {
                    { "Elizab.Taylor@gmail.com", 6 },
                    { "Elizabeth.Taylor@gmail.com", 6 },
                    { "Ing.Bergman@gmail.com", 5 },
                    { "Ingrid.Bergman@gmail.com", 5 },
                    { "Jack.Nicholson65@gmail.com", 1 },
                    { "Katharine.Hepburn@gmail.com", 3 },
                    { "Leonardo DiCaprio@gmail.com", 7 },
                    { "Marlon.Brando87@gmail.com", 2 },
                    { "William.Clark@gmail.com", 4 }
                });

            migrationBuilder.InsertData(
                table: "Mentorships",
                columns: new[] { "Mentor", "EmployeeId", "ExpDate", "Mentee" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CampainId", "EmployeeId", "ExpDate", "LastCount", "ListOfIngredients", "NuminStore", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "Potatoes sunflower oil salt", 100, 20m, "Chips" },
                    { 2, 2, 1, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "egg Sugar milk vanilla salt cream", 2, 10m, "Ice cream" },
                    { 3, 1, 2, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "Flour Water batter yeast salt", 20, 200m, " Beard" },
                    { 4, 2, 3, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "peanut oil", 78, 54m, "Peanut butter" },
                    { 5, 1, 6, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "milk starter", 30, 10m, " yoghurt" }
                });

            migrationBuilder.InsertData(
                table: "Telephones",
                columns: new[] { "PhoneNumber", "EmployeeId" },
                values: new object[,]
                {
                    { "0756543388", 7 },
                    { "0765434422", 4 },
                    { "0767865533", 2 },
                    { "078432446", 5 },
                    { "0784324465", 5 },
                    { "0786541167", 6 },
                    { "0798765544", 3 },
                    { "198304274544", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductDepartments",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductDepartments",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "ProductDepartments",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmployeeId",
                table: "Emails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityNumber",
                table: "Employees",
                column: "IdentityNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentorships_EmployeeId",
                table: "Mentorships",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDepartments_DepartmentId",
                table: "ProductDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampainId",
                table: "Products",
                column: "CampainId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EmployeeId",
                table: "Products",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_EmployeeId",
                table: "Telephones",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Mentorships");

            migrationBuilder.DropTable(
                name: "ProductDepartments");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campains");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
