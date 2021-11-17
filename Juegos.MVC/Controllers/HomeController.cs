using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Juegos.MVC.Models;

namespace Juegos.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult index()
        {
            return View();
        }
    }}