using CinemaCatalogue.DomainModels;
using CinemaCatalogue.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaCatalogue.Pages;

public class OverViewModel : PageModel
{
    private IMovieService _movieService;
    public IList<Movie> Movies { get; private set; }
    public OverViewModel(IMovieService movieService)
    {
        _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
    }

    public void OnGet()
    {
        Movies = _movieService.GetMovies();
    }
}
