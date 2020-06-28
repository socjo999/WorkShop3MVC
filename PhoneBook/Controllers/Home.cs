using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoneBook.Controllers
{
    public class Home : Controller
    {
        SourceManager sourceManager = new SourceManager();
        public IActionResult Index()
        {            
            return View(sourceManager.Get());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            PersonModel personModel = new PersonModel();
            ViewBag.FirstName = personModel.GetList.Where(Id => personModel.Id == id);
            return View("Update");
        }

        [HttpPost]
        public IActionResult Update(int Id, string Firstame)
        {
            return View("Update"); 
        }
    }
}
