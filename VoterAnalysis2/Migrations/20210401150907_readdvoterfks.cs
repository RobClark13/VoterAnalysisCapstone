using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class readdvoterfks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Voters",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Voters",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4631b30e-2c8e-4c08-a307-b59dbe99dae0", "247a6320-4920-4fe4-9837-cb05c7ef0470", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "292a5fc1-e805-4559-8581-f0b15f8e31d5", "0b8d0b09-c8d1-4e76-9628-d702f6da994a", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6874865-3c2f-48ce-85ec-aa0c7a2b7206", "4d120195-69e2-4f51-a056-8b823bcb90b1", "Volunteer", "VOLUNTEER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292a5fc1-e805-4559-8581-f0b15f8e31d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4631b30e-2c8e-4c08-a307-b59dbe99dae0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6874865-3c2f-48ce-85ec-aa0c7a2b7206");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Voters",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Voters",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
