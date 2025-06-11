﻿using DevHabit.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevHabit.API.Database.Configurations;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id).HasMaxLength(50);     
        builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
        builder.Property(t => t.Description).HasMaxLength(500);

        builder.HasIndex(t => new { t.Name }).IsUnique();

    }
}
