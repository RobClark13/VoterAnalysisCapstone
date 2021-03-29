using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "314ddca1-5243-4766-856c-de837c470f6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35072806-be18-449f-b9c7-e140dc500e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e57dd4-56b9-4926-9ff1-c2ebb152a5dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37ec4994-bcc1-41ad-a1f1-8de8f19e660b", "83a27dbd-fac2-4b44-a415-05433b91775c", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e7f717f-0ba3-4e05-91b3-93b9f8d48c7d", "f0b3593d-7a9c-45cd-9206-8ed2fcb86bcb", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59a98676-5781-412a-8707-6f43577c2b96", "fb7d8ef2-b853-4f17-af25-931b862cb655", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ec4994-bcc1-41ad-a1f1-8de8f19e660b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7f717f-0ba3-4e05-91b3-93b9f8d48c7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59a98676-5781-412a-8707-6f43577c2b96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5e57dd4-56b9-4926-9ff1-c2ebb152a5dc", "68ed69d5-0829-4772-9ada-fc3ac7bffb47", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35072806-be18-449f-b9c7-e140dc500e14", "f740c18f-2068-48dc-b5a3-bb181f1e61da", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "314ddca1-5243-4766-856c-de837c470f6e", "3b0eeca6-2d70-4afd-8cb1-144e149671b9", "Volunteer", "VOLUNTEER" });
        }
    }
}
