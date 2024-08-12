using CleanArchitectureForBlazor.Domain.Entities;

namespace CleanArchitectureForBlazor.Application.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Movie GetMovieById(int id);
        Task<Movie> CreateMovieAsync(Movie newMovie);
    }
}
