﻿using BasicCRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
