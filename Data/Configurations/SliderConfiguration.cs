using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength(255);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(255);
            builder.Property(s => s.Image).IsRequired().HasMaxLength(255);
        }
    }
}
