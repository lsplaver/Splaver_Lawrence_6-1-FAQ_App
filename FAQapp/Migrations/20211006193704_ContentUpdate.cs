using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQapp.Migrations
{
    public partial class ContentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 3,
                column: "SecondLink",
                value: "https://open.spotify.com/artist/2NPduAUeLVsfIauhRwuft1");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 9,
                column: "BandWebsite",
                value: "https://battlebeast.fi/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 3,
                column: "SecondLink",
                value: "https://open.spotify.com/artist/2NPduAUeLVsfIauhRwuft1?si=P_b0Qe5SQEavH4JsqCeIgA&nd=1");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 9,
                column: "BandWebsite",
                value: "https://www.nightwish.com/");
        }
    }
}
