using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class addedfieldtoprecinctassignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "204b61fb-9964-473d-ac24-dbc54f8c2d39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519490d3-e5f4-4570-8853-8bde6672e68e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "900a60a3-4645-4f02-a9d0-3b66eb5843e2");

            migrationBuilder.AddColumn<bool>(
                name: "ElectionDay",
                table: "PrecinctsAssigned",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dadcd1f8-911a-46a9-b2b5-98ccd7c554bc", "98b14edf-4e6e-4d54-aa20-ecc9cf822dae", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "199c618a-6c2f-4d53-b62f-ad58f70d81a7", "27b9f442-ec1b-4193-b9b2-3b746c70f83e", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e03341f5-70e2-4883-baea-0a686bcd9059", "84cd41d1-ac61-485a-954e-a9de165338bd", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "199c618a-6c2f-4d53-b62f-ad58f70d81a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dadcd1f8-911a-46a9-b2b5-98ccd7c554bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e03341f5-70e2-4883-baea-0a686bcd9059");

            migrationBuilder.DropColumn(
                name: "ElectionDay",
                table: "PrecinctsAssigned");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "519490d3-e5f4-4570-8853-8bde6672e68e", "b7806123-0943-4b2f-93d9-aa7d07db2854", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "900a60a3-4645-4f02-a9d0-3b66eb5843e2", "c7529fee-e4a7-4254-85eb-2eef1cb6919d", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "204b61fb-9964-473d-ac24-dbc54f8c2d39", "ac98f07f-7cc7-49cd-92e6-ad16f7ad6a6b", "Volunteer", "VOLUNTEER" });
        }
    }
}
