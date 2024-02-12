using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Statuses;
using TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Infrastructure.Data.EntityTypeConfigurations
{
    class TaskEntityTypeConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks")
                .HasKey(t => t.Id);
            builder.Property(t => t.Id)
                .ValueGeneratedOnAdd();
            builder.Property(t => t.Name)
                .HasMaxLength(50);
            builder.Property(t => t.Description)
                .HasMaxLength(255);
            builder.HasOne(t => t.Status)
                .WithMany(s => s.Tasks)
                .HasForeignKey(t => t.StatusId);
        }
    }
}
