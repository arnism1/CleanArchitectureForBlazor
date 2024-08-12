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

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> CreateMovieAsync(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            await _context.SaveChangesAsync();
            return newMovie;
        }
    }
}
