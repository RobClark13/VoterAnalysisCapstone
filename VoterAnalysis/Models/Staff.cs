using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }
    }
}
