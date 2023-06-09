using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkName", "State" },
                values: new object[,]
                {
                    { 1, "Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine.", "Acadia", "Maine" },
                    { 2, "Arches National Park is a national park in eastern Utah, United States. The park is adjacent to the Colorado River, 4 miles north of Moab, Utah. More than 2,000 natural sandstone arches are located in the park, including the well-known Delicate Arch, as well as a variety of unique geological resources and formations.", "Arches", "Utah" },
                    { 3, "Badlands National Park is an American national park located in southwestern South Dakota. The park protects 242,756 acres of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States.", "Badlands", "South Dakota" },
                    { 4, "Big Bend National Park is an American national park located in West Texas, bordering Mexico. The park has national significance as the largest protected area of Chihuahuan Desert topography and ecology in the United States.", "Big Bend", "Texas" },
                    { 5, "Biscayne National Park is an American national park in southern Florida, south of Miami. The park preserves Biscayne Bay and its offshore barrier reefs. Ninety-five percent of the park is water, and the shore of the bay is the location of an extensive mangrove forest.", "Biscayne", "Florida" },
                    { 6, "Black Canyon of the Gunnison National Park is an American national park located in western Colorado and managed by the National Park Service. There are two primary entrances to the park: the south rim entrance is located 15 miles east of Montrose, while the north rim entrance is 11 miles south of Crawford and is closed in the winter.", "Black Canyon of the Gunnison", "Colorado" },
                    { 7, "Bryce Canyon National Park is an American national park located in southwestern Utah. The major feature of the park is Bryce Canyon, which despite its name, is not a canyon, but a collection of giant natural amphitheaters along the eastern side of the Paunsaugunt Plateau.", "Bryce Canyon", "Utah" },
                    { 8, "Canyonlands National Park is an American national park located in southeastern Utah near the town of Moab. The park preserves a colorful landscape eroded into countless canyons, mesas, and buttes by the Colorado River, the Green River, and their respective tributaries.", "Canyonlands", "Utah" },
                    { 9, "Capitol Reef National Park is an American national park located in south-central Utah. The park is approximately 60 miles long on its north–south axis but an average of just 6 miles wide. The park was established in 1971 to preserve 241,904 acres of desert landscape and is open all year with May through September being the highest visitation months.", "Capitol Reef", "Utah" },
                    { 10, "Carlsbad Caverns National Park is an American national park in the Guadalupe Mountains of southeastern New Mexico. The primary attraction of the park is the show cave, Carlsbad Cavern. Carlsbad Caverns National Park is open every day of the year except Thanksgiving, Christmas, and New Year's Day.", "Carlsbad Caverns", "New Mexico" },
                    { 11, "Channel Islands National Park is an American national park that consists of five of the eight Channel Islands off the coast of the U.S. state of California, in the Pacific Ocean. Although the islands are close to the shore of densely populated Southern California, their isolation has left them relatively undeveloped.", "Channel Islands", "California" },
                    { 12, "Congaree National Park is an American national park in central South Carolina. The park preserves the largest tract of old growth bottomland hardwood forest left in the United States. The lush trees growing in this floodplain forest are some of the tallest in the Eastern U.S., forming one of the highest temperate deciduous forest canopies remaining in the world.", "Congaree", "South Carolina" },
                    { 13, "Crater Lake National Park is an American national park located in southern Oregon. Established in 1902, Crater Lake is the fifth-oldest national park in the United States and the only national park in Oregon. The park encompasses the caldera of Crater Lake, a remnant of a destroyed volcano, Mount Mazama, and the surrounding hills and forests.", "Crater Lake", "Oregon" },
                    { 14, "Cuyahoga Valley National Park is an American national park that preserves and reclaims the rural landscape along the Cuyahoga River between Akron and Cleveland in Northeast Ohio. The 32,572-acre park is administered by the National Park Service, but within its boundaries are areas independently managed as county parks or as public or private businesses.", "Cuyahoga Valley", "Ohio" },
                    { 15, "Death Valley National Park is an American national park that straddles the California–Nevada border, east of the Sierra Nevada. The park boundaries include Death Valley, the northern section of Panamint Valley, the southern section of Eureka Valley, and most of Saline Valley.", "Death Valley", "California" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);
        }
    }
}
