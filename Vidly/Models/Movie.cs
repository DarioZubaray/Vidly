﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Give us a name for the movie!")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        [Required(ErrorMessage = "You must select a genre.")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        
        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }
    }
}