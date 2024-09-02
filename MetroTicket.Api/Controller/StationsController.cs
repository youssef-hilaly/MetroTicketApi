using MetroTicket.DataService.Data;
using MetroTicket.DataService.Repositories.Interfaces;
using MetroTicket.Entities.DbSet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetroTicket.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly IStationRepository _stationService;

        public StationsController( IStationRepository stationService)
        {
            _stationService = stationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStations()
        {
            var stations = await _stationService.All();
            return Ok(stations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStation(int id)
        {
            var station = await _stationService.GetById(id);
            return Ok(station);
        }

        [HttpPost]
        public async Task<IActionResult> AddStation(Station station)
        {
            var result = await _stationService.Add(station);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStation(Station station)
        {
            var result = await _stationService.Update(station);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStation(int id)
        {
            var result = await _stationService.Delete(id);
            return Ok(result);
        }

    }
}
