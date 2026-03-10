using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBooks.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }

    [Display(Name = "First Published")]
    [DataType(DataType.Date)]
    public DateTime FirstPublished { get; set; }
    public long IBSN { get; set; }
}