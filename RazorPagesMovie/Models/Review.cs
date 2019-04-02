using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class Review
    {
        [Key]
        public int ReviewId {get; set;}
        
        [ForeignKey("Movie")]
        public int ID { get; set; }

        [Range(1,5)]
        public int Score {get; set;}


        public Movie Movie {get; set;}

    }
}