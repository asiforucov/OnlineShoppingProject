using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class GenderCategoryConfiguration : IEntityTypeConfiguration<GenderCategory>
    {
        public void Configure(EntityTypeBuilder<GenderCategory> builder)
        {
            builder.Property(gc => gc.Name).IsRequired().HasMaxLength(255);
        }
    }
}
