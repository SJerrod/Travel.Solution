using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Date", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Orlando", "United States", "06/14/2019", 3, "Disney world and Universal Studios all in one city, Whats not to like" },
                    { 2, "London", "United Kingdom", "10/28/2020", 4, "Couldnt get the Royal Guards to laugh, but at least I didnt wind up in the tower of London" },
                    { 3, "Tokyo", "Japan", "04/14/2018", 5, "The cherry blossom festival is a MUST SEE" },
                    { 4, "Sydney", "Australia", "03/08/2019", 4, "They wouldnt let me sing at the opera house, Must have been all the shrimp I ate off the barbie" },
                    { 5, "Toronto", "Canada", "12/11/2018", 3, "Much to cold for my taste, But the Tim Hortens was fantastic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
