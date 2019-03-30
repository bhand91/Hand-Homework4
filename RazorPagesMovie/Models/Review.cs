using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class Review
    {
    public int ReviewID { get; set; }
    public int ID{get; set;}

    [StringLength(1)]
    [Required]
    [Range(1,5)]
    public int score { get; set; }

    public Movie Movie {get; set;}
    }
}