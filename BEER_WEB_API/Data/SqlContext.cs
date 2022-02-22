using BEER_WEB_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BEER_WEB_API.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public virtual DbSet<BeerEntity> Beers { get; set; }
        public virtual DbSet<BeerDetailsEntity> BeersDetails { get; set; }
        public virtual DbSet<BreweryEntity> Breweries { get; set; }
    }
}
