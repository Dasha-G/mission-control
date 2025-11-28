using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Travelling
{
    public class Traveler
    {
        protected string name;
        protected string currentLocation = "";
        protected List<string> cities = new List<string>();

        private class TempTraveler
        {
            public string? name { get; set; }
            public string? currentLocation { get; set; }
            public List<string>? route { get; set; }
        }

        public Traveler(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                currentLocation = string.Empty;
                return;
            }

            var formattedLocation = location
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1));

            currentLocation = string.Join(" ", formattedLocation);
        }


        public string? GetLocation()
        {
            return currentLocation;
        }

        public void AddCity(string city)
        {

            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("Error");
            }
            else
            {
                var formattedCity = city
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1));

                city = string.Join(" ", formattedCity);

                cities.Add(city);
            }
        }

        public List<string> GetCities()
        {
            return new List<string>(cities);
        }

        public string GetRoute()
        {
            string route = "";
            cities.ForEach(city =>
            {
                if (route.Length > 0)
                    route += " -> ";
                route += city;
            });
            return route;
        }

        public override string ToString()
        {
            return $"Traveler: {name} | Location: {currentLocation} | Route: {GetRoute()}";
        }

        public void ClearRoute()
        {
            cities.Clear();
        }

        public int GetStopCount()
        {
            return cities.Count;
        }

        public bool HasCity(string city)
        {
            if (cities.Contains(city))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SortRoute()
        {
            cities.Sort();
        }

        public bool RemoveCity(string city)
        {
            return cities.Remove(city);
        }

        public string? GetNextStop()
        {
            if (cities.Count > 0)
            {
                return cities[0];
            }
            else
            {
                return null;
            }
        }

        public string this[int index]
        {
            get { return cities[index]; }
        }

        public static bool operator ==(Traveler? a, Traveler? b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.name == b.name &&
                   a.currentLocation == b.currentLocation;
        }

        public static bool operator !=(Traveler? a, Traveler? b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Traveler other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(name, currentLocation);
        }
        public object Clone()
        {
            Traveler copy = new Traveler(this.name);
            copy.SetLocation(this.currentLocation);
            copy.cities = new List<string>(this.cities);

            return copy;
        }

        public void SaveToFile(string filePath)
        {
            var obj = new
            {
                name = this.name,
                currentLocation = this.currentLocation,
                route = this.cities
            };

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(obj, settings);

            File.WriteAllText(filePath, json);
        }

        public static Traveler LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var temp = JsonConvert.DeserializeObject<TempTraveler>(json);
            if (temp == null)
            {
                throw new Exception("Error during deserialization");
            }
            if (temp.name == null)
            {
                throw new Exception("Traveler name is missing in file");
            }
            Traveler traveler = new Traveler(temp.name);
            traveler.SetLocation(temp.currentLocation ?? "");
            if (temp.route != null)
            {
                foreach (var city in temp.route) {
                    if (city != null)
                    {
                        traveler.AddCity(city);
                    }
                }
            }
            return traveler;
        }

        public bool PlanRouteTo(string destination, CityGraph map)
        {
            string from = "";
            if (!string.IsNullOrEmpty(currentLocation))
            {
                from = currentLocation;
            }
            else if (cities.Count > 0)
            {
                from = cities[0];
            }
            else
            {
                
                return false;
            }
            if (!map.CityExists(from)) 
            {

                throw new ArgumentException($"The starting city '{from}' is not recognized in the map. Please enter a valid Current City.");
            }
            List<string> shortestPath = map.FindShortestPath(from, destination);
            if (shortestPath.Count == 0)
            {
                return false;
            }
            cities.Clear();
            for (int i = 0; i < shortestPath.Count; i++)
            {
                cities.Add(shortestPath[i]);
            }
            return true;
        }
        public void SetCities(List<string> newRoute)
        {
            cities = newRoute;
        }
    }
    
}

