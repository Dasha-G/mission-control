using System.Linq;

namespace Travelling
{
    public class CityGraph
    {
        private Dictionary<string, List<(string, int)>> adjacencyList = new Dictionary<string, List<(string, int)>>();

        public bool CityExists(string city)
        {
            return adjacencyList.ContainsKey(city);
        }
        public bool AddCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city) || CityExists(city))
            {
                return false;
            }
            adjacencyList[city] = new List<(string, int)>();
            return true;
        }
        public bool RemoveCity(string city)
        {
            if (!CityExists(city))
            {
                return false;
            }
            foreach (var key in new List<string>(adjacencyList.Keys))
            {
                if (adjacencyList.ContainsKey(key))
                {
                    adjacencyList[key].RemoveAll(edge => edge.Item1 == city);
                }
            }
            return adjacencyList.Remove(city);
        }
        public override string ToString()
        {
            string result = "";

            foreach (var connection in adjacencyList)
            {
                string cityA = connection.Key;

                foreach (var edge in connection.Value)
                {
                    string cityB = edge.Item1;
                    int distance = edge.Item2;

                    result += $"{cityA}-{cityB},{distance}\n";
                }
            }

            return result;
        }

        public static CityGraph LoadFromFile(string filePath)
        {
            var graph = new CityGraph();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');
                string[] cities = parts[0].Split('-');
                string cityA = cities[0];
                string cityB = cities[1];
                int distance = int.Parse(parts[1]);

                if (!graph.adjacencyList.ContainsKey(cityA))
                {
                    graph.adjacencyList[cityA] = new List<(string, int)>();
                }
                graph.adjacencyList[cityA].Add((cityB, distance));

                if (!graph.adjacencyList.ContainsKey(cityB))
                {
                    graph.adjacencyList[cityB] = new List<(string, int)>();
                }

                graph.adjacencyList[cityB].Add((cityA, distance));
            }
            return graph;
        }

        public List<string> FindShortestPath(string from, string to)
        {
            var dist = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();
            var unvisited = new HashSet<string>(adjacencyList.Keys);

            foreach (var city in adjacencyList.Keys)
                dist[city] = int.MaxValue;
            dist[from] = 0;

            while (unvisited.Count > 0)
            {
                string current = unvisited.OrderBy(c => dist[c]).First();

                unvisited.Remove(current);

                if (current == to) break;

                foreach (var (neighbor, distance) in adjacencyList[current])
                {
                    int newDist = dist[current] + distance;
                    if (newDist < dist[neighbor])
                    {
                        dist[neighbor] = newDist;
                        prev[neighbor] = current;
                    }
                }
            }

            var path = new List<string>();
            string? step = to;

            while (step != null && prev.ContainsKey(step))
            {
                path.Insert(0, step);
                step = prev[step];
            }

            if (step == from) path.Insert(0, from);

            return path;
        }

        public int GetPathDistance(List<string> path)
        {
            int totalDistance = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                string from = path[i];
                string to = path[i + 1];

                var edge = adjacencyList[from].FirstOrDefault(e => e.Item1 == to);

                if (edge == default)
                {
                    return -1;
                }

                totalDistance += edge.Item2;
            }

            return totalDistance;
        }

        public List<string> GetAllCities()
        {
            return adjacencyList.Keys
                                .OrderBy(c => c)
                                .ToList();
        }
    }
}