﻿// <auto-generated />
using Mango.Services.CuponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.CuponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mango.Services.CuponAPI.Models.Cupon", b =>
                {
                    b.Property<int>("CuponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuponId"));

                    b.Property<string>("CuponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CuponId");

                    b.ToTable("Cupons");

                    b.HasData(
                        new
                        {
                            CuponId = 1,
                            CuponCode = "10OFF",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CuponId = 2,
                            CuponCode = "20OFF",
                            DiscountAmount = 20.0,
                            MinAmount = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
