using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class ElectionDayVote
    {
        [Key]
        public int Id { get; set; }
        public bool HasVoted { get; set; }
        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }
        public Volunteer Volunteer { get; set; }
        [ForeignKey("Voter")]
        public int VoterId { get; set; }
        public Voter Voter { get; set; }
    }
}
