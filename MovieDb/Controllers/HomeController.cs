﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MovieDb.Models;
using MovieDb.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MovieDb.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> um;

        public async Task<ActionResult> Index()
        {
            IndexMovieViewModel ViewModel = new IndexMovieViewModel();
            um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            ApplicationUser appuser = await um.FindByIdAsync(User.Identity.GetUserId());

            if (HttpContext.User.Identity.IsAuthenticated && appuser != null)
            {
                ViewBag.UsersFavoriteGenre = appuser.FavoriteGenre;
                var ByFavoriteGenre = db.Movies.Include(g => g.Genre).Where(m => m.GenreName == appuser.FavoriteGenre).ToList();
                ByFavoriteGenre = (from m in ByFavoriteGenre orderby Guid.NewGuid() select m).Take(6).ToList();

                if (ByFavoriteGenre.Count() != 0)
                    ViewModel.ByFavoriteGenre = ByFavoriteGenre;
                else
                    ViewModel.ByFavoriteGenre = new List<Movie>();
                    

            }

            MoviesController moviesController = new MoviesController();
            ViewModel.TopRated = moviesController.Top(7);



            return View(ViewModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddMovie()
        {
            ViewBag.Message = "Add a movie!";

            return View();
        }





        

    }

}