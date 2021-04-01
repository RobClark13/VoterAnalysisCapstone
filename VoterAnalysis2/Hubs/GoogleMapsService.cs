using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VoterAnalysis2.Models;

namespace VoterAnalysis2.Hubs
{
    public class GoogleMapsService
    {
        public string VoterGeocodingURL(Voter voter)
        {
            return $"https://maps.googleapis.com/maps/api/geocode/json?address={voter.ResidentialAddress1}+{voter.ResidentialSecondaryAddr}+{voter.ResidentialCity}+{voter.ResidentialState}+{voter.ResidentialZip}+&key=" + APIKeys.GoogleMapsAPI;
        }
        public async Task<Voter> GeocodeVoterAddress(Voter voter)
        {
            string apiUrl = VoterGeocodingURL(voter);
            using (HttpClient client =new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JObject jsonResults = JsonConvert.DeserializeObject<JObject>(data);
                    JToken results = jsonResults["results"][0];
                    JToken location = results["geometry"]["location"];

                    voter.Latitude = (string)location["lat"];
                    voter.Longitude = (string)location["lng"];
                }
            }
            return voter;
        }


    }
}
