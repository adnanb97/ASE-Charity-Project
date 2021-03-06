﻿using System;
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
    public class OrganizationsController : Controller
    {
        private readonly CharityContext _context;

        public OrganizationsController(CharityContext context)
        {
            _context = context;
        }

        // GET: Organizations
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            var currentLoggedUser = HttpContext.Session.GetString("idOfLoggedUserAccount");
            var currentLoggedUserObject = _context.user.FirstOrDefault(u => u.UserAccount.ToString() == currentLoggedUser);
            var creditCard = currentLoggedUserObject.creditCardId;
            ViewBag.creditCardId = creditCard.ToString();
            return View(await _context.organization.ToListAsync());
        }

        // GET: Organizations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.organization
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }

            var account = await _context.account.FindAsync(organization.UserAccount);
            var image = _context.image.FirstOrDefault(a => a.Id.ToString().Equals(account.imageId.ToString()));
            if (image != null) ViewData["ImageURL"] = image.Path;
            
            return View(organization);
        }

        // GET: Organizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organizations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,dateOfFounding,description")] Organization organization)
        {
            if (ModelState.IsValid)
            {
                organization.Id = Guid.NewGuid();
                HttpContext.Session.SetString("registrationId", (organization.Id).ToString());
                HttpContext.Session.SetString("registrationName", organization.name);
                HttpContext.Session.SetString("registrationDateOfFounding", organization.dateOfFounding.ToString());
                HttpContext.Session.SetString("registrationDescription", organization.description);
                organization.Id = Guid.NewGuid();
                //_context.Add(organization);
                await _context.SaveChangesAsync();
                return RedirectToAction("CreateOrganizationAccount", "Account");
            }
            return View(organization);
        }

        // GET: Organizations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.organization.FindAsync(id);
            var account = await _context.account.FindAsync(organization.UserAccount);
            var image = _context.image.FirstOrDefault(a => a.Id.ToString().Equals(account.imageId.ToString()));
            if (image != null) ViewData["ImageURL"] = image.Path;

            if (organization == null)
            {
                return NotFound();
            }
            return View(organization);
        }

        // POST: Organizations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,name,UserAccount,dateOfFounding,description,creditCardNumber")] Organization organization)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id != organization.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizationExists(organization.Id))
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
            return View(organization);
        }

        // GET: Organizations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.organization
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // POST: Organizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var organization = await _context.organization.FindAsync(id);
            _context.organization.Remove(organization);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizationExists(Guid id)
        {
            return _context.organization.Any(e => e.Id == id);
        }

        // GET: Users/Donate/5
        public async Task<IActionResult> Donate(Guid? id)
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.organization.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var currentLoggedUser = HttpContext.Session.GetString("idOfLoggedUserAccount");
            var currentLoggedUserObject = _context.user.Where(u => u.UserAccount.ToString() == currentLoggedUser).Single();
            var creditCard = currentLoggedUserObject.creditCardId;
            var creditCardObject = _context.card.Where(c => c.Id == creditCard).Single();
            HttpContext.Session.SetString("donatingTo", user.name);
            HttpContext.Session.SetString("AccountFunds", creditCardObject.amount.ToString());
            HttpContext.Session.SetString("TransferringFrom", currentLoggedUserObject.Id.ToString());
            HttpContext.Session.SetString("TransferringTo", id.ToString());

            return RedirectToAction("Create", "Payments");
        }
    }
}
