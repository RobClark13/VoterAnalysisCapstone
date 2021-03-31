﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class ElectionDayAssignment
    {
        [Key]
        public int Id { get; set; }
        public bool ElectionDay { get; set; }
        public string Precinct { get; set; }
       [ForeignKey("Staff")]
        public int? StaffId { get; set; }
        public Voter Staff { get; set; }
    }
}
