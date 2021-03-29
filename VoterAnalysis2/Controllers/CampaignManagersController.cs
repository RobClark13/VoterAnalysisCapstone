using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoterAnalysis2.Data;
using VoterAnalysis2.Models;

namespace VoterAnalysis2.Controllers
{
    public class CampaignManagersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampaignManagersController(ApplicationDbContext context)
        {
            _context = context;
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

        public ActionResult AssignVoterScore(string searchString)
        {
            var voters = _context.Voters.Where(c => c.ResidentialState == "OH");

            return View(voters);
        }
        public IActionResult CreateVoterScore()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVoterScore(VoterScore voterscore)
        {
            var voters = _context.Voters.Where(v => v.ResidentialState== "OH");
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



        public IActionResult ViewListOfStaff()
        {
            var staff = _context.Staffs;
            return View(staff);
        }

        public IActionResult AssignStaffPrecinct(int id)
        {
            var staff = _context.Staffs.Find(id);
            return View(staff);
        }
        [HttpPost]
        public IActionResult AssignStaffPrecinct(PrecinctAssigned precinctAssigned, Staff staff)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cammgr = _context.CampaignManagers.Where(c => c.IdentityUserId ==
            userId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                precinctAssigned.CampaignManagerId = cammgr.Id;
                precinctAssigned.StaffId = staff.Id;
                precinctAssigned.Precinct = "Love";
                _context.Add(precinctAssigned);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public ActionResult SeeLikelyVotersChart()
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
            
        }


    }
}
