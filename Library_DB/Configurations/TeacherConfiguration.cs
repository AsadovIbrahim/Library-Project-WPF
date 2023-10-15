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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.Id_Dep).IsRequired();

            builder.HasMany(p => p.T_Card).WithOne(p => p.Teacher).HasForeignKey(p => p.Id_Teacher);

            builder.HasOne(p => p.Department).WithMany(p => p.Teacher).HasForeignKey(p => p.Id_Dep);
        }
    }
}
