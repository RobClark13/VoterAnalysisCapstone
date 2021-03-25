using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d825bd55-70f5-43a8-af23-2849ede79f11", "3a3be1c6-d15d-403f-b660-195b716e623f", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f14847b-27ef-4f05-a858-a1e32d96c25c", "aa8a078c-b454-4e2c-a17e-ee57b92401c8", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab5dcec5-18df-4710-89e4-8804ced3b3e8", "b6f5619c-e7bd-4d29-9b48-ed7c3d39c9a3", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f14847b-27ef-4f05-a858-a1e32d96c25c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab5dcec5-18df-4710-89e4-8804ced3b3e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d825bd55-70f5-43a8-af23-2849ede79f11");
        }
    }
}
