using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryBackend.Controllers
{
    public class GenerosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("inicio")]
        public string getAll()
        {
            string mensaje = "testing";

            
            return mensaje;
        }
    }
}
