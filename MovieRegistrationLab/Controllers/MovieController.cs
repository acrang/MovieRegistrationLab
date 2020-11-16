using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationLab.Models;

namespace MovieRegistrationLab.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View(new Movie());
        }

        public IActionResult DisplayMovie(Movie Film)
        {
            if (ModelState.IsValid)
            {
                return View(Film);
            }
            else
            {
                return View("MovieForm", Film);
            }
        }
    }
}
