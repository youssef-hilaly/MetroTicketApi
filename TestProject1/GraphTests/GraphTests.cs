using MetroTicket.DataService.Data;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestProject1.Constants;

namespace TestProject1.GraphTests
{
    public class GraphTests
    {
        private Graph _graph;
        private AppDbContext _db;

        public GraphTests()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options => options.UseSqlite("DataSource=metro.db;"));

            var serviceProvider = services.BuildServiceProvider();
            _db = serviceProvider.GetRequiredService<AppDbContext>();

            _graph = Graph.GetInstance();
        }

        private async Task<int> GetStationIdByName(string name) => (await _db.Stations.FirstOrDefaultAsync(s => s.Name == name))!.Id;


        [Theory]
        [InlineData(StationConstants.HELWAN, StationConstants.MAADI)]
        [InlineData(StationConstants.HELWAN, StationConstants.NEW_MARG)]
        [InlineData(StationConstants.SHUBRA_AL_KHAIMAH, StationConstants.ROD_EL_FARAG)]
        [InlineData(StationConstants.SHUBRA_AL_KHAIMAH, StationConstants.EL_MONIB)]
        [InlineData(StationConstants.ADLY_MANSOUR, StationConstants.ALF_MASKEN)]
        [InlineData(StationConstants.ADLY_MANSOUR, StationConstants.ROD_EL_FARAG_CORRIDOR)]
        [InlineData(StationConstants.SAADZAGHLOUL, StationConstants.EL_GEISH)]
        [InlineData(StationConstants.OPERA, StationConstants.ORABI)]
        [InlineData(StationConstants.EL_MONIB, StationConstants.KIT_KAT)]
        public async void IsPathExist(string source, string destination)
        {
            // Arrange
            int sourceId = await GetStationIdByName(source);
            int destinationId = await GetStationIdByName(destination);

            // Act
            Result<int> result = _graph.GetShortestPath(sourceId, destinationId);

            // Assert
            Assert.True(result.IsSuccess);
        }


        [Theory]
        //Line 1
        [InlineData(StationConstants.HELWAN, StationConstants.MAADI, StationConstants.DISTANCE_HELWAN_MAADI)]
        [InlineData(StationConstants.HELWAN, StationConstants.NEW_MARG, StationConstants.DISTANCE_HELWAN_NEW_MARG)]
        //Line 2
        [InlineData(StationConstants.SHUBRA_AL_KHAIMAH, StationConstants.ROD_EL_FARAG, StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_ROD_EL_FARAG)]
        [InlineData(StationConstants.SHUBRA_AL_KHAIMAH, StationConstants.EL_MONIB, StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_EL_MONIB)]
        //Line 3
        [InlineData(StationConstants.ADLY_MANSOUR, StationConstants.ALF_MASKEN, StationConstants.DISTANCE_ADLY_MANSOUR_ALF_MASKEN)]
        [InlineData(StationConstants.ADLY_MANSOUR, StationConstants.ROD_EL_FARAG_CORRIDOR, StationConstants.DISTANCE_ADLY_MANSOUR_ROD_EL_FARAG_CORRIDOR)]
        //Intersection
        [InlineData(StationConstants.SAADZAGHLOUL, StationConstants.EL_GEISH, StationConstants.DISTANCE_SAADZAGHLOUL_EL_GEISH)]
        [InlineData(StationConstants.OPERA, StationConstants.ORABI, StationConstants.DISTANCE_OPERA_ORABI)]
        [InlineData(StationConstants.EL_MONIB, StationConstants.KIT_KAT, StationConstants.DISTANCE_ElMonib_KIT_KAT)]
        public async void FindDistance(string source, string distination, int expected)
        {
            // Arrange
            int sourceId = await GetStationIdByName(source);
            int distinationId = await GetStationIdByName(distination);

            Result<int> result = _graph.GetShortestPath(sourceId, distinationId);

            // Act
            int actual = result.Data;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
