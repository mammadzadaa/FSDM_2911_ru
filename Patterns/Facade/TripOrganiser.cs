namespace Facade
{
    public static class TripOrganiser
    {
        public static void OrganiseTrip(string typeOfTransport, string typeOfAccomindation, int starsOfAccomindation, string typeOfGuidance, bool isVisaRequried = false)
        {
            if (typeOfTransport == "Air")
            {
                TransportOrganiser.OrderAirplaneTickets();
            }
            else if(typeOfTransport == "Ground")
            {
                TransportOrganiser.OrderBusTickets();
            }

            if (typeOfAccomindation == "Hotel")
            {
                AccomindationOrginiser.BookHotel(starsOfAccomindation);
            }
            else if (typeOfAccomindation == "Apartment")
            {
                AccomindationOrginiser.BookApartment(starsOfAccomindation);
            }

            if (typeOfGuidance == "Online")
            {
                GuidanceOrginiser.GetOnlineGuidance();
            }
            else if (typeOfGuidance == "Offline")
            {
                GuidanceOrginiser.GetOfflineGuidance();
            }
            if (isVisaRequried)
            {
                VisaOrginiser.GetVisaDone();
            }
        }
        public static void OrganiseTrip(TripInfo info)
        {
            OrganiseTrip(info.TypeOfTransport, info.TypeOfAccomindation, info.NumberOfStarsOfAccomindation, info.TypeOfGidance, info.IsVisaRequred);
        }
    }
}
