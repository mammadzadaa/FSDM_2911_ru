using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class OnlineMP3Player
    {
        private Mp3Sound sound;

        public void UploadMusic(Mp3Sound sound)
        {
            this.sound = sound;
        }
        public void Play()
        {
            if (sound != null)
            {
                Console.WriteLine($"Artist: {sound.Artist}\nSong Name: {sound.SongName}\n" +
                    $"Duretion: {sound.Length} min\nQuality: {sound.Quality} bit\nSize: {sound.Size} mb\n" +
                    $"{sound.Content}");
            }
        }

    }
}
