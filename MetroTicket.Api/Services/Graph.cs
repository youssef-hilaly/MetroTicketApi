using MetroTicket.DataService.Data;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using MetroTicket.Entities.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroTicket.Api.Services.Interfaces;

namespace MetroTickets.Helpers
{
    public class Graph
    {

        private static Graph? _instance = null;

        private readonly AppDbContext _db;

        private Dictionary<int, List<int>> adjacencyList; // Store the Graph so we can traverse over it
        private static List<Station> stations;

        private Graph()
        {
            //_db = new AppDbContext(options);
            adjacencyList = new Dictionary<int, List<int>>();
            Init();
        }

        public static Graph GetInstance()
        {
            _instance ??= new Graph();
            return _instance;
        }

        private async void Init()
        {
            stations = await _db.Stations.ToListAsync();
            List<Edge> edges = await _db.Edges.ToListAsync();

            for (int i = 0; i < edges.Count; i++)
            {
                AddEdge(edges[i].SecondId, edges[i].FirstId);
                AddEdge(edges[i].FirstId, edges[i].SecondId);
            }
        }
        public void ReInitializeGraph()
        {
            adjacencyList.Clear();
            Init();
        }

        private void AddEdge(int source, int destination)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                adjacencyList[source] = new List<int>();
            }
            adjacencyList[source].Add(destination);
        }

        // Using BFS Algorithm
        public Result<int> GetShortestPath(int from, int to)
        {

            if (Cache.IsExist(from, to))
            {
                return Result<int>.Success(Cache.Get(from, to));
            }
            if (Cache.IsExist(to, from))
            {
                return Result<int>.Success(Cache.Get(to, from));
            }

            HashSet<int> isVisited = new HashSet<int>();
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(from, 0));

            while (queue.Count > 0)
            {
                var (node, distance) = queue.Dequeue();

                if (node == to)
                {
                    Cache.AddToCache(from, to, distance);
                    return Result<int>.Success(distance);
                }

                if (adjacencyList.ContainsKey(node))
                {
                    foreach (int child in adjacencyList[node])
                    {
                        if (isVisited.Contains(child)) continue;

                        isVisited.Add(child);
                        queue.Enqueue(new Tuple<int, int>(child, distance + 1));
                    }
                }
            }
            return Result<int>.Failure($"{Constats.NO_PATH} {from}, {to}");
        }
        public static bool IsExist(int id)
        {
            return stations.Any(x => x.Id == id);
        }

        public void DisplayStations()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{stations[i].Id} {stations[i].Name}");
            }
        }
    }
}
