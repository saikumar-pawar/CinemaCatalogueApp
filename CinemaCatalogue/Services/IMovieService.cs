using CinemaCatalogue.DomainModels;

namespace CinemaCatalogue.Services;

public interface IMovieService
{
    IList<Movie> GetMovies();
    void AddMovie(Movie movie);
}
