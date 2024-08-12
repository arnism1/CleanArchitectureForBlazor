using CleanArchitectureForBlazor.Application.Repositories;
using CleanArchitectureForBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureForBlazor.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.Find(id);
        }

        public  Movie CreateMovie(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
            return newMovie;
        }
    }
}
