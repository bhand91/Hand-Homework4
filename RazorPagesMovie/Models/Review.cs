using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 84e0513565c7838d5ef6cf52957d20a099988f4a

namespace RazorPagesMovie.Models
{
    public class Review
    {
<<<<<<< HEAD
        [Key]
        public int ReviewId {get; set;}
        [ForeignKey("Movie")]
        public int ID { get; set; }

        [Range(1,5)]
        public int Score {get; set;}

        public Movie Movie {get; set;}
=======
    public int ReviewID { get; set; }
    public int ID{get; set;}

    [StringLength(1)]
    [Required]
    [Range(1,5)]
    public int score { get; set; }

    public Movie Movie {get; set;}
>>>>>>> 84e0513565c7838d5ef6cf52957d20a099988f4a
    }
}