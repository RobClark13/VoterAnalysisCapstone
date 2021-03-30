using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class VoterIdSurvey
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateContacted { get; set; }
        public string TypeOfContact { get; set; }
        public bool MadeContact { get; set; }
        public int ContactScore { get; set; }
        public int VoteIn2020 { get; set; }
        public string PartyStance { get; set; }
        public string DirectionOfCountry { get; set; }
        public string DirectionOfSelf { get; set; }
        [ForeignKey("Voter")]
        public int? VoterId { get; set; }
        public Voter Voter { get; set; }
        [ForeignKey("Staff")]
        public int? StaffId { get; set; }
        public Voter Staff { get; set; }

    }
}
