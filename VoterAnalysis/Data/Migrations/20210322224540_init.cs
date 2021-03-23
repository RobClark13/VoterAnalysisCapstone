using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a35df8c-9828-4600-bf65-59f014d744a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa489d8a-c89e-4c07-9137-b646645493b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be9d038a-67ab-491d-99b3-a3ef0581a72d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "aa489d8a-c89e-4c07-9137-b646645493b7", "bca9fc05-0212-44df-9b0e-1e648e391732", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be9d038a-67ab-491d-99b3-a3ef0581a72d", "6129fcbb-53ff-48e4-a547-d2f388791995", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a35df8c-9828-4600-bf65-59f014d744a4", "b4cff4d8-1ba6-4735-b848-3287daa9e952", "Volunteer", "VOLUNTEER" });
        }
    }
}
