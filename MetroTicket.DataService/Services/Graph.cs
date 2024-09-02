using MetroTicket.DataService.Data;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using MetroTicket.Entities.Constants;
using Microsoft.EntityFrameworkCore;
using MetroTicket.DataService.Services.Interfaces;

namespace MetroTicket.DataService.Services
{
    public class Graph
    {
        private static Graph? _instance;
        private readonly AppDbContext _db;

        private static Dictionary<int, List<int>> adjacencyList; // Store the Graph so we can traverse over it

        public static Graph GetInstance()
        {
            _instance ??= new Graph();
            return _instance;
        }
        private Graph()
        {
            _db = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>().UseSqlite("DataSource=metro.db;").Options);
            adjacencyList = new Dictionary<int, List<int>>();
            Init();
        }

        private async void Init()
        {
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

        public void AddEdge(int source, int destination)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                adjacencyList[source] = new List<int>();
            }
            adjacencyList[source].Add(destination);
        }

        public void RemoveEdge(int source, int destination)
        {
            if (adjacencyList.ContainsKey(source))
            {
                adjacencyList[source].Remove(destination);
            }
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
                isVisited.Add(node);

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

                        queue.Enqueue(new Tuple<int, int>(child, distance + 1));
                    }
                }
            }
            return Result<int>.Failure($"{Constats.NO_PATH} {from}, {to}");
        }
        public static bool IsExist(int id)
        {
            return adjacencyList.ContainsKey(id);
        }
    }
}
