using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persitance
{
    public class DataContext : DbContext
    {

        public DbSet<Activity> Activities { get; set; }
        
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        
    }
}
