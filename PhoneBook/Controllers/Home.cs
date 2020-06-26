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
        public IActionResult Index()
        {
            SourceManager sourceManager = new SourceManager();            
            return View(sourceManager.Get());
        }
    }
}
