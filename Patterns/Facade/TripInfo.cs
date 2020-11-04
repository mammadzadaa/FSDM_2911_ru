namespace Facade
{
    public class TripInfo
    {
        public string TypeOfTransport { get; set; }
        public string TypeOfAccomindation { get; set; }
        private int AccomindationStars;
        public string TypeOfGidance { get; set; }
        public bool IsVisaRequred { get; set; }
        public int NumberOfStarsOfAccomindation
        {
            get { return AccomindationStars; }
            set {
                    if (value <= 5 && value >= 0)
                    {
                        AccomindationStars = value; 
                    }
                }
        }

    }
}
