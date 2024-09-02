using MetroTicket.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.DataService.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        Result<int> GetTicketPrice(int CurrentStationId, int DistinationStationId);
    }
}
