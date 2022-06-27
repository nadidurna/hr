﻿using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Data.Context
{
    public class DesignTimeContext : IDesignTimeDbContextFactory<CircleDbContext>
    {
        public CircleDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                            .SetBasePath(System.IO.Path.Combine(Directory.GetCurrentDirectory()))
                            .AddJsonFile("appsettings.json", false, true).Build()
                            .GetValue<string>("MigrationConnectionString");

            var optionsBuilder = new DbContextOptionsBuilder<CircleDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new CircleDbContext(optionsBuilder.Options);
        }
    }
}