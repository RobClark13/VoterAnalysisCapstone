// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoterAnalysis2.Data;

namespace VoterAnalysis2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "f9fca5a9-de1b-420b-96ba-155305968e91",
                            ConcurrencyStamp = "e10e25d6-046b-4945-95a4-736b386bd232",
                            Name = "Campaign Manager",
                            NormalizedName = "CAMPAIGNMANAGER"
                        },
                        new
                        {
                            Id = "e3478e2d-0b53-454b-96f2-cd35903086d1",
                            ConcurrencyStamp = "2016e0b2-fe92-40b1-b869-7b3957083b4a",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = "5039b9c9-0c49-480a-b70c-beffe77b9551",
                            ConcurrencyStamp = "fe4dc50c-6e0d-4e7f-8ef7-6ddd53d07e0f",
                            Name = "Volunteer",
                            NormalizedName = "VOLUNTEER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.CampaignManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("CampaignManagers");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.ElectionDayAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Precinct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ElectionDayAssignments");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.ElectionDayVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasVoted")
                        .HasColumnType("bit");

                    b.Property<int?>("VoterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VoterId");

                    b.ToTable("ElectionDayVotes");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.PrecinctAssigned", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Precinct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrecinctsAssigned");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CareerCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitySchoolDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongressionalDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountyCourtDistict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountyNumber")
                        .HasColumnType("int");

                    b.Property<string>("County_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourtOfAppeals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationServiceCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExemptedVillageSchoolDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2010")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2012")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2014")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2016")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2018")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General2020")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalSchoolDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingZipPlus4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MunicipalCourtDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyAffliation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecinctCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecinctName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2010")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2012")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2014")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2016")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2018")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary2020")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidentialZipPlus4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOSVoterId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateBoardOfEducation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateRepresentativeDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateSenateDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Township")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoterStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.VoterIdSurvey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactScore")
                        .HasColumnType("int");

                    b.Property<string>("DateContacted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectionOfCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectionOfSelf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MadeContact")
                        .HasColumnType("bit");

                    b.Property<string>("PartyStance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoteIn2020")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VoterId");

                    b.ToTable("VoterIds");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.VoterScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VoterId");

                    b.ToTable("VoterScores");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VoterAnalysis2.Models.CampaignManager", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.ElectionDayVote", b =>
                {
                    b.HasOne("VoterAnalysis2.Models.Voter", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterId");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.Staff", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.Volunteer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("VoterAnalysis2.Models.VoterIdSurvey", b =>
                {
                    b.HasOne("VoterAnalysis2.Models.Voter", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VoterAnalysis2.Models.VoterScore", b =>
                {
                    b.HasOne("VoterAnalysis2.Models.Voter", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
