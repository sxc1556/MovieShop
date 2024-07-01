using ApplicaitonCore.Contracts.Repositories;
using ApplicaitonCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MovieRepository: EfRepository<Movie>, IMovieRepository
{
    public IEnumerable<Movie> GetTop30RevenueMovies()
    {
        var movies = _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30);
        return movies;
    }

    public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
    }
}