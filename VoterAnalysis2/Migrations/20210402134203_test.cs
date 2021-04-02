using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00a13ffc-6841-41f1-854c-5c6b0f5b6513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35e81b1a-d606-44c8-811f-304206506197");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417aea5f-3845-4659-b937-03795b17fd93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94e3d9a5-474f-409d-8a4e-49d413c5606f", "65d126b6-41a9-49bd-9392-462f10d0abed", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "063108f1-8e0d-44f5-9a18-4391700d287b", "af34a564-f3bc-4bfe-ae23-eb320743f978", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdfe4054-4348-4465-b254-e1fd042f5fbd", "a78a27de-6b91-4523-9aed-95d217d7d47f", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "063108f1-8e0d-44f5-9a18-4391700d287b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e3d9a5-474f-409d-8a4e-49d413c5606f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdfe4054-4348-4465-b254-e1fd042f5fbd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00a13ffc-6841-41f1-854c-5c6b0f5b6513", "c7e4da56-1fa5-4145-a1df-a2c4ed792902", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "417aea5f-3845-4659-b937-03795b17fd93", "32a282f9-d298-4627-9049-b8462bdd41ea", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35e81b1a-d606-44c8-811f-304206506197", "d126e211-3dd4-4457-98c7-db62e7edd7e0", "Volunteer", "VOLUNTEER" });
        }
    }
}
