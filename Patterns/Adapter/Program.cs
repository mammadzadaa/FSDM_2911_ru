using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new OnlineMP3Player();
            var music = new Mp3Sound("R Kelly", "I belive I can fly", 5.22, 320, 13.5, "I belive I can fly, I belive I can touch the sky");
            player.UploadMusic(music);
            player.Play();
            var anotherMusic = new WAWSound(12.6,4.3,256,20.4,"What is love? Baybe don't heart me, don't heart me, no more!");
            Console.WriteLine();
            player.UploadMusic(new MP3Adapter(anotherMusic));
            player.Play();
        }
    }
}
