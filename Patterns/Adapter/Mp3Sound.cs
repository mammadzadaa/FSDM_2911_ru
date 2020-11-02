namespace Adapter
{
    public class Mp3Sound
    {
        public Mp3Sound(string artist, string songName, double length, int quality, double size, string content)
        {
            Artist = artist;
            SongName = songName;
            Length = length;
            Quality = quality;
            Size = size;
            Content = content;
        }

        public string Artist { get; set; }
        public string SongName { get; set; }
        public double Length { get; set; }
        public int Quality { get; set; }
        public double Size { get; set; }
        public string Content { get; set; }

    }
}