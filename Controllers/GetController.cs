using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaGorzanowskaASPCSharp.Controllers
{
    public class GetController : Controller
    {
        //wywolanie http://localhost:43980/Get/Index?name=Anna
        public IActionResult Index(String name)
        {
            ViewData["name"] = name;
            return View();
        }
    }
}
