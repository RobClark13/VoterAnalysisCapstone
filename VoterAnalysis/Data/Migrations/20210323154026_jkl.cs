using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Data.Migrations
{
    public partial class jkl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "354c9f6d-7718-491b-b69d-e409461926e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf25ce0e-1bf7-40e2-b41b-a7c42e4efd08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea42500e-7fcb-460c-9244-257c57eb1790");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CampaignManagers",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "PrecinctsAssigned",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precinct = table.Column<string>(nullable: true),
                    CampaignManagerId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecinctsAssigned", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bad1ecb3-5a36-464b-946c-46c908dee41d", "a8cb4f12-f5bc-4405-8c21-61ffd5c27c70", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddda8aee-85e0-4b86-8701-b6a1559f251e", "5bb017d7-0d29-44a3-abd7-26d9250a2162", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a237fdb-eed0-415a-b825-bcdd8511da2b", "83fab72a-2c84-462d-9e4d-6f1d22f44d74", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrecinctsAssigned");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a237fdb-eed0-415a-b825-bcdd8511da2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad1ecb3-5a36-464b-946c-46c908dee41d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddda8aee-85e0-4b86-8701-b6a1559f251e");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CampaignManagers",
                newName: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea42500e-7fcb-460c-9244-257c57eb1790", "389bbfd6-3e1f-4a46-ae89-1b7c5195b946", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "354c9f6d-7718-491b-b69d-e409461926e6", "be91ab06-bc4a-4a98-9887-21a217618799", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf25ce0e-1bf7-40e2-b41b-a7c42e4efd08", "eaca8f47-061e-4408-ae5c-22394123edba", "Volunteer", "VOLUNTEER" });
        }
    }
}
