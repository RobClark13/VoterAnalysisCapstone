using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis.Models
{
    public class VoterContact
    {
        [Key]
        int Id { get; set; }
        string TypeOfContact { get; set; }
        bool MadeContact { get; set; }
        int ContactScore { get; set; }
    }
}
