using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CharityData.Models;
using CharityProject;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CharityProject.Controllers
{
    [Route("Account")]
    public class AccountsController : Controller
    {
        private readonly CharityContext _context;

        public AccountsController(CharityContext context)
        {
            _context = context;
        }
        private bool AccountExists(Guid id)
        {
            return _context.account.Any(e => e.Id == id);
        }

        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(Account account)
        {
            
            if (ModelState.IsValid)
            {
                var isValid = _context.account.Any(a => (account.username == a.username && account.password == a.password));
                if (!isValid)
                {
                    ModelState.AddModelError("", "username or password is invalid");
                    return View("~/Views/Accounts/Index.cshtml");
                    //return RedirectToAction("", "");//, new { area = "Admin" });
                }
                HttpContext.Session.SetString("username", account.username);
                var accountFind = _context.account.Where(a => a.username == account.username).Single();
                var isUser = _context.user.Any(u => u.UserAccount == accountFind.Id);
                if (isUser)
                {
                    HttpContext.Session.SetInt32("IsUser", 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("IsUser", 0);
                }
                //HttpContext.Session.SetString("username", account.username);
                // return View("~/Views/Home/Index.cshtml");
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                ModelState.AddModelError("", "username or password is blank");
                return View("~/Views/Accounts/Index.cshtml");
            }
        }

        [Route("Logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("IsUser");
            HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }

        [Route("CreateUserAccount")]
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View("Create");
        }

        [Route("CreateUserAccount")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserAccount([Bind("Id, username, password")] Account account)
        {
            if (ModelState.IsValid)
            {
                account.Id = Guid.NewGuid();
                account.isUser = true;
                _context.Add(account);

                string userId = HttpContext.Session.GetString("registrationId");
                string userFirstName = HttpContext.Session.GetString("registrationFirstName");
                string userLastName = HttpContext.Session.GetString("registrationLastName");
                string userGender = HttpContext.Session.GetString("registrationGender");
                string userDateOfBirth = HttpContext.Session.GetString("registrationBirthday");

                User user = new User();
                user.Id = Guid.Parse(userId);
                user.UserAccount = account.Id;
                user.firstName = userFirstName;
                user.lastName = userLastName;
                user.gender = Char.Parse(userGender);
                user.dateOfBirth = DateTime.Parse(userDateOfBirth);
                _context.Add<User>(user);

                HttpContext.Session.Remove("registrationId");
                HttpContext.Session.Remove("registrationFirstName");
                HttpContext.Session.Remove("registrationLastName");
                HttpContext.Session.Remove("registrationGender");
                HttpContext.Session.Remove("registrationBirthday");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        [Route("CreateOrganizationAccount")]
        [HttpGet]
        public IActionResult CreateOrganization()
        {
            return View("Create");
        }

        [Route("CreateOrganizationAccount")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrganizationAccount([Bind("Id, username, password")] Account account)
        {
            if (ModelState.IsValid)
            {
                account.Id = Guid.NewGuid();
                account.isUser = false;
                _context.Add(account);

                string organizationId = HttpContext.Session.GetString("registrationId");
                string organizationName = HttpContext.Session.GetString("registrationtName");
                string organizationDateOfFounding = HttpContext.Session.GetString("registrationDateOfFounding");
                string organizationDescription = HttpContext.Session.GetString("registrationDascription");

                Organization organization = new Organization();
                organization.Id = Guid.Parse(organizationId);
                organization.name = organizationName;
                organization.UserAccount = account.Id;
                organization.dateOfFounding = DateTime.Parse(organizationDateOfFounding);
                organization.description = organizationDescription;
                
                _context.Add(organization);

                HttpContext.Session.Remove("registrationId");
                HttpContext.Session.Remove("registrationName");
                HttpContext.Session.Remove("registrationDateOfFounding");
                HttpContext.Session.Remove("registrationDescription");
                await _context.SaveChangesAsync();
               // return RedirectToAction(nameof(Index));
                return RedirectToAction("", "Account");
            }
            return View(account);
        }
    }
}
