using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
  public class ParkApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public ParkApiContext(DbContextOptions<ParkApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, ParkName = "Acadia", State = "Maine", Description = "Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine." },
          new Park { ParkId = 2, ParkName = "Arches", State = "Utah", Description = "Arches National Park is a national park in eastern Utah, United States. The park is adjacent to the Colorado River, 4 miles north of Moab, Utah. More than 2,000 natural sandstone arches are located in the park, including the well-known Delicate Arch, as well as a variety of unique geological resources and formations." },
          new Park { ParkId = 3, ParkName = "Badlands", State = "South Dakota", Description = "Badlands National Park is an American national park located in southwestern South Dakota. The park protects 242,756 acres of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States." },
          new Park { ParkId = 4, ParkName = "Big Bend", State = "Texas", Description = "Big Bend National Park is an American national park located in West Texas, bordering Mexico. The park has national significance as the largest protected area of Chihuahuan Desert topography and ecology in the United States." },
          new Park { ParkId = 5, ParkName = "Biscayne", State = "Florida", Description = "Biscayne National Park is an American national park in southern Florida, south of Miami. The park preserves Biscayne Bay and its offshore barrier reefs. Ninety-five percent of the park is water, and the shore of the bay is the location of an extensive mangrove forest." },
          new Park { ParkId = 6, ParkName = "Black Canyon of the Gunnison", State = "Colorado", Description = "Black Canyon of the Gunnison National Park is an American national park located in western Colorado and managed by the National Park Service. There are two primary entrances to the park: the south rim entrance is located 15 miles east of Montrose, while the north rim entrance is 11 miles south of Crawford and is closed in the winter." },
          new Park { ParkId = 7, ParkName = "Bryce Canyon", State = "Utah", Description = "Bryce Canyon National Park is an American national park located in southwestern Utah. The major feature of the park is Bryce Canyon, which despite its name, is not a canyon, but a collection of giant natural amphitheaters along the eastern side of the Paunsaugunt Plateau." },
          new Park { ParkId = 8, ParkName = "Canyonlands", State = "Utah", Description = "Canyonlands National Park is an American national park located in southeastern Utah near the town of Moab. The park preserves a colorful landscape eroded into countless canyons, mesas, and buttes by the Colorado River, the Green River, and their respective tributaries." },
          new Park { ParkId = 9, ParkName = "Capitol Reef", State = "Utah", Description = "Capitol Reef National Park is an American national park located in south-central Utah. The park is approximately 60 miles long on its north–south axis but an average of just 6 miles wide. The park was established in 1971 to preserve 241,904 acres of desert landscape and is open all year with May through September being the highest visitation months." },
          new Park { ParkId = 10, ParkName = "Carlsbad Caverns", State = "New Mexico", Description = "Carlsbad Caverns National Park is an American national park in the Guadalupe Mountains of southeastern New Mexico. The primary attraction of the park is the show cave, Carlsbad Cavern. Carlsbad Caverns National Park is open every day of the year except Thanksgiving, Christmas, and New Year's Day." },
          new Park { ParkId = 11, ParkName = "Channel Islands", State = "California", Description = "Channel Islands National Park is an American national park that consists of five of the eight Channel Islands off the coast of the U.S. state of California, in the Pacific Ocean. Although the islands are close to the shore of densely populated Southern California, their isolation has left them relatively undeveloped." },
          new Park { ParkId = 12, ParkName = "Congaree", State = "South Carolina", Description = "Congaree National Park is an American national park in central South Carolina. The park preserves the largest tract of old growth bottomland hardwood forest left in the United States. The lush trees growing in this floodplain forest are some of the tallest in the Eastern U.S., forming one of the highest temperate deciduous forest canopies remaining in the world." },
          new Park { ParkId = 13, ParkName = "Crater Lake", State = "Oregon", Description = "Crater Lake National Park is an American national park located in southern Oregon. Established in 1902, Crater Lake is the fifth-oldest national park in the United States and the only national park in Oregon. The park encompasses the caldera of Crater Lake, a remnant of a destroyed volcano, Mount Mazama, and the surrounding hills and forests." },
          new Park { ParkId = 14, ParkName = "Cuyahoga Valley", State = "Ohio", Description = "Cuyahoga Valley National Park is an American national park that preserves and reclaims the rural landscape along the Cuyahoga River between Akron and Cleveland in Northeast Ohio. The 32,572-acre park is administered by the National Park Service, but within its boundaries are areas independently managed as county parks or as public or private businesses." },
          new Park { ParkId = 15, ParkName = "Death Valley", State = "California", Description = "Death Valley National Park is an American national park that straddles the California–Nevada border, east of the Sierra Nevada. The park boundaries include Death Valley, the northern section of Panamint Valley, the southern section of Eureka Valley, and most of Saline Valley." }
        );
    }
  }
}