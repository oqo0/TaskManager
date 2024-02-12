using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities.Statuses;
using TaskManager.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TaskManager.Infrastructure.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
