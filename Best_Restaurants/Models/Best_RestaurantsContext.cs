using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Best_Restaurants.Models
{
  public class Best_RestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public Best_RestaurantsContext(DbContextOptions options) : base(options) { }
    // public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });


    //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //   {
    //     optionsBuilder.UseLazyLoadingProxies().UseLoggerFactory(MyLoggerFactory);
    //   }
    // }

  }
}