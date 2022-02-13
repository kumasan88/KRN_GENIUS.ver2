using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP2139_KRN_GENIUS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearlyPrice = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Date", "Name", "YearlyPrice" },
                values: new object[,]
                {
                    { 1, "FXDS234", new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3666), "Seunghun Yim", 3.3399999999999999 },
                    { 2, "HER132", new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3701), "Yoonhee Kim", 5.2300000000000004 },
                    { 3, "HISD152", new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3703), "JooYoung Song", 10.23 }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "fjeidjwidkd@gmail.com", "Seunghun Yim", "415-222-2223" },
                    { 2, "salrfku@gmail.com", "Yoonhee Kim", "423-523-1233" },
                    { 3, "yimsh4507@gmail.com", "JooYoung Song", "123-123-1234" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
