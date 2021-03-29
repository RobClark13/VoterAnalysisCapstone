using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class PrecinctAssigned
    {
        [Key]
        public int Id { get; set; }
        public string Precinct { get; set; }
        [ForeignKey("CampaignManager")]
        public int CampaignManagerId { get; set; }
        public CampaignManager campaignManager { get; set; }
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Staff staff { get; set; }
    }
}
