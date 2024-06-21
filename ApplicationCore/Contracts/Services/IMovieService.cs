using ApplicationCore.Models;

namespace ApplicaitonCore.Contracts.Services;

public interface IMovieService
{
    List<MovieCardModel> GetTop30GrossingMovies();
}