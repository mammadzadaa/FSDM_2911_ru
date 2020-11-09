using System;
using System.Collections.Generic;
using System.Net;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            WebBrowser browser = new WebBrowser(new WebBrowserEngine(), new WebBrowserFavoriteStorage());

            int menuSelection;
            while (true)
            {
                Console.WriteLine("1 - Go to url");
                Console.WriteLine("2 - Add to favorite");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        browser.GoToPage();
                        break;
                    case 2:
                        browser.AddToFavorite();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

            }
        }
    }

    //UI
    class WebBrowser
    {
        private readonly WebBrowserEngine webBrowserEngine;
        private readonly WebBrowserFavoriteStorage webBrowserFavoriteStorage;

        public WebBrowser(WebBrowserEngine webBrowserEngine, WebBrowserFavoriteStorage webBrowserFavoriteStorage)
        {
            this.webBrowserEngine = webBrowserEngine;
            this.webBrowserFavoriteStorage = webBrowserFavoriteStorage;
        }

        public void GoToPage()
        {
            Console.Write("Enter URL: ");
            var url = Console.ReadLine();
            ICommand command = new GoToPageCommand(url, webBrowserEngine);
            command.Execute();

            //var html = webBrowserEngine.LoadPage(url);
            //Console.WriteLine(html);
        }

        public void AddToFavorite()
        {
            Console.Write("Enter URL: ");
            var url = Console.ReadLine();
            Console.Write("Enter Title: ");
            var title = Console.ReadLine();
            ICommand command = new AddToFavoriteCommand(url,title, webBrowserFavoriteStorage);
            command.Execute();

            //webBrowserFavoriteStorage.AddToFavorite(new Favorite() { Title = "Untitled", Url = url });
        }
    }

    //Base command
    interface ICommand
    {
        void Execute();
    }

    class GoToPageCommand : ICommand
    {
        private readonly WebBrowserEngine reciver;
        private string url;

        public GoToPageCommand(string url, WebBrowserEngine reciver)
        {
            this.url = url;
            this.reciver = reciver;
        }

        public void Execute()
        {
            var html = reciver.LoadPage(url);
            Console.WriteLine(html);
        }
    }

    class AddToFavoriteCommand : ICommand
    {
        private readonly WebBrowserFavoriteStorage reciver;
        private string url;
        private string title;

        public AddToFavoriteCommand(string url, string title, WebBrowserFavoriteStorage reciver)
        {
            this.url = url;
            this.title = title;
            this.reciver = reciver;
        }

        public void Execute()
        {
            reciver.AddToFavorite(new Favorite() { Url = url, Title = title });
        }
    }

    // Busines logic
    class WebBrowserEngine
    {
        public string LoadPage(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            return html;
        }
    }

    // Busines logic
    class WebBrowserFavoriteStorage
    {
        private List<Favorite> listOfFavorite = new List<Favorite>();
        public void AddToFavorite(Favorite favorite)
        {
            listOfFavorite.Add(favorite);
        }
        public void RemoveFromFavorite(Favorite favorite)
        {
            listOfFavorite.Remove(favorite);
        }

    }

    class Favorite
    {
        public string Url { get; set; }
        public string Title { get; set; }
    }
}
