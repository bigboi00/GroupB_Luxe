﻿// <auto-generated />
using INFT3050.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INFT3050.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240720140417_Status")]
    partial class Status
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("INFT3050.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "A",
                            Name = "Table",
                            Room = "Living-Room"
                        },
                        new
                        {
                            CategoryId = "B",
                            Name = "Sofa",
                            Room = "Living-Room"
                        },
                        new
                        {
                            CategoryId = "C",
                            Name = "TV-Consoles",
                            Room = "Living-Room"
                        },
                        new
                        {
                            CategoryId = "D",
                            Name = "Shelves",
                            Room = "Living-Room"
                        },
                        new
                        {
                            CategoryId = "E",
                            Name = "Headrest",
                            Room = "Living-Room"
                        },
                        new
                        {
                            CategoryId = "F",
                            Name = "Stools",
                            Room = "Dining-Room"
                        },
                        new
                        {
                            CategoryId = "G",
                            Name = "Cabinets",
                            Room = "Dining-Room"
                        },
                        new
                        {
                            CategoryId = "H",
                            Name = "Dining-Table",
                            Room = "Dining-Room"
                        },
                        new
                        {
                            CategoryId = "I",
                            Name = "Chairs",
                            Room = "Dining-Room"
                        },
                        new
                        {
                            CategoryId = "J",
                            Name = "Beds",
                            Room = "Beds"
                        },
                        new
                        {
                            CategoryId = "K",
                            Name = "Bedside-Table",
                            Room = "Beds"
                        },
                        new
                        {
                            CategoryId = "L",
                            Name = "Mirror",
                            Room = "Beds"
                        },
                        new
                        {
                            CategoryId = "M",
                            Name = "Cloth-Hanger-Racks",
                            Room = "Beds"
                        },
                        new
                        {
                            CategoryId = "Q",
                            Name = "Study-Table",
                            Room = "Beds"
                        });
                });

            modelBuilder.Entity("INFT3050.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("INFT3050.Models.Product", b =>
                {
                    b.HasOne("INFT3050.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}