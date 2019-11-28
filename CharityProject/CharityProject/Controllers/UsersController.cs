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
            return View(await _context.user.ToListAsync());
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

            await FindImage(user);

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

            await FindImage(user);

            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserAccount,firstName,lastName,gender,dateOfBirth,creditCardId")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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

        private async Task FindImage(User user)
        {
            var account = await _context.account.FindAsync(user.UserAccount);
            if (account.imageId != null && account.imageId != Guid.Empty)
            {
                var image = await _context.image.FindAsync(account.imageId);
                ViewData["ImageURL"] = image.Path;
            }
            else
            {
                ViewData["ImageURL"] =
                    "https://bigriverequipment.com/wp-content/uploads/2017/10/no-photo-available.png";
            }
        }
    }
}
