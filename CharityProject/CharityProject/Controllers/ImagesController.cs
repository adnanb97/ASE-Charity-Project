using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityData.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharityProject.Controllers
{
    public class ImagesController : Controller
    {
        private CharityContext _context;
        public ImagesController(CharityContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpPost]
        public async Task<IActionResult> Edit(Guid UserAccount, Guid id, string imgUrl)
        {
            var image = new Image()
            {
                Id = Guid.NewGuid(),
                Path = imgUrl
            };
            _context.image.Add(image);
            _context.SaveChanges();
            var account = _context.account.Find(UserAccount);
            if (account != null)
            {
                account.imageId = image.Id;
            }
            await _context.SaveChangesAsync();

            //var ourImage = await  _context.image.FindAsync(image.Id);
            //if (ourImage != null)
            //{
            //    ourImage.Path = image.Path;
            //}
            //else
            //{
            //    _context.image.Add(image);
            //}

            //_context.SaveChangesAsync();

            var controllerName = account.isUser ? "Users" : "Organizations";
            return RedirectToAction("Edit", controllerName, new {id = id});
        }
    }
}
