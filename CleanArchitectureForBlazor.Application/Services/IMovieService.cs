using CleanArchitectureForBlazor.Domain.Entities;

namespace CleanArchitectureForBlazor.Application.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();

        Task<Movie> GetMovieByIdAsync(int id);

        Task<Movie> CreateMovieAsync(Movie movie);

        Task<Movie> UpdateMovieAsync(Movie movie);

    }
}
