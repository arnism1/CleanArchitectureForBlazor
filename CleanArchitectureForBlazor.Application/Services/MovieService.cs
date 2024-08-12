﻿using CleanArchitectureForBlazor.Domain.Entities;

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

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetMovieByIdAsync(id);
        }

        public async Task<Movie> CreateMovieAsync(Movie newMovie)
        {
            return await _movieRepository.CreateMovieAsync(newMovie);
        }


    }
}
