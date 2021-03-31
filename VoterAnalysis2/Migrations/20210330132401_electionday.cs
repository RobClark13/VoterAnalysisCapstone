using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class electionday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76ee12b5-ee79-41c6-a4dc-3797ed1fad25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e866984e-b45e-4e82-b0d2-f556319fa53b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7b0738d-4f04-4d14-8267-801cc0bf4ad6");

            migrationBuilder.CreateTable(
                name: "ElectionDayAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectionDay = table.Column<bool>(nullable: false),
                    Precinct = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionDayAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionDayAssignments_Voters_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Voters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ElectionDayAssignments_StaffId",
                table: "ElectionDayAssignments",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectionDayAssignments");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76ee12b5-ee79-41c6-a4dc-3797ed1fad25", "13a3930d-468f-49de-9ff5-02b8f84df193", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7b0738d-4f04-4d14-8267-801cc0bf4ad6", "081e46e5-2e9e-42dd-b03e-072bb469d260", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e866984e-b45e-4e82-b0d2-f556319fa53b", "5c4c0c6e-8ab2-4863-92cf-c703cd9505de", "Volunteer", "VOLUNTEER" });
        }
    }
}
