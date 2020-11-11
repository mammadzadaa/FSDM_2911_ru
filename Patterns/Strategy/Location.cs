namespace Strategy
{
    public class Location
    {
        public Location(decimal longitude, decimal latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public override string ToString()
        {
            return $"Longitude {Longitude} - Latitude {Latitude} ";
        }
    }
}
