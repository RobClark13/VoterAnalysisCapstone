using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VoterAnalysis2.Models;

namespace VoterAnalysis2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CampaignManager> CampaignManagers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<PrecinctAssigned> PrecinctsAssigned { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
       
        public DbSet<Voter> Voters { get; set; }
        public DbSet<VoterId> VoterContacts { get; set; }
        public DbSet<VoterScore> VoterScores { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Campaign Manager",
                    NormalizedName="CAMPAIGNMANAGER"
                },
                  new IdentityRole
                  {
                      Name = "Staff",
                      NormalizedName = "STAFF"
                  },
                    new IdentityRole
                    {
                        Name = "Volunteer",
                        NormalizedName = "VOLUNTEER"
                    }
                );
        }
        
       
    }
}
