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
                keyValue: "963e39fb-e94e-4acd-bf6e-123caf83c798");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9e07039-9a23-437b-8ab6-0ade71bf91dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eff43c24-d02c-4a98-a356-3cce9fad91cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9fca5a9-de1b-420b-96ba-155305968e91", "e10e25d6-046b-4945-95a4-736b386bd232", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3478e2d-0b53-454b-96f2-cd35903086d1", "2016e0b2-fe92-40b1-b869-7b3957083b4a", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5039b9c9-0c49-480a-b70c-beffe77b9551", "fe4dc50c-6e0d-4e7f-8ef7-6ddd53d07e0f", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5039b9c9-0c49-480a-b70c-beffe77b9551");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3478e2d-0b53-454b-96f2-cd35903086d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9fca5a9-de1b-420b-96ba-155305968e91");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eff43c24-d02c-4a98-a356-3cce9fad91cf", "80a61003-4aae-4f4d-893c-1bf9c87b3837", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9e07039-9a23-437b-8ab6-0ade71bf91dc", "cd20630b-0fec-424c-ae97-8e4c35c1d5e5", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "963e39fb-e94e-4acd-bf6e-123caf83c798", "8616d470-e703-424c-a6d2-68af969dd3c5", "Volunteer", "VOLUNTEER" });
        }
    }
}
