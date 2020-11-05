using System.Net;
using System.Text.Json;

namespace Proxy
{
    public class GlobalMovieSearcher : IMovieSearcher
    {
        
        public Movie SearchByTitle(string title)
        {
            Movie result;

                WebClient web = new WebClient();
                var request = $@"http://www.omdbapi.com/?apikey=f4e0873a&t={title}";
                var answer = web.DownloadString(request);
                result = JsonSerializer.Deserialize<Movie>(answer);

            return result;
        }
    }
}
