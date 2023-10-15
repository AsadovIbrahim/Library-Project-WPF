using Library_DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Configurations
{
    public class StudentsConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.Id_Group).IsRequired();
            builder.Property(p => p.Term).IsRequired();

            builder.HasMany(p => p.S_Card).WithOne(p => p.Student).HasForeignKey(p => p.Id_Student);
            builder.HasOne(p => p.Group).WithMany(p => p.Student).HasForeignKey(p => p.Id_Group);


        }
    }
}
