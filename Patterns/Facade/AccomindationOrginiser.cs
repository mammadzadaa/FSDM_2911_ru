using System;

namespace Facade
{
    public static class AccomindationOrginiser
    {
        public static void BookHotel(int stars)
        {
            Console.WriteLine($"{stars} star Hotel booked");
        }
        public static void BookApartment(int stars)
        {
            Console.WriteLine($"{stars} star Apartment booked");
        }
    }
}
