using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoterAnalysis.Data;
using VoterAnalysis.Models;

namespace VoterAnalysis.Controllers
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
            return View(await _context.CampaignManagers.ToListAsync());
        }

        // GET: CampaignManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignManager = await _context.CampaignManagers
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
            return View();
        }

        // POST: CampaignManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] CampaignManager campaignManager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaignManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(campaignManager);
        }

        // POST: CampaignManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] CampaignManager campaignManager)
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
        // Get: CampaignManagers/
        public  ActionResult AssignVoterScore(string searchString)
        {
            var voters = _context.Voters.Where(c => c.ResidentialState == "OH");
         
            return View(voters);
        }

        public void VoterScoreFormula(string precinct)
        {
            var votersPrecinct = _context.Voters.Where(v => v.PrecinctName == precinct);
            foreach(Voter voter in votersPrecinct)
            {
                if (voter.General2010 == "X")
                {
                    voter.VoterScore++;
                }
            }
        }

        public IActionResult ViewListOfStaff()
        {
            var staff = _context.Staffs;
            return View(staff);
        }
     
        public IActionResult AssignStaffPrecinct(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AssignStaffPrecinct(PrecinctAssigned precinctAssigned)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cammgr = _context.CampaignManagers.Where(contr0 => contr0.IdentityUserID ==
            userId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                precinctAssigned.CampaignManagerId = cammgr.Id;
                precinctAssigned.StaffId = cammgr.Id;
                precinctAssigned.Precinct = "Love";
                _context.Add(precinctAssigned);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
           
    }
}
