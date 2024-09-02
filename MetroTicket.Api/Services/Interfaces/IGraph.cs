using MetroTicket.Entities.Models;

namespace MetroTicket.Api.Services.Interfaces
{
    public interface IGraph
    {
        Result<int> GetShortestPath(int source, int destination);
        void ReInitializeGraph();
    }
}
