using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Migrations
{
    public partial class seamus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "868f0134-dd64-4244-925f-2dce74f74123");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d2b61aa-10b3-4695-b719-2613b7e168f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3133a33-74fa-42fc-b5c0-5ae277fd56c5");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Staffs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e2e9973-afd7-42d9-83c5-32e52e8f48ab", "ebd87768-61a3-4916-846b-0f4129530b7c", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e230d26f-e2b4-488a-a37c-43c42c52a108", "a55b586b-6980-41a2-bafc-2386410a7072", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a710753-5057-4c11-a5d4-751e0081f711", "6754909e-c06d-40df-afbe-a665c30646a4", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a710753-5057-4c11-a5d4-751e0081f711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e2e9973-afd7-42d9-83c5-32e52e8f48ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e230d26f-e2b4-488a-a37c-43c42c52a108");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Staffs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "868f0134-dd64-4244-925f-2dce74f74123", "39234ebc-6da0-4a76-ae6b-0b5d15c3ba23", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3133a33-74fa-42fc-b5c0-5ae277fd56c5", "7364bf6e-7356-4384-a0c1-744f1e9fa628", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d2b61aa-10b3-4695-b719-2613b7e168f5", "ab550454-4fbf-46fb-8d87-37c42800bf19", "Volunteer", "VOLUNTEER" });
        }
    }
}
