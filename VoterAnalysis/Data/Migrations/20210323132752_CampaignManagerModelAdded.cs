using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Data.Migrations
{
    public partial class CampaignManagerModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cecafa1-0d19-4bb7-acb0-9f2eeed00f35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d6cd0d2-5d3d-4119-9a1e-8f97650fbe34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31eb22ec-46ff-4b37-b727-fee8f1edec6d");

            migrationBuilder.CreateTable(
                name: "CampaignManagers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignManagers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea42500e-7fcb-460c-9244-257c57eb1790", "389bbfd6-3e1f-4a46-ae89-1b7c5195b946", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "354c9f6d-7718-491b-b69d-e409461926e6", "be91ab06-bc4a-4a98-9887-21a217618799", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf25ce0e-1bf7-40e2-b41b-a7c42e4efd08", "eaca8f47-061e-4408-ae5c-22394123edba", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignManagers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "354c9f6d-7718-491b-b69d-e409461926e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf25ce0e-1bf7-40e2-b41b-a7c42e4efd08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea42500e-7fcb-460c-9244-257c57eb1790");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d6cd0d2-5d3d-4119-9a1e-8f97650fbe34", "1fa1b88a-4492-4f23-858f-c2ba267c3a8e", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31eb22ec-46ff-4b37-b727-fee8f1edec6d", "eb45a823-99e3-48c0-9779-576cf4b3450b", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cecafa1-0d19-4bb7-acb0-9f2eeed00f35", "ab97c600-f8f5-4bfe-8cd9-cc3b845552d4", "Volunteer", "VOLUNTEER" });
        }
    }
}
