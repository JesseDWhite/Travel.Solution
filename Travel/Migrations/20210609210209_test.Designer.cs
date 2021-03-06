// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20210609210209_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DestinationDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DestinationName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("StateProvince")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Category = "Test Category",
                            City = "Test City",
                            Country = "Test Country",
                            DestinationDescription = "Test Description",
                            DestinationName = "Test Name",
                            Rating = 5,
                            StateProvince = "Test State"
                        },
                        new
                        {
                            DestinationId = 2,
                            Category = "Beach",
                            City = "N/A",
                            Country = "Australia",
                            DestinationDescription = "The Great Barrier Reef is the world's largest coral reef system composed of over 2,900 individual reefs and 900 islands stretching for over 2,300 kilometres over an area of approximately 344,400 square kilometres. The reef is located in the Coral Sea, off the coast of Queensland, Australia.",
                            DestinationName = "The Great Barrier Reef",
                            Rating = 5,
                            StateProvince = "Queensland"
                        },
                        new
                        {
                            DestinationId = 3,
                            Category = "Historical Landmark",
                            City = "N/A",
                            Country = "United Kingdom",
                            DestinationDescription = "Legendary neolithic monument made using stones transported from Wales and built for unknown purpose.",
                            DestinationName = "Stonehenge",
                            Rating = 5,
                            StateProvince = "Salisbury"
                        },
                        new
                        {
                            DestinationId = 4,
                            Category = "Lake",
                            City = "Klamath Falls",
                            Country = "United States of America",
                            DestinationDescription = "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity: fed by rain and snow, it’s the deepest lake in the USA and one of the most pristine on earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range.",
                            DestinationName = "Crater Lake",
                            Rating = 5,
                            StateProvince = "Oregon"
                        },
                        new
                        {
                            DestinationId = 5,
                            Category = "Waterfall",
                            City = "Niagara Falls",
                            Country = "United States of America",
                            DestinationDescription = "Niagara Falls is a city on the Niagara River, in New York State. It’s known for the vast Niagara Falls, which straddle the Canadian border. In Niagara Falls State Park, the Observation Tower, at Prospect Point, juts out over Niagara Gorge for a view of all 3 waterfalls. Trails from the Niagara Gorge Discovery Center lead to other viewpoints. The Aquarium of Niagara is home to Humboldt penguins, seals and sea lions.",
                            DestinationName = "Niagara Falls",
                            Rating = 5,
                            StateProvince = "New York"
                        },
                        new
                        {
                            DestinationId = 6,
                            Category = "Fun House",
                            City = "Beaverton",
                            Country = "United States of America",
                            DestinationDescription = "In the United States, a department of motor vehicles (DMV) is a state-level government agency that administers vehicle registration and driver licensing.",
                            DestinationName = "Beaverton Driver and Motor Vehicles",
                            Rating = 5,
                            StateProvince = "Oregon"
                        },
                        new
                        {
                            DestinationId = 7,
                            Category = "Urban/Rural",
                            City = "Salem City",
                            Country = "America",
                            DestinationDescription = "Big Sleepy town",
                            DestinationName = "The Golden Man",
                            Rating = 5,
                            StateProvince = "Oregon"
                        },
                        new
                        {
                            DestinationId = 8,
                            Category = "Urban",
                            City = "Seattle",
                            Country = "America",
                            DestinationDescription = "Where music live",
                            DestinationName = "EMP Museum",
                            Rating = 5,
                            StateProvince = "Washington"
                        },
                        new
                        {
                            DestinationId = 9,
                            Category = "Urban",
                            City = "Chicago",
                            Country = "America",
                            DestinationDescription = "Huge art museum",
                            DestinationName = "Chicago Art Museum",
                            Rating = 5,
                            StateProvince = "Illinois"
                        },
                        new
                        {
                            DestinationId = 10,
                            Category = "Tropical",
                            City = "Waimānalo",
                            Country = "America",
                            DestinationDescription = "Relaxed beach with minimal tourist",
                            DestinationName = "Waimānalo Beach",
                            Rating = 5,
                            StateProvince = "Hawaii"
                        },
                        new
                        {
                            DestinationId = 11,
                            Category = "Desert",
                            City = "Tijuana",
                            Country = "Mexico",
                            DestinationDescription = "Local Bar",
                            DestinationName = "El Torrito",
                            Rating = 5,
                            StateProvince = "Baja California"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
