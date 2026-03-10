using System.ComponentModel.DataAnnotations;

namespace RazorPagesBooks.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }

    [DataType(DataType.Date)]
    public DateTime FirstPublished { get; set; }
    public long IBSN { get; set; }
}