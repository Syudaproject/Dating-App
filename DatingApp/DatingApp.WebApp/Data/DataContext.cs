using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //public DbSet<> MyProperty { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Language>(entity => {
        //        entity.ToTable("MyAccountsTable");
        //    });
        //}
    }
}
