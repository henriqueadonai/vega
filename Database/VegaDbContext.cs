using Microsoft.EntityFrameworkCore;
using vega.Core.Models;

namespace vega.Database
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Feature> Features {get;set;}
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        :base(options){

        }

    }

}