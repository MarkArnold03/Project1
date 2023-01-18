﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230118124825_Project1")]
    partial class Project1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project1.ShapesData.Shape", b =>
                {
                    b.Property<int>("ShapeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShapeId"), 1L, 1);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<double>("Perimeter")
                        .HasColumnType("float");

                    b.Property<double>("Side3")
                        .HasColumnType("float");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ShapeId");

                    b.ToTable("Shapes");
                });
#pragma warning restore 612, 618
        }
    }
}