using Brive.Bootcamp.Project.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API
{
    public class BPContext: DbContext
    {
        public BPContext(DbContextOptions<BPContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(eb =>
            {
                eb.HasKey(c => new { c.Id });
            });
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<User> User { get; set; }
    }
}
