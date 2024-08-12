using CleanArchitectureForBlazor.Application.Services;
using CleanArchitectureForBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureForBlazor.Infrastructure.Repositories
{
    public class MovieRepository : IMovieService
    {
        private readonly ApplicationDbContext _context;

        // Constructor that injects the DbContext
        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task<Movie> UpdateMovieAsync(Movie updatedMovie)
        {
            _context.Movies.Update(updatedMovie);
            await _context.SaveChangesAsync();
            return updatedMovie;
        }

    }
}
