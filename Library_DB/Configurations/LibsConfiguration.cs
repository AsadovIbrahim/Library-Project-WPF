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
    public class LibsConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();

            builder.HasMany(p => p.T_Card).WithOne(p => p.Lib).HasForeignKey(p => p.Id_Lib);
            builder.HasMany(p => p.S_Card).WithOne(p => p.Lib).HasForeignKey(p => p.Id_Lib);
        }
    }
}
