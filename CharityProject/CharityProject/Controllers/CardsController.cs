using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CharityData.Models;
using Microsoft.AspNetCore.Http;

namespace CharityProject
{
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class CardsController : Controller
    {
        private readonly CharityContext _context;

        public CardsController(CharityContext context)
        {
            _context = context;
        }

        // GET: Cards
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            return View(await _context.card.ToListAsync());
        }

        // GET: Cards/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.card
                .FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // GET: Cards/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            return View();
        }

        // POST: Cards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,dateOfExpiry,bankName,amount,creditCardNumber")] Card card, string loggedUsr = null)
        {
            if (loggedUsr == null)
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (ModelState.IsValid)
            {
                card.Id = Guid.NewGuid();
                string idOfLoggedAccount = loggedUsr;
                if (loggedUsr == null)
                { 
                    idOfLoggedAccount = HttpContext.Session.GetString("idOfLoggedAccount");
                }
                

                var loggedUser = _context.user.Where(u => u.Id.ToString() == idOfLoggedAccount).Single();
                loggedUser.creditCardId = card.Id;
                _context.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction("", "Home");
            }
            return View(card);
        }

        // GET: Cards/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.card.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            return View(card);
        }

        // POST: Cards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,dateOfExpiry,bankName,amount,creditCardNumber")] Card card)
        {
            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardExists(card.Id))
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
            return View(card);
        }

        // GET: Cards/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.card
                .FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // POST: Cards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var card = await _context.card.FindAsync(id);
            _context.card.Remove(card);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardExists(Guid id)
        {
            return _context.card.Any(e => e.Id == id);
        }
    }
}
