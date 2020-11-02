using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MP3Adapter : Mp3Sound
    {
        public MP3Adapter(WAWSound sound) : base("", "", sound.Length, sound.Quality, sound.Size, sound.Content) { }

    }
}
