using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class fixvoterslat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20b89416-d8ea-4167-ae10-d446008f6b8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1dec4c0-a0c3-4c1d-9282-5d9b458a8811");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1503396-c05c-4f2b-bbb3-c8e5993d96f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "452faeda-9078-4679-af42-6276304f88f5", "dabd2ca7-95b2-4fdd-af0e-0febbfd23aa0", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "450bc7dc-244f-4847-9354-f19c573b60ec", "47a0d81b-03c3-4678-8fde-bdb2c7b9d879", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a88beb96-dea4-4a0e-9138-f732492aa4ce", "c48c2a62-12ff-4b59-b044-d2046fb67608", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "450bc7dc-244f-4847-9354-f19c573b60ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "452faeda-9078-4679-af42-6276304f88f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a88beb96-dea4-4a0e-9138-f732492aa4ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1dec4c0-a0c3-4c1d-9282-5d9b458a8811", "21fab60a-0901-445b-99b9-7fbc1d0b9caa", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20b89416-d8ea-4167-ae10-d446008f6b8f", "41939fe3-bcdf-4e04-8a23-ef19403f5c7c", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1503396-c05c-4f2b-bbb3-c8e5993d96f9", "5eb08231-03e4-4f91-a23d-767f9dc270e0", "Volunteer", "VOLUNTEER" });
        }
    }
}
