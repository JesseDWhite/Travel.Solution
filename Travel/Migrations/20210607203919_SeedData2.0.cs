using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Category", "City", "Country", "DestinationDescription", "DestinationName", "Rating", "StateProvince" },
                values: new object[,]
                {
                    { 2, "Beach", "N/A", "Australia", "The Great Barrier Reef is the world's largest coral reef system composed of over 2,900 individual reefs and 900 islands stretching for over 2,300 kilometres over an area of approximately 344,400 square kilometres. The reef is located in the Coral Sea, off the coast of Queensland, Australia.", "The Great Barrier Reef", 5, "Queensland" },
                    { 3, "Historical Landmark", "N/A", "United Kingdom", "Legendary neolithic monument made using stones transported from Wales and built for unknown purpose.", "Stonehenge", 5, "Salisbury" },
                    { 4, "Lake", "Klamath Falls", "United States of America", "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity: fed by rain and snow, it’s the deepest lake in the USA and one of the most pristine on earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range.", "Crater Lake", 5, "Oregon" },
                    { 5, "Waterfall", "Niagara Falls", "United States of America", "Niagara Falls is a city on the Niagara River, in New York State. It’s known for the vast Niagara Falls, which straddle the Canadian border. In Niagara Falls State Park, the Observation Tower, at Prospect Point, juts out over Niagara Gorge for a view of all 3 waterfalls. Trails from the Niagara Gorge Discovery Center lead to other viewpoints. The Aquarium of Niagara is home to Humboldt penguins, seals and sea lions.", "Niagara Falls", 5, "New York" },
                    { 6, "Fun House", "Beaverton", "United States of America", "In the United States, a department of motor vehicles (DMV) is a state-level government agency that administers vehicle registration and driver licensing.", "Beaverton Driver and Motor Vehicles", 5, "Oregon" },
                    { 7, "Urban/Rural", "Salem City", "America", "Big Sleepy town", "The Golden Man", 5, "Oregon" },
                    { 8, "Urban", "Seattle", "America", "Where music live", "EMP Museum", 5, "Washington" },
                    { 9, "Urban", "Chicago", "America", "Huge art museum", "Chicago Art Museum", 5, "Illinois" },
                    { 10, "Tropical", "Waimānalo", "America", "Relaxed beach with minimal tourist", "Waimānalo Beach", 5, "Hawaii" },
                    { 11, "Desert", "Tijuana", "Mexico", "Local Bar", "El Torrito", 5, "Baja California" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 11);
        }
    }
}
