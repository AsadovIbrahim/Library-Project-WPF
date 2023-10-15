using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_DB.Entities;

namespace Library_DB.Configurations
{
    public class GroupConiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Id_Faculty).IsRequired();

            builder.HasOne(p => p.Faculty).WithMany(p => p.Group).HasForeignKey(p => p.Id_Faculty);
            builder.HasMany(p => p.Student).WithOne(p => p.Group).HasForeignKey(p => p.Id_Group);
        }
    }
}
