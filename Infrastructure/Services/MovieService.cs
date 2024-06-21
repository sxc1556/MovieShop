using ApplicaitonCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService : IMovieService
{
    public List<MovieCardModel> GetTop30GrossingMovies()
    {
        var movies = new List<MovieCardModel>()
        {
            new MovieCardModel { Id = 1, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 2, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 3, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 4, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 5, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 6, PosterUrl = "", Title = "" },
            new MovieCardModel { Id = 7, PosterUrl = "", Title = "" },

        };
        return movies;
    }
}