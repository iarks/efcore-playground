﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efcore_playground.dataaccess;

namespace efcore_playground.dataaccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200422141813_second-migration")]
    partial class secondmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("efcore_playground.dataaccess.entities.Address", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Pin");

                    b.Property<string>("StreetName");

                    b.Property<string>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("StudentID")
                        .IsUnique()
                        .HasFilter("[StudentID] IS NOT NULL");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("efcore_playground.dataaccess.entities.Grade", b =>
                {
                    b.Property<string>("GradeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Marks");

                    b.Property<string>("StudentID");

                    b.Property<string>("Subject");

                    b.HasKey("GradeId");

                    b.HasIndex("StudentID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("efcore_playground.dataaccess.entities.Student", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("efcore_playground.dataaccess.entities.Address", b =>
                {
                    b.HasOne("efcore_playground.dataaccess.entities.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("efcore_playground.dataaccess.entities.Address", "StudentID");
                });

            modelBuilder.Entity("efcore_playground.dataaccess.entities.Grade", b =>
                {
                    b.HasOne("efcore_playground.dataaccess.entities.Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentID");
                });
#pragma warning restore 612, 618
        }
    }
}
