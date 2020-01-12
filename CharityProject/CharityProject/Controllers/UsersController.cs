using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CharityData.Models;
using CharityProject;
using Microsoft.AspNetCore.Http;

namespace CharityProject.Controllers
{
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class UsersController : Controller
    {
        private readonly CharityContext _context;

        public UsersController(CharityContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            return View(await _context.user.ToListAsync());
        }

        public IActionResult MyProfile()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            return RedirectToAction("Details", "Users", new { id = HttpContext.Session.GetString("idOfLoggedAccount") }); ;
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            var account = await _context.account.FindAsync(user.UserAccount);
            var image = await _context.image.FindAsync(account.imageId);
            ViewData["ImageURL"] = image.Path;

            string userId = HttpContext.Session.GetString("idOfLoggedAccount");
            var donated = await _context.itemInAction.ToListAsync();
           
            List<Item> donatedItems = new List<Item>();
            List<CharityAction> actDoneted = new List<CharityAction>();
            foreach(var item in donated)
            {
                var it = await _context.item.Where(i => i.userDonatedId == Guid.Parse(userId) && i.Id == item.itemId).FirstOrDefaultAsync();
                var actionDonetedTo = await _context.action.Where(a => a.Id == item.actionId).FirstOrDefaultAsync();
                if (it != null)
                {
                    donatedItems.Add(it);
                    if (actionDonetedTo != null)
                        actDoneted.Add(actionDonetedTo);
                }       
            }
            ViewBag.items = donatedItems;
            ViewBag.actDoneted = actDoneted;

            var payments = await _context.payment.Where(p => p.userSenderId == Guid.Parse(userId)).ToListAsync();
            List<Organization> organizations = new List<Organization>();
            foreach (var payment in payments)
            {
                var org = await _context.organization.Where(o => o.Id == payment.organizationReceiverId).FirstOrDefaultAsync();
                if (org != null)
                    organizations.Add(org);
            }

            ViewBag.payments = payments;
            ViewBag.organizations = organizations;

            var participatedActions = await _context.userParticipatingInAction.Where(p => p.userId == Guid.Parse(userId)).ToListAsync();
            List<CharityAction> myActions = new List<CharityAction>();
            List<Organization> organizedBy = new List<Organization>();
            foreach (var part in participatedActions)
            {
                var action = await _context.action.Where(a => a.Id == part.actionId).FirstOrDefaultAsync();
                if (action != null)
                {
                    var org = await _context.organization.Where(o => o.Id == action.organizationId).FirstOrDefaultAsync();
                    myActions.Add(action);
                    if (org != null)
                        organizedBy.Add(org);
                }
            }

            ViewBag.organizedBy = organizedBy;
            ViewBag.myActions = myActions;
            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            var vm = new User();
            vm.genders = new List<SelectListItem>{
                new SelectListItem("F", "F"),
                new SelectListItem("M", "M")
            };
            return View(vm);
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,firstName,lastName,gender,dateOfBirth")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = Guid.NewGuid();
                HttpContext.Session.SetString("registrationId", (user.Id).ToString());
                HttpContext.Session.SetString("registrationFirstName", user.firstName);
                HttpContext.Session.SetString("registrationLastName", user.lastName);
                HttpContext.Session.SetString("registrationGender", user.gender.ToString());
                HttpContext.Session.SetString("registrationBirthday", (user.dateOfBirth).ToString());
 
                await _context.SaveChangesAsync();
                return RedirectToAction("CreateUserAccount", "Account");//   ("Account/Create");
            }
            return View(user);
        }

        /*public ActionResult nextStep()
        {
            User model = (User)TempData["newUser"];
            return View(model);
        }*/

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,firstName,lastName,gender,dateOfBirth")] User user)
        {
            Guid idOfLoggedAccount = Guid.Parse(HttpContext.Session.GetString("idOfLoggedUserAccount"));
               
            //user.Id = id;
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.UserAccount = idOfLoggedAccount;

                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await _context.user.FindAsync(id);
            _context.user.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(Guid id)
        {
            return _context.user.Any(e => e.Id == id);
        }
    }
}
