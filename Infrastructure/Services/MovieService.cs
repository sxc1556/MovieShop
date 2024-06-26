using ApplicaitonCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService : IMovieService
{
    public List<MovieCardModel> GetTop30GrossingMovies()
    {
        var movies = new List<MovieCardModel>()
        {
            new MovieCardModel { Id = 1, PosterUrl = "https://image.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg", Title = "" },
            new MovieCardModel { Id = 2, PosterUrl = "https://image.tmdb.org/t/p/w342//gEU2QniE6E77NI6lCU6MxlNBvIx.jpg", Title = "" },
            new MovieCardModel { Id = 3, PosterUrl = "https://image.tmdb.org/t/p/original//hkBaDkMWbLaf8B1lsWsKX7Ew3Xq.jpg", Title = "" },
            new MovieCardModel { Id = 4, PosterUrl = "https://image.tmdb.org/t/p/original//en971MEXui9diirXlogOrPKmsEn.jpg", Title = "" },
            new MovieCardModel { Id = 5, PosterUrl = "https://image.tmdb.org/t/p/w342//RYMX2wcKCBAr24UyPD7xwmjaTn.jpg", Title = "" },
            new MovieCardModel { Id = 6, PosterUrl = "https://image.tmdb.org/t/p/w342//8kNruSfhk5IoE4eZOc4UpvDn6tq.jpg", Title = "" },
            new MovieCardModel { Id = 7, PosterUrl = "https://image.tmdb.org/t/p/w342//h5J4W4veyxMXDMjeNxZI46TsHOb.jpg", Title = "" },

        };
        return movies;
    }
}