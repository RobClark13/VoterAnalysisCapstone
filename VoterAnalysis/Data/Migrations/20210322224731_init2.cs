using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81154103-5909-407a-b410-d5d17c9909ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93300f84-85b3-44c3-b34a-19e6dff86367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c01bac99-46a3-48be-9473-5bad99e8e674");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c01bac99-46a3-48be-9473-5bad99e8e674", "caaf6aed-b0d5-483e-935e-a66f2b6b6d77", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93300f84-85b3-44c3-b34a-19e6dff86367", "361f75c6-f88b-4d39-8e1e-80b9fcd048ea", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81154103-5909-407a-b410-d5d17c9909ad", "e5ceed6f-5657-4e27-b0c4-c51305ffd978", "Volunteer", "VOLUNTEER" });
        }
    }
}
