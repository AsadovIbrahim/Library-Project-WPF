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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Pages).IsRequired();
            builder.Property(p => p.YearPress).IsRequired();
            builder.Property(p => p.Id_Themes).IsRequired();
            builder.Property(p => p.Id_Category).IsRequired();
            builder.Property(p => p.Id_Author).IsRequired();
            builder.Property(p => p.Id_Press).IsRequired();
            builder.Property(p => p.Comment).IsRequired();
            builder.Property(p => p.Quantity).IsRequired();

            builder.HasOne(p => p.Theme).WithMany(p => p.Book).HasForeignKey(p => p.Id_Themes);
            builder.HasOne(p => p.Author).WithMany(p => p.Book).HasForeignKey(p => p.Id_Author);
            builder.HasOne(p => p.Press).WithMany(p => p.Book).HasForeignKey(p => p.Id_Press);
            builder.HasOne(p => p.Category).WithMany(p => p.Book).HasForeignKey(p => p.Id_Category);
            builder.HasMany(p => p.T_Card).WithOne(p => p.Book).HasForeignKey(p => p.Id_Book);
            builder.HasMany(p => p.S_Card).WithOne(p => p.Book).HasForeignKey(p => p.Id_Book);

        }
    }
}
