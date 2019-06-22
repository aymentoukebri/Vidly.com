using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_Application.Models;

namespace Vidly_Application.View_Models
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        [Required]
        public int? numberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            numberInStock = movie.numberInStock;
            GenreId = movie.GenreId;

        }
        public NewMovieViewModel()
        {
            Id = 0;
        }
        
        public string Title
        {
            get
            {
                if (Id != null && Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }

    }
}