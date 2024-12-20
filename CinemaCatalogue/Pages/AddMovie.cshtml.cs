using CinemaCatalogue.DomainModels;
using CinemaCatalogue.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaCatalogue.Pages;

public class AddMovieModel : PageModel
{
    private IMovieService _movieService;
    public Movie Movie { get; set; }
    
    public AddMovieModel(IMovieService movieService)
    {
        _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
    }
    
    public void OnPost(Movie movie)
    {
        _movieService.AddMovie(movie);
        ModelState.Clear();
    }
}
