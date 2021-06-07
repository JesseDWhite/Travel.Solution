using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Category", "City", "Country", "DestinationDescription", "DestinationName", "Rating", "StateProvince" },
                values: new object[] { 1, "Test Category", "Test City", "Test Country", "Test Description", "Test Name", 5, "Test State" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);
        }
    }
}
