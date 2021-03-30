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
        public string StaffName { get; set; }
    }
}
