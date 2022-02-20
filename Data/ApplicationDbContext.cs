using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
