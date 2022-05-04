using Microsoft.EntityFrameworkCore;
using System;
using VueApp.Entities;

namespace VueApp.DAL
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }
    }
}
