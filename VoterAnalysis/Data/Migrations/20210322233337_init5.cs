using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "039d32f2-6d98-4ca4-a855-ed2e7691aea1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4495e8cc-6652-491c-ace1-1690f5695e1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80917310-a9b1-4e7d-b90f-00f902b8d70e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "039d32f2-6d98-4ca4-a855-ed2e7691aea1", "c87ebea9-8908-464f-afe4-742e7c8d53ed", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80917310-a9b1-4e7d-b90f-00f902b8d70e", "38d75a25-fd87-4e1a-9b02-8b7adce7d728", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4495e8cc-6652-491c-ace1-1690f5695e1e", "6d278353-afb6-4fc5-a3c5-964eabdd90ec", "Volunteer", "VOLUNTEER" });
        }
    }
}
