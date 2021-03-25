using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class VoterContact
    {
        [Key]
        public int Id { get; set; }
        public string TypeOfContact { get; set; }
        public bool MadeContact { get; set; }
        public int ContactScore { get; set; }
    }
}
