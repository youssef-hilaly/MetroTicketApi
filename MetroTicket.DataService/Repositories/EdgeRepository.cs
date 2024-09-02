using MetroTicket.DataService.Data;
using MetroTicket.DataService.Repositories.Interfaces;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.DataService.Repositories
{
    public class EdgeRepository : IEdgeRepository
    {
        public readonly ILogger _logger;
        protected AppDbContext _context;
        internal DbSet<Edge> _dbSet;
        public EdgeRepository(AppDbContext context, ILogger<EdgeRepository> logger)
        {
            _context = context;
            _dbSet = _context.Set<Edge>();
            _logger = logger;
        }
        public async Task<bool> Add(Edge entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                _context.SaveChanges();

                // Updating Memory Graph
                Graph graph = Graph.GetInstance();
                graph.AddEdge(entity.FirstId, entity.SecondId);
                graph.AddEdge(entity.SecondId, entity.FirstId);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Add function error", typeof(EdgeRepository));
                return false;
            }
        }

        public async Task<IEnumerable<Edge>> All()
        {
            try
            {
                return await _dbSet.AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} All function error", typeof(EdgeRepository));
                throw;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                    return false;

                _dbSet.Remove(result);
                _context.SaveChanges();

                // Updating Memory Graph
                Graph graph = Graph.GetInstance();
                graph.RemoveEdge(result.FirstId, result.SecondId);
                graph.RemoveEdge(result.SecondId, result.FirstId);

                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} delete function error", typeof(EdgeRepository));
                throw;
            }
        }

        public async Task<Edge?> GetById(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} get by id function error", typeof(EdgeRepository));
                throw;
            }
        }

        public async Task<bool> Update(Edge entity)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == entity.Id);

                if (result == null)
                    return false;

                result.FirstStation = entity.FirstStation;
                result.FirstId = entity.FirstId;
                result.SecondStation = entity.SecondStation;
                result.SecondId = entity.SecondId;
                result.Cost = entity.Cost;

                _context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                _logger.LogError(e, "{Repo} update function error", typeof(EdgeRepository));
                throw;
            }
        }
    }
}
