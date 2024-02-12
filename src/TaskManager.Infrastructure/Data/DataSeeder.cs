using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Infrastructure.Data
{
    public static class DataSeeder
    {
        public static void SeedStatusData(this ModelBuilder builder)
        {
            builder.Entity<Status>().HasData(
                new Status() { Id = 1, Name = "Created" },
                new Status() { Id = 2, Name = "In work" },
                new Status() { Id = 3, Name = "Completed" });
        }
    }
}
