using System;
using System.Collections.Generic;
using System.IO;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> mapObjects = new List<MapObject>();
            mapObjects.Add(new Hotel() {Name = "Absheron",Lattitude = 40.12, Longitude = 43.12,Stars = 5 });
            mapObjects.Add(new Restaurant() { Name = "Sumakh", Lattitude = 42.12, Longitude = 45.12, Cuisine = Cuisine.Traditional });
            mapObjects.Add(new BusStation() { Name = "28 May", Lattitude = 41.22, Longitude = 42.42, BusNumbers = {1, 2, 10 } });
            foreach (var item in mapObjects)
            {
                item.Export(new MapObjectExporter());
            }

        }
    }

    interface IExport
    {
        void Export(MapObjectExporter exporter);
    }
    abstract class MapObject : IExport
    {
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public abstract void Export(MapObjectExporter exporter);

        public override string ToString()
        {
            return $"Name: {Name}\nCoordinates: {Lattitude}, {Longitude}\n";
        }
    }

    class Hotel : MapObject
    {
        public int Stars { get; set; }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportHotel(this);
        }

        public override string ToString()
        {
            return "Hotel\n" + base.ToString() + $"Stars: {Stars}\n";
        }
    }
    enum Cuisine
    {
        Italian, Traditional, Fastfood
    }
    class Restaurant : MapObject
    {
        public Cuisine Cuisine { get; set; }

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportRestaurant(this);
        }

        public override string ToString()
        {
            return "Restaurant\n" + base.ToString() + $"Cuisine: {Cuisine}";
        }
    }

    class BusStation : MapObject
    {
        public List<int> BusNumbers { get; set; } = new List<int>();

        public override void Export(MapObjectExporter exporter)
        {
            exporter.ExportBusStation(this);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in BusNumbers)
            {
                str += $"{item} ";
            }
            return "Bus Station\n" + base.ToString() + $"Bus numbers: {str}\n";
        }
    }

    class MapObjectExporter
    {
        public void ExportHotel(Hotel hotel)
        {
            if (!Directory.Exists("hotels"))
            {
                Directory.CreateDirectory("hotels");
            }
            File.WriteAllText($"hotels\\{hotel.Name}.txt", hotel.ToString());
        }
        public void ExportRestaurant(Restaurant restaurant)
        {
            if (!Directory.Exists("restaurants"))
            {
                Directory.CreateDirectory("restaurants");
            }
            File.WriteAllText($"restaurants\\{restaurant.Name}.txt", restaurant.ToString());
        }

        public void ExportBusStation(BusStation busstation)
        {
            if (!Directory.Exists("busstations"))
            {
                Directory.CreateDirectory("busstations");
            }
            File.WriteAllText($"busstations\\{busstation.Name}.txt", busstation.ToString());
        }
    }
}
