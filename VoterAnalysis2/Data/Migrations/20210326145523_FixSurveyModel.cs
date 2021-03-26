using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Data.Migrations
{
    public partial class FixSurveyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignManager_AspNetUsers_IdentityUserId",
                table: "CampaignManager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaignManager",
                table: "CampaignManager");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967e01a1-8447-47b8-afdc-e80c14595180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8d249b-6065-4b88-a594-5853f6eb345a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc95aa4d-7e57-4daa-8355-aa8f53548bf2");

            migrationBuilder.RenameTable(
                name: "CampaignManager",
                newName: "CampaignManagers");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignManager_IdentityUserId",
                table: "CampaignManagers",
                newName: "IX_CampaignManagers_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaignManagers",
                table: "CampaignManagers",
                column: "Id");

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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IdentityUserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AspNetUsers_IdentityUserID",
                        column: x => x.IdentityUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volunteers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoterContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfContact = table.Column<string>(nullable: true),
                    MadeContact = table.Column<bool>(nullable: false),
                    ContactScore = table.Column<int>(nullable: false),
                    VoteIn2020 = table.Column<int>(nullable: false),
                    PartyStance = table.Column<string>(nullable: true),
                    DirectionOfCountry = table.Column<string>(nullable: true),
                    DirectionOfSelf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoterContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterScore = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Suffic = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<string>(nullable: true),
                    VoterStatus = table.Column<string>(nullable: true),
                    PartyAffliation = table.Column<string>(nullable: true),
                    ResidentialAddress1 = table.Column<string>(nullable: true),
                    ResidentialSecondaryAddr = table.Column<string>(nullable: true),
                    ResidentialCity = table.Column<string>(nullable: true),
                    ResidentialState = table.Column<string>(nullable: true),
                    ResidentialZip = table.Column<string>(nullable: true),
                    PrecinctName = table.Column<string>(nullable: true),
                    PrecinctCode = table.Column<string>(nullable: true),
                    Ward = table.Column<string>(nullable: true),
                    Primary2010 = table.Column<string>(nullable: true),
                    General2010 = table.Column<string>(nullable: true),
                    Primary2012 = table.Column<string>(nullable: true),
                    General2012 = table.Column<string>(nullable: true),
                    Primary2014 = table.Column<string>(nullable: true),
                    General2014 = table.Column<string>(nullable: true),
                    Primary2016 = table.Column<string>(nullable: true),
                    General2016 = table.Column<string>(nullable: true),
                    Primary2018 = table.Column<string>(nullable: true),
                    General2018 = table.Column<string>(nullable: true),
                    Primary2020 = table.Column<string>(nullable: true),
                    General2020 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectionDayVotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasVoted = table.Column<bool>(nullable: false),
                    VolunteerId = table.Column<int>(nullable: false),
                    VoterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionDayVotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionDayVotes_Volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectionDayVotes_Voters_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Voters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ebcf70d-cacf-4964-83fd-8108cd42676c", "bc3d04cd-95d5-451e-80a6-efddf058d617", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db135d5a-7674-448b-ab00-228d11514c88", "530fa607-eb80-4b6f-bc2d-fc847ebe065d", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "480da0cd-2988-4cf5-9f04-9693287a5f7c", "66bf1383-5825-49be-96cf-f9aad303a2c4", "Volunteer", "VOLUNTEER" });

            migrationBuilder.CreateIndex(
                name: "IX_ElectionDayVotes_VolunteerId",
                table: "ElectionDayVotes",
                column: "VolunteerId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionDayVotes_VoterId",
                table: "ElectionDayVotes",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_IdentityUserID",
                table: "Staffs",
                column: "IdentityUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_IdentityUserId",
                table: "Volunteers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignManagers_AspNetUsers_IdentityUserId",
                table: "CampaignManagers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignManagers_AspNetUsers_IdentityUserId",
                table: "CampaignManagers");

            migrationBuilder.DropTable(
                name: "ElectionDayVotes");

            migrationBuilder.DropTable(
                name: "PrecinctsAssigned");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "VoterContacts");

            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaignManagers",
                table: "CampaignManagers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480da0cd-2988-4cf5-9f04-9693287a5f7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ebcf70d-cacf-4964-83fd-8108cd42676c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db135d5a-7674-448b-ab00-228d11514c88");

            migrationBuilder.RenameTable(
                name: "CampaignManagers",
                newName: "CampaignManager");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignManagers_IdentityUserId",
                table: "CampaignManager",
                newName: "IX_CampaignManager_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaignManager",
                table: "CampaignManager",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac8d249b-6065-4b88-a594-5853f6eb345a", "e910cf50-6f31-4419-964b-669c5caeaf97", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc95aa4d-7e57-4daa-8355-aa8f53548bf2", "0fba68d8-4f08-492f-a57f-7e342aa99459", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "967e01a1-8447-47b8-afdc-e80c14595180", "8a801e6b-decf-4209-b430-8be646b9e8e4", "Volunteer", "VOLUNTEER" });

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignManager_AspNetUsers_IdentityUserId",
                table: "CampaignManager",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
