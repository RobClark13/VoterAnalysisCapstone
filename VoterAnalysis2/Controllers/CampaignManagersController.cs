using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using VoterAnalysis2.Data;
using VoterAnalysis2.Hubs;
using VoterAnalysis2.Models;

namespace VoterAnalysis2.Controllers
{
    public class CampaignManagersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GoogleMapsService _googleMapsService;

        public CampaignManagersController(ApplicationDbContext context, GoogleMapsService googleMapsService)
        {
            _context = context;
            _googleMapsService = googleMapsService;
        }

        // GET: CampaignManagers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CampaignManagers.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CampaignManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignManager = await _context.CampaignManagers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaignManager == null)
            {
                return NotFound();
            }

            return View(campaignManager);
        }

        // GET: CampaignManagers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: CampaignManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,IdentityUserId")] CampaignManager campaignManager)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                campaignManager.IdentityUserId = userId;
                _context.Add(campaignManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", campaignManager.IdentityUserId);
            return View(campaignManager);
        }

        // GET: CampaignManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignManager = await _context.CampaignManagers.FindAsync(id);
            if (campaignManager == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", campaignManager.IdentityUserId);
            return View(campaignManager);
        }

        // POST: CampaignManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,IdentityUserId")] CampaignManager campaignManager)
        {
            if (id != campaignManager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaignManager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignManagerExists(campaignManager.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", campaignManager.IdentityUserId);
            return View(campaignManager);
        }

        // GET: CampaignManagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignManager = await _context.CampaignManagers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaignManager == null)
            {
                return NotFound();
            }

            return View(campaignManager);
        }

        // POST: CampaignManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaignManager = await _context.CampaignManagers.FindAsync(id);
            _context.CampaignManagers.Remove(campaignManager);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignManagerExists(int id)
        {
            return _context.CampaignManagers.Any(e => e.Id == id);
        }
        public IActionResult CreateVoterScore()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVoterScore(VoterScore voterscore)
        {
            var voters = _context.Voters.Where(v => v.ResidentialState == "OH");
            foreach (Voter voter in voters)
            {
                if (ModelState.IsValid)
                {
                    voterscore.VoterId = voter.Id;
                    if (voter.General2020 == "X")
                    {
                        voterscore.Score++;
                    }
                    if (voter.General2018 == "X")
                    {
                        voterscore.Score++;
                    }
                    if (voter.General2016 == "X")
                    {
                        voterscore.Score++;
                    }
                    if (voter.General2014 == "X")
                    {
                        voterscore.Score++;
                    }
                    if (voter.General2012 == "X")
                    {
                        voterscore.Score++;
                    }
                    if (voter.General2010 == "X")
                    {
                        voterscore.Score++;
                    }
                    _context.Add(voterscore);
                    voterscore = new VoterScore();
                }
            }
            await _context.SaveChangesAsync();
            return View("Index");
        }
        
        public async void GeocodeVoters()
        {
            var voters = _context.Voters.Where(v => v.LastName == "ABBOTT");
            foreach (Voter voter in voters)
            {
                await _googleMapsService.GeocodeVoterAddress(voter);
                
            }
            await _context.SaveChangesAsync();
           
        }
        public ActionResult ViewListOfStaff()
        {
           var staffList= _context.Staffs;
            return View(staffList);
        }
        public IActionResult AssignStaffPrecinct()
        {
            ViewBag.Precinct = new SelectList(_context.Voters, "PrecinctName", "PrecinctName");
            
             return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssignStaffPrecinct(PrecinctAssigned precinctAssigned)
        {
                _context.Add(precinctAssigned);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }
        public IActionResult AssignStaffElectionDay()
        {
            ViewBag.Precinct = new SelectList(_context.Voters, "PrecinctName", "PrecinctName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssignStaffElectionDay(ElectionDayAssignment electionDayAssignment)
        {
            _context.Add(electionDayAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult ViewLikelyVoters()
        {
            var xlabels = new List<string>();
            var ylabels = new List<int>();
            var likelyvoters = from v in _context.VoterScores
                               join d in _context.Voters on v.VoterId equals d.Id
                               select new
                               {
                                   VoterScore = v.Score,
                                   VoterPrecinct = d.PrecinctName
                               };
            foreach (var data in likelyvoters)
            {
                if (data.VoterScore >= 5)
                {
                    if (xlabels.Contains(data.VoterPrecinct))
                    {
                        int indexOfPrecinct = xlabels.IndexOf(data.VoterPrecinct);
                        ylabels[indexOfPrecinct]++;
                    }
                    else
                    {
                        xlabels.Add(data.VoterPrecinct);
                        ylabels.Add(1);
                    }
                }
            }
            ViewBag.xlabels = new HtmlString(JsonConvert.SerializeObject(xlabels));
            ViewBag.ylabels = new HtmlString(JsonConvert.SerializeObject(ylabels));
            return View();
        }
        public ActionResult ViewVotersContactedByDay()
        {
            var xlabels = new List<string>();
            var ylabels = new List<int>();
            var voterID = _context.VoterIds;
            var voterStance = _context.VoterStances;
            foreach (var data in voterID)
            {
                if (data.MadeContact == true)
                {
                    if (xlabels.Contains(data.TypeOfContact))
                    {
                        int indexOfPrecinct = xlabels.IndexOf(data.TypeOfContact);
                        ylabels[indexOfPrecinct]++;
                    }
                    else
                    {
                        xlabels.Add(data.TypeOfContact);
                        ylabels.Add(1);
                    }
                }
            }
            foreach (var data in voterStance)
            {
                if (data.MadeContact == true)
                {
                    if (xlabels.Contains(data.TypeOfContact))
                    {
                        int indexOfPrecinct = xlabels.IndexOf(data.TypeOfContact);
                        ylabels[indexOfPrecinct]++;
                    }
                    else
                    {
                        xlabels.Add(data.TypeOfContact);
                        ylabels.Add(1);
                    }
                }
            }
            ViewBag.xlabels = new HtmlString(JsonConvert.SerializeObject(xlabels));
            ViewBag.ylabels = new HtmlString(JsonConvert.SerializeObject(ylabels));
            return View();
        }
        public ActionResult ViewVotersElectionDay()
        {
            var xlabel = "Has Voted";
            var ylabel = 0;
            var likelyvoters = _context.ElectionDayVotes;

            foreach (var data in likelyvoters)
            {
                if (data.HasVoted == true)
                {
                    ylabel++;
                }
            }
            ViewBag.xlabel = new HtmlString(JsonConvert.SerializeObject(xlabel));
            ViewBag.ylabel = new HtmlString(JsonConvert.SerializeObject(ylabel));
            return View();
        }
        public ActionResult ViewStaffContact()
        {
            var xlabels = new List<string>();
            var ylabels = new List<int>();
            var staffContact = from v in _context.Staffs
                               join d in _context.VoterIds on v.Id equals d.StaffId
                               select new
                               {
                                   StaffName = v.FirstName + " " + v.LastName,
                                   StaffContact = d.StaffId
                               };
            foreach (var data in staffContact)
            {

                if (xlabels.Contains(data.StaffName))
                {
                    int indexOfPrecinct = xlabels.IndexOf(data.StaffName);
                    ylabels[indexOfPrecinct]++;

                    {
                        xlabels.Add(data.StaffName);
                        ylabels.Add(1);
                    }

                }
                
            }
            ViewBag.xlabels = new HtmlString(JsonConvert.SerializeObject(xlabels));
            ViewBag.ylabels = new HtmlString(JsonConvert.SerializeObject(ylabels));
            return View();
        }
    }
}

