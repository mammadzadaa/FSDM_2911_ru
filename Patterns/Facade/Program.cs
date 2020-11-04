using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TripOrganiser.OrganiseTrip("Air", "Hotel", 4, "Online", true);
            Console.WriteLine();

            TripInfo tripInfo = new TripInfo()
            {
                TypeOfTransport = "Ground",
                TypeOfGidance = "Offline",
                TypeOfAccomindation = "Apartment",
                IsVisaRequred = true,
                NumberOfStarsOfAccomindation = 5
            };
            TripOrganiser.OrganiseTrip(tripInfo);
        }
    }
}
