using Microsoft.EntityFrameworkCore.Migrations;

namespace VoterAnalysis2.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectionDayVotes_Voters_VoterId",
                table: "ElectionDayVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterIds_Voters_StaffId",
                table: "VoterIds");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterIds_Voters_VoterId",
                table: "VoterIds");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterScores_Voters_VoterId",
                table: "VoterScores");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterStances_Voters_StaffId",
                table: "VoterStances");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterStances_Voters_VoterId",
                table: "VoterStances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voters",
                table: "Voters");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "364dfe5e-bdf9-48cd-8bfc-6468e41948b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "440c7713-3e9d-4e0e-a096-fb1761f8e972");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0a8c597-223a-48e8-9913-1477ceaf3366");


            migrationBuilder.AddPrimaryKey(
                name: "PK_Voters2",
                table: "Voters2",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00a13ffc-6841-41f1-854c-5c6b0f5b6513", "c7e4da56-1fa5-4145-a1df-a2c4ed792902", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "417aea5f-3845-4659-b937-03795b17fd93", "32a282f9-d298-4627-9049-b8462bdd41ea", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35e81b1a-d606-44c8-811f-304206506197", "d126e211-3dd4-4457-98c7-db62e7edd7e0", "Volunteer", "VOLUNTEER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ElectionDayVotes_Voters2_VoterId",
                table: "ElectionDayVotes",
                column: "VoterId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterIds_Voters2_StaffId",
                table: "VoterIds",
                column: "StaffId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterIds_Voters2_VoterId",
                table: "VoterIds",
                column: "VoterId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterScores_Voters2_VoterId",
                table: "VoterScores",
                column: "VoterId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterStances_Voters2_StaffId",
                table: "VoterStances",
                column: "StaffId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterStances_Voters2_VoterId",
                table: "VoterStances",
                column: "VoterId",
                principalTable: "Voters2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectionDayVotes_Voters2_VoterId",
                table: "ElectionDayVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterIds_Voters2_StaffId",
                table: "VoterIds");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterIds_Voters2_VoterId",
                table: "VoterIds");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterScores_Voters2_VoterId",
                table: "VoterScores");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterStances_Voters2_StaffId",
                table: "VoterStances");

            migrationBuilder.DropForeignKey(
                name: "FK_VoterStances_Voters2_VoterId",
                table: "VoterStances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voters2",
                table: "Voters2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00a13ffc-6841-41f1-854c-5c6b0f5b6513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35e81b1a-d606-44c8-811f-304206506197");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417aea5f-3845-4659-b937-03795b17fd93");

       

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voters",
                table: "Voters",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "440c7713-3e9d-4e0e-a096-fb1761f8e972", "085d973d-9854-466d-9c94-6a3e3104eecb", "Campaign Manager", "CAMPAIGNMANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0a8c597-223a-48e8-9913-1477ceaf3366", "337423cb-ef95-4cdb-ab8b-ee4b983dbf0b", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "364dfe5e-bdf9-48cd-8bfc-6468e41948b7", "276f8bd6-4cb4-4bdf-8f3b-664496adca21", "Volunteer", "VOLUNTEER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ElectionDayVotes_Voters_VoterId",
                table: "ElectionDayVotes",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterIds_Voters_StaffId",
                table: "VoterIds",
                column: "StaffId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterIds_Voters_VoterId",
                table: "VoterIds",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterScores_Voters_VoterId",
                table: "VoterScores",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterStances_Voters_StaffId",
                table: "VoterStances",
                column: "StaffId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoterStances_Voters_VoterId",
                table: "VoterStances",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
