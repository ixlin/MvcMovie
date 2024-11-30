using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Forms;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [StringLength(60,MinimumLength = 1),Required]
    public string? Title { get; set; }
    [DisplayName("Release Date"),DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; }

    [StringLength(30),Required]
    public string? Genre { get; set; }

    [Range(1,100),DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5),Required]
    public string? Rating { get; set; }
}
