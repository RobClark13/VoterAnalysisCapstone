using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class addedElectionDayAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
