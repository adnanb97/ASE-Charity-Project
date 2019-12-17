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
    public class CharityActionsController : Controller
    {
        private readonly CharityContext _context;

        public CharityActionsController(CharityContext context)
        {
            _context = context;
        }

        // GET: CharityActions
        public async Task<IActionResult> Index()
        {
            return View(await _context.action.Where(a => a.endDateTime >= DateTime.Now).ToListAsync());
        }

        // GET: CharityActions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var charityAction = await _context.action
                .FirstOrDefaultAsync(m => m.Id == id);
            if (charityAction == null)
            {
                return NotFound();
            }

            return View(charityAction);
        }

        // GET: CharityActions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CharityActions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,description,actionType,organizationId,creationDateTime,startDateTime,endDateTime")] CharityAction charityAction)
        {
            if (ModelState.IsValid)
            {
                string organizationUsername = HttpContext.Session.GetString("username");
                var account = await _context.account.FirstOrDefaultAsync(m => m.username == organizationUsername);
                if (account == null)
                {
                    return NotFound();
                }

                var org = await _context.organization.FirstOrDefaultAsync(m => m.UserAccount == account.Id);
                if (org == null)
                {
                    return NotFound();
                }
                charityAction.organizationId = org.Id;
                charityAction.creationDateTime = DateTime.Now;

                charityAction.Id = Guid.NewGuid();
                _context.Add(charityAction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(charityAction);
        }

        // GET: CharityActions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var charityAction = await _context.action.FindAsync(id);
            if (charityAction == null)
            {
                return NotFound();
            }
            return View(charityAction);
        }

        // POST: CharityActions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,name,description,actionType,organizationId,creationDateTime,startDateTime,endDateTime")] CharityAction charityAction)
        {
            if (id != charityAction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(charityAction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharityActionExists(charityAction.Id))
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
            return View(charityAction);
        }

        // GET: CharityActions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var charityAction = await _context.action
                .FirstOrDefaultAsync(m => m.Id == id);
            if (charityAction == null)
            {
                return NotFound();
            }

            return View(charityAction);
        }

        // POST: CharityActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var charityAction = await _context.action.FindAsync(id);
            _context.action.Remove(charityAction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharityActionExists(Guid id)
        {
            return _context.action.Any(e => e.Id == id);
        }
    }
}
