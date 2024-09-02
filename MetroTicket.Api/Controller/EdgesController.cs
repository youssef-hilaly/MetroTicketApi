using MetroTicket.DataService.Data;
using MetroTicket.DataService.Repositories.Interfaces;
using MetroTicket.Entities.DbSet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetroTicket.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdgesController : ControllerBase
    {
        private readonly IEdgeRepository _edgeService;

        public EdgesController( IEdgeRepository edgeService)
        {
            _edgeService = edgeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEdges()
        {
            var edges = await _edgeService.All();
            return Ok(edges);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEdge(int id)
        {
            var edge = await _edgeService.GetById(id);
            return Ok(edge);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdge(Edge edge)
        {
            var result = await _edgeService.Add(edge);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEdge(Edge edge)
        {
            var result = await _edgeService.Update(edge);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEdge(int id)
        {
            var result = await _edgeService.Delete(id);
            return Ok(result);
        }

    }
}
