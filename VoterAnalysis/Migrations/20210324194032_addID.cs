using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis.Migrations
{
    public partial class addID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "469987c7-51ac-4728-9602-fbbefe84aed6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b29dcfa-19f6-421f-8473-c8733faeabdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994eecba-5ab5-4404-8262-3db8f33d50e3");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserID",
                table: "Volunteers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserID",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserID",
                table: "CampaignManagers",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_IdentityUserID",
                table: "Volunteers",
                column: "IdentityUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_IdentityUserID",
                table: "Staffs",
                column: "IdentityUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignManagers_IdentityUserID",
                table: "CampaignManagers",
                column: "IdentityUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignManagers_AspNetUsers_IdentityUserID",
                table: "CampaignManagers",
                column: "IdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_AspNetUsers_IdentityUserID",
                table: "Staffs",
                column: "IdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteers_AspNetUsers_IdentityUserID",
                table: "Volunteers",
                column: "IdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignManagers_AspNetUsers_IdentityUserID",
                table: "CampaignManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_AspNetUsers_IdentityUserID",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Volunteers_AspNetUsers_IdentityUserID",
                table: "Volunteers");

            migrationBuilder.DropIndex(
                name: "IX_Volunteers_IdentityUserID",
                table: "Volunteers");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_IdentityUserID",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_CampaignManagers_IdentityUserID",
                table: "CampaignManagers");

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

            migrationBuilder.DropColumn(
                name: "IdentityUserID",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "IdentityUserID",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "IdentityUserID",
                table: "CampaignManagers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "469987c7-51ac-4728-9602-fbbefe84aed6", "851fee2b-2222-41cb-a6d3-be8f835e4032", "CampaignManager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b29dcfa-19f6-421f-8473-c8733faeabdd", "5fe8a563-e935-4b89-972a-05041f30d5ad", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "994eecba-5ab5-4404-8262-3db8f33d50e3", "acf8b3cc-0670-4a23-9adb-2f08c00ccb2a", "Volunteer", "VOLUNTEER" });
        }
    }
}
