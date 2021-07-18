﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }



    }
}