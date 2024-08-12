using CleanArchitectureForBlazor.Domain.Entities;

namespace CleanArchitectureForBlazor.Application.Repositories
{
    public class MovieService : IMovieRepository
    {
        private readonly IMovieRepository _movieRepository;

        // Constructor that injects the repository
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository ?? throw new ArgumentNullException(nameof(movieRepository));
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public Movie GetMovieById(int id)
        {
            return  _movieRepository.GetMovieById(id);
        }

        public Movie CreateMovie(Movie newMovie)
        {
            return  _movieRepository.CreateMovie(newMovie);
        }


    }
}
