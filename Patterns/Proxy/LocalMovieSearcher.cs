using System.Collections.Generic;

namespace Proxy
{
    public class LocalMovieSearcher : IMovieSearcher
    {
        private IMovieSearcher globalSearch;
        private List<Movie> localMovies;
        public LocalMovieSearcher(IMovieSearcher global)
        {
            globalSearch = global;
            localMovies = new List<Movie>()
            {
                new Movie(){Title = "Unfinished project", Country = "Azerbaijan", Director = "Alex", Genre = "Horor", Actors = "Tom Hanks"},
                new Movie(){Title = "Finished project", Country = "Azerbaijan", Director = "Samir", Genre = "Fantasy", Actors = "Harison Ford"},
                new Movie(){Title = "The project: Last chance", Country = "Azerbaijan", Director = "Maga", Genre = "Dram", Actors = "Will Smith"},
            };
        }
        public Movie SearchByTitle(string title)
        {
            Movie result;
            if (localMovies.Any(x => x.Title == title))
            {
                result = localMovies.FirstOrDefault(x => x.Title == title);
            }
            else
            {
                result = globalSearch.SearchByTitle(title);
            }
            return result;
        }
    }
}
