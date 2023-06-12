using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkApi.Migrations
{
    public partial class MoreParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkName", "State" },
                values: new object[,]
                {
                    { 16, "Denali National Park and Preserve is an American national park and preserve located in Interior Alaska, centered on Denali, the highest mountain in North America. The park and contiguous preserve encompass 6,045,153 acres which is larger than the state of New Hampshire.", "Denali", "Alaska" },
                    { 17, "Devil's Lake State Park is a state park located in the Baraboo Range in eastern Sauk County, just south of Baraboo, Wisconsin. Devil's Lake State Park is the biggest state park in Wisconsin. It is around thirty-five miles northwest of Madison, and is on the western edge of the last ice-sheet deposited during the Wisconsin drift.", "Devil's Lake", "Wisconsin" },
                    { 18, "Dinosaur Valley State Park is a state park near Glen Rose, Texas, United States. The park, which has been part of the Texas state park system since 1972, is located mostly in Somervell County, although it also extends into Hood County. The park's main attraction is two large sauropod dinosaur footprints.", "Dinosaur Valley", "Texas" },
                    { 19, "Ecola State Park is a state park located approximately 2.5 miles north of Cannon Beach in Clatsop County in the U.S. state of Oregon. It is administered by the Oregon Parks and Recreation Department.", "Ecola", "Oregon" },
                    { 20, "Everglades National Park is an American national park that protects the southern twenty percent of the original Everglades in Florida. The park is the largest tropical wilderness in the United States, and the largest wilderness of any kind east of the Mississippi River.", "Everglades", "Florida" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);
        }
    }
}
