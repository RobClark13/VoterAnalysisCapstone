using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterAnalysis2.Models
{
	public class Voter
	{
		[Key]
		public int Id { get; set; }
		public string SOSVoterId { get; set; }
		public int CountyNumber {get;set; }
		public string County_Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string? Suffix { get; set; }
		public string? DateOfBirth { get; set; }
		public string? RegistrationDate { get; set; }
		public string VoterStatus { get; set; }
		public string? PartyAffliation { get; set; }
		public string ResidentialAddress1 { get; set; }
		public string? ResidentialAddress2 { get; set; }
		public string ResidentialCity { get; set; }
		public string ResidentialState { get; set; }
		public string ResidentialZip { get; set; }
		public string? ResidentialZipPlus4 { get; set; }
		public string? ResidentialCountry { get; set; }
		public string? ResidentialPostalCode{ get; set; }
		public string? MailingAddress1 { get; set; }
		public string? MailingAddress2 { get; set; }
		public string? MailingCity { get; set; }
		public string? MailingState { get; set; }
		public string? MailingZip { get; set; }
		public string? MailingZipPlus4 { get; set; }
		public string? MailingCountry { get; set; }
		public string? MailingPostalCode { get; set; }
		public string? CareerCenter { get; set; }
		public string? City { get; set; }
		public string? CitySchoolDistrict { get; set; }
		public string? CountyCourtDistict { get; set; }
		public string CongressionalDistrict { get; set; }
		public string CourtOfAppeals { get; set; }
		public string? EducationServiceCenter { get; set; }
		public string? ExemptedVillageSchoolDistrict { get; set; }
		public string? LibraryDistrict { get; set; }
		public string? LocalSchoolDistrict { get; set; }
		public string? MunicipalCourtDistrict { get; set; }
		public string? PrecinctName { get; set; }
		public string? PrecinctCode{ get; set; }
		public string StateBoardOfEducation { get; set; }
		public string StateRepresentativeDistrict { get; set; }
		public string StateSenateDistrict { get; set; }
		public string? Township { get; set; }
		public string? Village { get; set; }
		public string? Ward { get; set; }
	
		public string? Primary2010 { get; set; }
		public string? General2010 { get; set; }
		public string? Primary2012 { get; set; }
		public string? General2012{ get; set; }
		public string? Primary2014 { get; set; }
		public string? General2014 { get; set; }
		public string? Primary2016 { get; set; }
		public string? General2016 { get; set; }
		public string? Primary2018 { get; set; }
		public string? General2018 { get; set; }
		public string? Primary2020 { get; set; }
		public string? General2020 { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		

	}
}
