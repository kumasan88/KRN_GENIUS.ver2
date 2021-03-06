// <auto-generated />
using System;
using COMP2139_KRN_GENIUS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COMP2139_KRN_GENIUS.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220213022726_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("COMP2139_KRN_GENIUS.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("YearlyPrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "FXDS234",
                            Date = new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3666),
                            Name = "Seunghun Yim",
                            YearlyPrice = 3.3399999999999999
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "HER132",
                            Date = new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3701),
                            Name = "Yoonhee Kim",
                            YearlyPrice = 5.2300000000000004
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "HISD152",
                            Date = new DateTime(2022, 2, 12, 21, 27, 26, 293, DateTimeKind.Local).AddTicks(3703),
                            Name = "JooYoung Song",
                            YearlyPrice = 10.23
                        });
                });

            modelBuilder.Entity("COMP2139_KRN_GENIUS.Models.Technician", b =>
                {
                    b.Property<int>("TechnicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TechnicianId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicianId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechnicianId = 1,
                            Email = "fjeidjwidkd@gmail.com",
                            Name = "Seunghun Yim",
                            Phone = "415-222-2223"
                        },
                        new
                        {
                            TechnicianId = 2,
                            Email = "salrfku@gmail.com",
                            Name = "Yoonhee Kim",
                            Phone = "423-523-1233"
                        },
                        new
                        {
                            TechnicianId = 3,
                            Email = "yimsh4507@gmail.com",
                            Name = "JooYoung Song",
                            Phone = "123-123-1234"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
