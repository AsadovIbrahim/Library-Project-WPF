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
    public class T_CardsConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id_Teacher).IsRequired();
            builder.Property(p => p.Id_Book).IsRequired();
            builder.Property(p => p.DateOut).IsRequired();
            builder.Property(p => p.DateIn).IsRequired();
            builder.Property(p => p.Id_Lib).IsRequired();

            builder.HasOne(p => p.Book).WithMany(p => p.T_Card).HasForeignKey(p => p.Id_Book);
            builder.HasOne(p => p.Teacher).WithMany(p => p.T_Card).HasForeignKey(p => p.Id_Teacher);

        }
    }
}
