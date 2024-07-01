using ApplicaitonCore.Entities;

namespace ApplicaitonCore.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{
    IEnumerable<Movie> GetTop30RevenueMovies();
}