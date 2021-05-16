using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaGorzanowskaASPCSharp.Controllers
{
    public class HomeController1 : Controller
    {
        public String Index(String name)
        {
            return $"Hello {name}, Tu metoda Index Get Controllera";
        }
    }
}
