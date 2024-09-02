using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.Entities.Dtos
{
    public class DistanceCalculationRequest
    {
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
    }
}
