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
    public class ActionsController : Controller
    {
        private readonly CharityContext _context;

        public ActionsController(CharityContext context)
        {
            _context = context;
        }

        // GET: Actions
        public async Task<IActionResult> Index()
        {
            return View(await _context.action.Where(a => a.endDateTime >= DateTime.Now).ToListAsync());
        }

        // GET: Actions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var action = await _context.action
                .FirstOrDefaultAsync(m => m.Id == id);
            if (action == null)
            {
                return NotFound();
            }

            return View(action);
        }

        // GET: Actions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,description,actionType,startDateTime,endDateTime")] CharityData.Models.Action action)
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

            action.organizationId = org.Id;
            action.creationDateTime = DateTime.Now;

            if (ModelState.IsValid)
            {
               
                action.Id = Guid.NewGuid();
                _context.Add(action);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            return View(action);
        }

        // GET: Actions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var action = await _context.action.FindAsync(id);
            if (action == null)
            {
                return NotFound();
            }
            return View(action);
        }

        // POST: Actions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,name,description,actionType,organizationId,creationDateTime,startDateTime,endDateTime")] CharityData.Models.Action action)
        {
            if (id != action.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(action);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActionExists(action.Id))
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
            return View(action);
        }

        // GET: Actions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var action = await _context.action
                .FirstOrDefaultAsync(m => m.Id == id);
            if (action == null)
            {
                return NotFound();
            }

            return View(action);
        }

        // POST: Actions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var action = await _context.action.FindAsync(id);
            _context.action.Remove(action);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActionExists(Guid id)
        {
            return _context.action.Any(e => e.Id == id);
        }
    }
}
