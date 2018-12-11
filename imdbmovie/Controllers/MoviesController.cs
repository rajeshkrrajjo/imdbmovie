using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imdbmovie.Models;
namespace imdbmovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movies = new Movies() { MovieName = "ZERO" };
            return View(movies);
        }
    }
}