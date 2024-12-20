using CinemaCatalogue.DomainModels;

namespace CinemaCatalogue.Services;

public class MovieService : IMovieService
{
    private static int availableMovieId = 11;
    public IList<Movie> Movies { get; private set; } = new List<Movie>();

    public MovieService()
    {
        LoadMovies();
    }

    public IList<Movie> GetMovies()
    {
        return Movies;
    }

    public void AddMovie(Movie movie)
    {
        ArgumentNullException.ThrowIfNull(movie, nameof(movie));

        movie.Id = availableMovieId;
        Movies.Add(movie);
        availableMovieId++;
    }

    private void LoadMovies()
    {
        if (Movies != null && Movies.Count == 0)
        {
            Movies.Add(new Movie
            {
                Id = 1,
                Title = "movie1",
                Rating = 4,
                ReleaseYear = DateTime.Today.Year
            });
            Movies.Add(new Movie
            {
                Id = 2,
                Title = "movie2",
                Rating = 6,
                ReleaseYear = DateTime.Today.AddYears(-4).Year
            });
            Movies.Add(new Movie
            {
                Id = 3,
                Title = "movie3",
                Rating = 4,
                ReleaseYear = DateTime.Today.AddYears(-2).Year
            });
            Movies.Add(new Movie
            {
                Id = 4,
                Title = "movie4",
                Rating = 5,
                ReleaseYear = DateTime.Today.Year
            });
            Movies.Add(new Movie
            {
                Id = 5,
                Title = "movie5",
                Rating = 9,
                ReleaseYear = DateTime.Today.AddYears(-1).Year
            });
            Movies.Add(new Movie
            {
                Id = 6,
                Title = "movie6",
                Rating = 4,
                ReleaseYear = DateTime.Today.Year
            });
            Movies.Add(new Movie
            {
                Id = 7,
                Title = "movie7",
                Rating = 6,
                ReleaseYear = DateTime.Today.AddYears(-4).Year
            });
            Movies.Add(new Movie
            {
                Id = 8,
                Title = "movie8",
                Rating = 4,
                ReleaseYear = DateTime.Today.AddYears(-2).Year
            });
            Movies.Add(new Movie
            {
                Id = 9,
                Title = "movie9",
                Rating = 5,
                ReleaseYear = DateTime.Today.Year
            });
            Movies.Add(new Movie
            {
                Id = 10,
                Title = "movie10",
                Rating = 9,
                ReleaseYear = DateTime.Today.AddYears(-1).Year
            });
        }
    }
}
