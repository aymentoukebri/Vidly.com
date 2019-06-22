using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_Application.Models
{
   
        public class rental
        {
            public int id { get; set; }
            public DateTime dateRented { get; set; }
            public DateTime? dateReturned { get; set; }
            [Required]
            public Movie movie { get; set; }
            [Required]
            public Customer customer { get; set; }
    
        
    }
}