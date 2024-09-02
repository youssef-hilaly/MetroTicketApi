using MetroTicket.DataService.Data;
using MetroTicket.DataService.Repositories.Interfaces;
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
    public class StationRepository : IStationRepository
    {
        public readonly ILogger _logger;
        protected AppDbContext _context;
        internal DbSet<Station> _dbSet;
        public StationRepository(AppDbContext context, ILogger<StationRepository> logger)
        {
            _context = context;
            _dbSet = _context.Set<Station>();
            _logger = logger;
        }
        public async Task<bool> Add(Station entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Add function error", typeof(StationRepository));
                return false;
            }
        }

        public async Task<IEnumerable<Station>> All()
        {
            try
            {
                return await _dbSet.AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} All function error", typeof(StationRepository));
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
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} delete function error", typeof(StationRepository));
                throw;
            }
        }

        public async Task<Station?> GetById(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "{Repo} get by id function error", typeof(StationRepository));
                throw;
            }
        }

        public async Task<bool> Update(Station entity)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == entity.Id);

                if (result == null)
                    return false;

                result.Name = entity.Name;

                _context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                _logger.LogError(e, "{Repo} update function error", typeof(StationRepository));
                throw;
            }
        }
    }
}
