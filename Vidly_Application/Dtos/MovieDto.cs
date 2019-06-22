using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_Application.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
       
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? Date_added { get; set; }
        
        [Range(1, 20)]
        [Required]
        public int numberInStock { get; set; }
     
        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre;
        
    }
}