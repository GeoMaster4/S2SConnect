using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace S2SConnect.Models
{
    public class ProfileController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View("~/Views/Profile/Index");
        }

        public IActionResult FindOrgs()
        {
            return View("~/Views/Profile/Era");
        }
    }
}
