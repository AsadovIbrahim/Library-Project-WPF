﻿// <auto-generated />
using System;
using Library_DB.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_DB.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20231015102717_firstt")]
    partial class firstt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library_DB.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library_DB.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Author")
                        .HasColumnType("int");

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Press")
                        .HasColumnType("int");

                    b.Property<int>("Id_Themes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearPress")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Author");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Press");

                    b.HasIndex("Id_Themes");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_DB.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Library_DB.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Library_DB.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Library_DB.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Faculty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Faculty");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Library_DB.Entities.Lib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("Library_DB.Entities.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Presses");
                });

            modelBuilder.Entity("Library_DB.Entities.S_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Student");

                    b.ToTable("S_Cards");
                });

            modelBuilder.Entity("Library_DB.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Group");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Library_DB.Entities.T_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Book")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Teacher")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Book");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Teacher");

                    b.ToTable("T_Cards");
                });

            modelBuilder.Entity("Library_DB.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Dep")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Dep");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Library_DB.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Library_DB.Entities.Book", b =>
                {
                    b.HasOne("Library_DB.Entities.Author", "Author")
                        .WithMany("Book")
                        .HasForeignKey("Id_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Category", "Category")
                        .WithMany("Book")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Press", "Press")
                        .WithMany("Book")
                        .HasForeignKey("Id_Press")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Theme", "Theme")
                        .WithMany("Book")
                        .HasForeignKey("Id_Themes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Press");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Library_DB.Entities.Group", b =>
                {
                    b.HasOne("Library_DB.Entities.Faculty", "Faculty")
                        .WithMany("Group")
                        .HasForeignKey("Id_Faculty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Library_DB.Entities.S_Card", b =>
                {
                    b.HasOne("Library_DB.Entities.Book", "Book")
                        .WithMany("S_Card")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Lib", "Lib")
                        .WithMany("S_Card")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Student", "Student")
                        .WithMany("S_Card")
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library_DB.Entities.Student", b =>
                {
                    b.HasOne("Library_DB.Entities.Group", "Group")
                        .WithMany("Student")
                        .HasForeignKey("Id_Group")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Library_DB.Entities.T_Card", b =>
                {
                    b.HasOne("Library_DB.Entities.Book", "Book")
                        .WithMany("T_Card")
                        .HasForeignKey("Id_Book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Lib", "Lib")
                        .WithMany("T_Card")
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_DB.Entities.Teacher", "Teacher")
                        .WithMany("T_Card")
                        .HasForeignKey("Id_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Library_DB.Entities.Teacher", b =>
                {
                    b.HasOne("Library_DB.Entities.Department", "Department")
                        .WithMany("Teacher")
                        .HasForeignKey("Id_Dep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Library_DB.Entities.Author", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library_DB.Entities.Book", b =>
                {
                    b.Navigation("S_Card");

                    b.Navigation("T_Card");
                });

            modelBuilder.Entity("Library_DB.Entities.Category", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library_DB.Entities.Department", b =>
                {
                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Library_DB.Entities.Faculty", b =>
                {
                    b.Navigation("Group");
                });

            modelBuilder.Entity("Library_DB.Entities.Group", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library_DB.Entities.Lib", b =>
                {
                    b.Navigation("S_Card");

                    b.Navigation("T_Card");
                });

            modelBuilder.Entity("Library_DB.Entities.Press", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library_DB.Entities.Student", b =>
                {
                    b.Navigation("S_Card");
                });

            modelBuilder.Entity("Library_DB.Entities.Teacher", b =>
                {
                    b.Navigation("T_Card");
                });

            modelBuilder.Entity("Library_DB.Entities.Theme", b =>
                {
                    b.Navigation("Book");
                });
#pragma warning restore 612, 618
        }
    }
}