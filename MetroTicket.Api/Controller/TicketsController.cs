using MetroTicket.DataService.Data;
using MetroTicket.DataService.Repositories;
using MetroTicket.DataService.Repositories.Interfaces;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetroTicket.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketsController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEdges([FromBody] DistanceCalculationRequest distanceCalculationRequest)
        {
            var result =  _ticketRepository.GetTicketPrice(distanceCalculationRequest.SourceId, distanceCalculationRequest.DestinationId);
            if (!result.IsSuccess)
            {
                return BadRequest(result.ErrorMessage);
            }
            return Ok(result);
        }
    }
}
