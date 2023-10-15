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
    public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id_Student).IsRequired();
            builder.Property(p => p.Id_Book).IsRequired();
            builder.Property(p => p.DateOut).IsRequired();
            builder.Property(p => p.DateIn).IsRequired();
            builder.Property(p => p.Id_Lib).IsRequired();

            builder.HasOne(p => p.Lib).WithMany(p => p.S_Card).HasForeignKey(p => p.Id_Lib);
            builder.HasOne(p => p.Student).WithMany(p => p.S_Card).HasForeignKey(p => p.Id_Student);
            builder.HasOne(p => p.Book).WithMany(p => p.S_Card).HasForeignKey(p => p.Id_Book);


        }
    }
}
