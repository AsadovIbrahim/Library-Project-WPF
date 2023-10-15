using Library_DB.Configurations;
using Library_DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Contexts
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IBRAHIM\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Library;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new ThemeConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new PressConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new T_CardsConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConiguration());
            modelBuilder.ApplyConfiguration(new LibsConfiguration());
            modelBuilder.ApplyConfiguration(new StudentsConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new S_CardConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Faculty>? Faculties { get; set; }
        public DbSet<Group>? Groups { get; set; }
        public DbSet<Lib>? Libs { get; set; }
        public DbSet<Press>? Presses { get; set; }
        public DbSet<S_Card>? S_Cards { get; set; }
        public DbSet<T_Card>? T_Cards { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Theme>? Themes { get; set; }
    }
}
