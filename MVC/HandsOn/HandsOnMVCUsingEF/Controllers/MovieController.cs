using HandsOnMVCUsingEF.Models;
using HandsOnMVCUsingEF.Reposiotories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnMVCUsingEF.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository = new MovieRepository();
        // GET: Movie
       // [Route("GetMovies")]
        public ActionResult GetAll()
        {
            List<Movie> movies = movieRepository.GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            Movie movie = movieRepository.GetMovie(id);
            return View(movie);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if(ModelState.IsValid)
            {
                movieRepository.AddMovie(movie);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            movieRepository.DeleteMovie(id);
            return RedirectToAction("GetAll");
        }
        public ActionResult Edit(int id)
        {
            Movie movie = movieRepository.GetMovie(id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            movieRepository.EditMovie(movie);
            return RedirectToAction("GetAll");

        }
    }
}