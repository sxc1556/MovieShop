using System.Collections.Immutable;
using ApplicaitonCore.Contracts.Repositories;
using ApplicaitonCore.Contracts.Services;
using ApplicaitonCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService : IMovieService
{
  private readonly IMovieRepository _movieRepository;

  public MovieService(IMovieRepository movieRepository)
  {
    _movieRepository = movieRepository;
  }

  public List<MovieCardModel> GetTop30GrossingMovies()
  {
    var movies = _movieRepository.GetTop30RevenueMovies();
    var movieCards = new List<MovieCardModel>();
    foreach (var movie in movies)
    {
      movieCards.Add(new MovieCardModel
      {
        Id = movie.Id, PosterUrl = movie.PosterUrl, Title = movie.Title
      });
    }
    return movieCards;
  }
}