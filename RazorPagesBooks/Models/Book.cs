using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBooks.Models;

public class Book
{
    public int Id { get; set; }
        
    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? Title { get; set; } = string.Empty;

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Author { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Display(Name = "First Published")]
    [DataType(DataType.Date)]
    [Required]
    public DateTime FirstPublished { get; set; }

    //ibsn is a 10 or 13 digit long string of numbers
    [RegularExpression(@"^(\d{10}|\d{13})$")]
    [Required]
    [Display(Name = "ISBN")] //made a type this is easier than rebuilding all
    public string IBSN { get; set; }
}