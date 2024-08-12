using CleanArchitectureForBlazor.Domain.Entities;

namespace CleanArchitectureForBlazor.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieService _movieRepository;
        // Constructor that injects the repository
        public MovieService(IMovieService movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetMovieByIdAsync(id);
        }

        public async Task<Movie> CreateMovieAsync(Movie newMovie)
        {
            return await _movieRepository.CreateMovieAsync(newMovie);
        }

        public async Task<Movie> UpdateMovieAsync(Movie updatedMovie)
        {
            await _movieRepository.UpdateMovieAsync(updatedMovie);
            return updatedMovie;
        }


    }
}
