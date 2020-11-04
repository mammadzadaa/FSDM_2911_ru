
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Flyweight
{
public class Movie
{
    public string Title { get; set; }
    public string Year { get; set; }
    public string Rated { get; set; }
    public string Released { get; set; }
    public string Runtime { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Writer { get; set; }
    public string Actors { get; set; }
    public string Plot { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }
    public string Awards { get; set; }
    public string Poster { get; set; }
    public Rating[] Ratings { get; set; }
    public string Metascore { get; set; }
    public string imdbRating { get; set; }
    public string imdbVotes { get; set; }
    public string imdbID { get; set; }
    public string Type { get; set; }
    public string DVD { get; set; }
    public string BoxOffice { get; set; }
    public string Production { get; set; }
    public string Website { get; set; }
    public string Response { get; set; }
}
public class Rating
{
    public string Source { get; set; }
    public string Value { get; set; }
}
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var movieInfpRequest = new MovieInfoByRequest();
                Console.Write("Input Title: ");
                movieInfpRequest.GetMovieInfo(Console.ReadLine());
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }

    class MovieInfoByRequest
    {
        private Dictionary<string, Movie> cach = new Dictionary<string, Movie>(); 
        public void GetMovieInfo(string movieTitle)
        {
            Movie result;
            if (cach.ContainsKey(movieTitle))
            {
                result = cach[movieTitle];
            }
            else
            {
                WebClient web = new WebClient();
                var response = web.DownloadString($@"http://www.omdbapi.com/?apikey=f4e0873a&t={movieTitle}");
                result = JsonSerializer.Deserialize<Movie>(response);
                cach.Add(movieTitle, result);
            }
           
            Console.WriteLine($"Country: {result.Country}\nDirector: {result.Director}\n" +
                $"Released: {result.Released}");
        }
    }
}
