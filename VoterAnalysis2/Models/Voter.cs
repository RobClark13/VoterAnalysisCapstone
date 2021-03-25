using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
    public class Voter
    {
		public int Id { get; set; }
		public int VoterScore { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string Suffic { get; set; }
		public string DateOfBirth { get; set; }
		public string VoterStatus { get; set; }
		public string PartyAffliation { get; set; }
		public string ResidentialAddress1 { get; set; }
		public string ResidentialSecondaryAddr { get; set; }
		public string ResidentialCity { get; set; }
		public string ResidentialState { get; set; }
		public string ResidentialZip { get; set; }
		public string PrecinctName { get; set; }
		public string PrecinctCode { get; set; }
		public string Ward { get; set; }
		public string Primary2010 { get; set; }
		public string General2010 { get; set; }
		public string Primary2012 { get; set; }
		public string General2012 { get; set; }
		public string Primary2014 { get; set; }
		public string General2014 { get; set; }
		public string Primary2016 { get; set; }
		public string General2016 { get; set; }
		public string Primary2018 { get; set; }
		public string General2018 { get; set; }
		public string Primary2020 { get; set; }
		public string General2020 { get; set; }
	}
}
