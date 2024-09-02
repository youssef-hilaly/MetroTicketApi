using MetroTicket.DataService.Repositories.Interfaces;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.Models;


namespace MetroTicket.DataService.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly Graph _graph;
        public TicketRepository()
        {
            _graph = Graph.GetInstance();
        }


        public Result<int> GetTicketPrice(int CurrentStationId, int DistinationStationId)
        {
            Result<int> result = _graph.GetShortestPath(CurrentStationId, DistinationStationId);
            if (!result.IsSuccess)
            {
                return result;
            }
            Console.WriteLine(result.Data);
            return Result<int>.Success(HelperFunctions.CalcPrice(result.Data));
        }
    }
}
