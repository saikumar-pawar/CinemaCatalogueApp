using System.ComponentModel.DataAnnotations;

namespace CinemaCatalogue.DomainModels;

public class Movie
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(150, MinimumLength = 1)]
    public required string Title { get; set; }

    [Required]
    [Range(1, 9999)]
    public int ReleaseYear { get; set; }

    [Required]
    [Range(0, 10)]
    public int Rating { get; set; }
}
