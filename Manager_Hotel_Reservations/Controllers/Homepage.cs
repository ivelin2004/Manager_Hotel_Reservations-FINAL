using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Manager_Hotel_Reservations.Controllers
{
    public class Homepage : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /Homepage/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}