using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class addedfieldsvoter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30684273-4e69-4ccd-8b2d-5ec07c079502");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "465765df-5843-4ab7-bd68-686e42682989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac6f1ea1-ee73-42df-803f-ffe8a47a6b6a");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Voters",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Voters",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Voters");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30684273-4e69-4ccd-8b2d-5ec07c079502", "db3a34ca-e488-421a-a12a-40574f989af6", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "465765df-5843-4ab7-bd68-686e42682989", "4ebe6c23-c8f8-4d65-8ec6-adae7d7f2beb", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac6f1ea1-ee73-42df-803f-ffe8a47a6b6a", "f9fef248-54eb-4850-a1a0-922ec30c3094", "Volunteer", "VOLUNTEER" });
        }
    }
}
