using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using MailKit.Security;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using Newtonsoft.Json;
using VoterAnalysis2.Data;
using VoterAnalysis2.Models;

namespace VoterAnalysis2.Controllers
{
    public class StaffsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaffsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Staffs
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var staff = _context.Staffs.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (staff == null)
            {
                RedirectToAction("Create");
            }
            return View();
        }

        // GET: Staffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // GET: Staffs/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,IdentityUserID")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserID"] = new SelectList(_context.Users, "Id", "Id", staff.IdentityUserId);
            return View(staff);
        }

        // GET: Staffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserID"] = new SelectList(_context.Users, "Id", "Id", staff.IdentityUserId);
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,IdentityUserID")] Staff staff)
        {
            if (id != staff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffExists(staff.Id))
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
            ViewData["IdentityUserID"] = new SelectList(_context.Users, "Id", "Id", staff.IdentityUserId);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffExists(int id)
        {
            return _context.Staffs.Any(e => e.Id == id);
        }
        public ActionResult SeePrecinctsAssigned()
        {
            var precincts = _context.PrecinctsAssigned;

            return View(precincts);
        }
        public ActionResult SeeVotersFromPrecinct(int id)
        {
            var precinct = _context.PrecinctsAssigned.Find(id);
            var voters = _context.Voters.Where(v => v.PrecinctName == precinct.Precinct);
            return View(voters);
        }
        public ActionResult SeeElectionDayAssigned()
        {
            var precincts = _context.ElectionDayAssignments;
            return View(precincts);
        }
        public ActionResult SeeVotersElectionDay(int id)
        {
            var precinct = _context.PrecinctsAssigned.Find(id);
            var precinctvoters = _context.Voters.Where(v => v.PrecinctName == precinct.Precinct);
            var voters = _context.ElectionDayVotes.Where(v => v.HasVoted == false);

            return View(voters);
        }
       
       public void SendEmail()
       {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey", APIKeys.OutlookAcct));
            message.To.Add(new MailboxAddress("Alice", "clarkrob13@gmail.com"));
            message.Subject = "Vote Today!";
            message.Body = new TextPart("plain")
            {
                Text = @"Hey Alice,

                Remember to vote today!

                -- Rob
                "
            };
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate(APIKeys.OutlookAcct, APIKeys.OutlookPW);
                    smtp.Send(message);
                    smtp.Disconnect(true);
            };

       }
        public ActionResult SeeVotersMap()
        {
            var votersContactedID = _context.VoterIds.Where(v => v.MadeContact == false).Select(x => x.VoterId);
            var voters = _context.Voters.Where(v => votersContactedID.Contains(v.Id));
            ViewBag.voters = new HtmlString(JsonConvert.SerializeObject(voters));
            return View(voters);
        }
        public ActionResult VoterIdSurvey(int id)
        {
            List<SelectListItem> TypeOfContact = new List<SelectListItem>()
            {
                new SelectListItem { Text = "In-Person", Value = "In-Person" },
                new SelectListItem { Text = "Phone", Value = "Phone" },
            };
            List<SelectListItem> VoteIn2020 = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Sophia Hunt", Value = "Sophia Brady" },
                new SelectListItem { Text = "Clint Frazier", Value = "Clint Frazier" },
                new SelectListItem { Text = "Other", Value = "Other" },
                new SelectListItem { Text = "Didn't Vote", Value = "Didn't Vote" },

            };
            List<SelectListItem> PartyStance = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Apple Party", Value = "Apple Party" },
                new SelectListItem { Text = "Pear Party", Value = "Pear Party" },
                new SelectListItem { Text = "Third Party", Value = "Third Party" },
                new SelectListItem { Text = "Independent", Value = "Independent" },

            };
            List<SelectListItem> DirectionOfCountry = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Good", Value = "Good" },
                new SelectListItem { Text = "Bad", Value = "Bad" },
                new SelectListItem { Text = "Same", Value = "Same" },
            };
            List<SelectListItem> DirectionOfSelf = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Good", Value = "Good" },
                new SelectListItem { Text = "Bad", Value = "Bad" },
                new SelectListItem { Text = "Same", Value = "Same" },
            };
            var survey=_context.VoterIds.Where(s=>s.VoterId==id).FirstOrDefault();
            ViewBag.Contact = TypeOfContact;
            ViewBag.VoteIn2020 = VoteIn2020;
            ViewBag.Party = PartyStance;
            ViewBag.Country = DirectionOfCountry;
            ViewBag.Self = DirectionOfSelf;
            return View(survey);
        }
        [HttpPost]
        public ActionResult VoterIdSurvey(VoterIdSurvey voterIdSurvey)
        {
           
            
            _context.VoterIds.Update(voterIdSurvey);
            if (voterIdSurvey.VoteIn2020 == "Sophia Brady") 
            {
                voterIdSurvey.ContactScore += 1;
            }
            if (voterIdSurvey.DirectionOfCountry == "Good")
            {
                voterIdSurvey.ContactScore += 1;
            }
            if (voterIdSurvey.DirectionOfSelf == "Good")
            {
                voterIdSurvey.ContactScore += 1;
            }
            if (voterIdSurvey.PartyStance == "Apple Party")
            {
                voterIdSurvey.ContactScore += 1;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       

     

    }
}
