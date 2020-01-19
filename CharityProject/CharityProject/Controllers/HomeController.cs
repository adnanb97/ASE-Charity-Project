using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharityProject.Models;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace CharityProject.Controllers
{
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class HomeController : Controller
    {

        private readonly CharityContext _context;

        public HomeController(CharityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string loggedUsr = null)
        {
            if (loggedUsr == null)
            {
                if (HttpContext.Session.GetString("username") == null)
                    return RedirectToAction("", "");

                if (HttpContext.Session.GetInt32("IsUser") == 0)
                {
                    return RedirectToAction("Details", "Organizations", new { id = HttpContext.Session.GetString("idOfLoggedAccount") });
                }
            }
            var activeActions = await _context.action.Where(a => a.endDateTime >= DateTime.Now && a.startDateTime <= DateTime.Now).ToListAsync();
            var pastActions = await _context.action.Where(a => a.endDateTime < DateTime.Now).ToListAsync();
            var futureActions = await _context.action.Where(a => a.startDateTime > DateTime.Now).ToListAsync();

            List<String> namesOfOrg = new List<String>();
            List<String> namesOfOrg2 = new List<String>();
            List<String> namesOfOrg3 = new List<String>();
            foreach (var oneAction in activeActions)
            {
                Guid idActionOrg = oneAction.organizationId;
                CharityData.Models.Organization foundOrg = _context.organization.Where(a => a.Id == idActionOrg).First();
                namesOfOrg.Add(foundOrg.name);
            }
            foreach (var oneAction in pastActions)
            {
                Guid idActionOrg = oneAction.organizationId;
                CharityData.Models.Organization foundOrg = _context.organization.Where(a => a.Id == idActionOrg).First();
                namesOfOrg2.Add(foundOrg.name);
            }
            foreach (var oneAction in futureActions)
            {
                Guid idActionOrg = oneAction.organizationId;
                CharityData.Models.Organization foundOrg = _context.organization.Where(a => a.Id == idActionOrg).First();
                namesOfOrg3.Add(foundOrg.name);
            }
            ViewBag.namesOfOrg = namesOfOrg;
            ViewBag.activeActions = activeActions;

            ViewBag.namesOfOrg2 = namesOfOrg2;
            ViewBag.pastActions = pastActions;

            ViewBag.namesOfOrg3 = namesOfOrg3;
            ViewBag.futureActions = futureActions;
            return View();
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (HttpContext.Session.GetInt32("IsUser") == 0)
            {
                return RedirectToAction("Details", "Organizations", new { id = HttpContext.Session.GetString("idOfLoggedAccount") });
            }
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            if (HttpContext.Session.GetString("username") == null)
                return RedirectToAction("", "");
            if (HttpContext.Session.GetInt32("IsUser") == 0)
            {
                return RedirectToAction("Details", "Organizations", new { id = HttpContext.Session.GetString("idOfLoggedAccount") });
            }
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
