using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
    {
    }

    public DbSet<Destination> Destinations { get; set; }
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Destination>()
    //   .HasData(
    //     new Destination { DestinationId = 1, DestinationName = "Test Name", Country = "Test Country", StateProvince = "Test State", City = "Test City", Category = "Test Category", Rating = 5, DestinationDescription = "Test Description" },
    //     new Destination { DestinationId = 2, DestinationName = "The Great Barrier Reef", Country = "Australia", StateProvince = "Queensland", City = "N/A", Category = "Beach", Rating = 5, DestinationDescription = "The Great Barrier Reef is the world's largest coral reef system composed of over 2,900 individual reefs and 900 islands stretching for over 2,300 kilometres over an area of approximately 344,400 square kilometres. The reef is located in the Coral Sea, off the coast of Queensland, Australia." },
    //     new Destination
    //     {
    //       DestinationId = 3,
    //       DestinationName = "Stonehenge",
    //       Country = "United Kingdom",
    //       StateProvince = "Salisbury",
    //       City = "N/A",
    //       Category = "Historical Landmark",
    //       Rating = 5,
    //       DestinationDescription = "Legendary neolithic monument made using stones transported from Wales and built for unknown purpose."
    //     },
    //     new Destination { DestinationId = 4, DestinationName = "Crater Lake", Country = "United States of America", StateProvince = "Oregon", City = "Klamath Falls", Category = "Lake", Rating = 5, DestinationDescription = "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity: fed by rain and snow, it’s the deepest lake in the USA and one of the most pristine on earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range." },
    //     new Destination { DestinationId = 5, DestinationName = "Niagara Falls", Country = "United States of America", StateProvince = "New York", City = "Niagara Falls", Category = "Waterfall", Rating = 5, DestinationDescription = "Niagara Falls is a city on the Niagara River, in New York State. It’s known for the vast Niagara Falls, which straddle the Canadian border. In Niagara Falls State Park, the Observation Tower, at Prospect Point, juts out over Niagara Gorge for a view of all 3 waterfalls. Trails from the Niagara Gorge Discovery Center lead to other viewpoints. The Aquarium of Niagara is home to Humboldt penguins, seals and sea lions." },
    //     new Destination { DestinationId = 6, DestinationName = "Beaverton Driver and Motor Vehicles", Country = "United States of America", StateProvince = "Oregon", City = "Beaverton", Category = "Fun House", Rating = 5, DestinationDescription = "In the United States, a department of motor vehicles (DMV) is a state-level government agency that administers vehicle registration and driver licensing." },
    //     new Destination { DestinationId = 7, DestinationName = "The Golden Man", Country = "America", StateProvince = "Oregon", City = "Salem City", Category = "Urban/Rural", Rating = 5, DestinationDescription = "Big Sleepy town" },
    //     new Destination { DestinationId = 8, DestinationName = "EMP Museum", Country = "America", StateProvince = "Washington", City = "Seattle", Category = "Urban", Rating = 5, DestinationDescription = "Where music live" },
    //     new Destination { DestinationId = 9, DestinationName = "Chicago Art Museum", Country = "America", StateProvince = "Illinois", City = "Chicago", Category = "Urban", Rating = 5, DestinationDescription = "Huge art museum" },
    //     new Destination { DestinationId = 10, DestinationName = "Waimānalo Beach", Country = "America", StateProvince = "Hawaii", City = "Waimānalo", Category = "Tropical", Rating = 5, DestinationDescription = "Relaxed beach with minimal tourist" },
    //     new Destination { DestinationId = 11, DestinationName = "El Torrito", Country = "Mexico", StateProvince = "Baja California", City = "Tijuana", Category = "Desert", Rating = 5, DestinationDescription = "Local Bar" }
    //   );
    // }
  }
}
