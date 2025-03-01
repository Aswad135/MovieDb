﻿using System;
using System.Collections.Generic;
using MovieDb.Models;
using Microsoft.AspNet.Identity;

namespace MovieDb.ViewModels
{
    public class MovieActorViewModel
    {
        protected ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> um;

        public Movie Movie { get; set; }
        public Genre Genre { set; get; }
        public Rating Rating { get; set; }
        public String CommentText { get; set; }

        public ICollection<Actor> Actors { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }

    public class SearchViewModel
    {
        protected ApplicationDbContext db = new ApplicationDbContext();

        public string GenreName { get; set; }
        public String ActorName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public double Rate { get; set; }
    }

    public class IndexMovieViewModel
    {
        protected ApplicationDbContext db = new ApplicationDbContext();

        public List<Movie> Trending { get; set; }
        public List<Movie> TopRated { get; set; }
        public List<Movie> ByFavoriteGenre { get; set; }
        
    }



}