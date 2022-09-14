using HandsOnMVCUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnMVCUsingEF.Reposiotories
{
    public class MovieRepository
    {
        public MovieContext db = new MovieContext();
        public void AddMovie(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public List<Movie> GetMovies()
        {
            return db.Movies.ToList();
        }
        public Movie GetMovie(int movieId)
        {
            return db.Movies.Find(movieId);
        }
        public void DeleteMovie(int movieId)
        {
            Movie movie= db.Movies.Find(movieId);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public void EditMovie(Movie movie)
        {
            db.Entry<Movie>(movie).State = System.Data.Entity.EntityState.Modified; //record update in table
            db.SaveChanges();
        }
    }
}