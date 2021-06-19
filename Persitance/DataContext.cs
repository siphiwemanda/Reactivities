using System;
using Microsoft.EntityFrameworkCore;

namespace Persitance
{
    public class DataContext : DbContext
    {

        public DbSet<Action> Activities { get; set; }
        
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        
    }
}
