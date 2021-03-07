using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tslee.Website.Models;

namespace Tslee.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tslee.Website.Models.Blog> Blog { get; set; }
        public DbSet<Tslee.Website.Models.Post> Post { get; set; }
    }
}
