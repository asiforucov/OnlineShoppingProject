using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.CreateDT).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(c => c.ApplicationUserId).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Content).IsRequired().HasColumnType("TEXT");
            builder.Property(c => c.IsDelete).HasDefaultValue(false);
        }
    }
}
