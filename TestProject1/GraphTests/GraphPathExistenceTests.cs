using MetroTicket.DataService.Data;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Constants;

namespace TestProject1.GraphTests
{
    public class GraphPathExistenceTests
    {
        private Graph _graph;
        private AppDbContext _db;

        public GraphPathExistenceTests()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options => options.UseSqlite("DataSource=metro.db;"));

            var serviceProvider = services.BuildServiceProvider();
            _db = serviceProvider.GetRequiredService<AppDbContext>();

            _graph = Graph.GetInstance();
        }

        private async Task<int> GetStationIdByName(string name) => (await _db.Stations.FirstOrDefaultAsync(s => s.Name == name))!.Id;

        #region Line 1
        [Fact]
        public async void PathExistence_Line1_BetweenHelwanAndMaadi_ReturnsIsPathExist()
        {
            // Arrange
            int HelwanId = await GetStationIdByName(StationConstants.HELWAN);
            int MaadiId = await GetStationIdByName(StationConstants.MAADI);

            // Act
            Result<int> result = _graph.GetShortestPath(HelwanId, MaadiId);

            // Assert
            Assert.True(result.IsSuccess);
        }


        [Fact]
        public async void PathExistence_Line1_BetweenHelwanAndNewElMarg_ReturnsIsPathExist()
        {
            // Arrange
            int HelwanId = await GetStationIdByName(StationConstants.HELWAN);
            int NewElMargId = await GetStationIdByName(StationConstants.NEW_MARG);

            // Act
            Result<int> result = _graph.GetShortestPath(HelwanId, NewElMargId);

            // Assert
            Assert.True(result.IsSuccess);
        }
        #endregion


        #region Line 2
        [Fact]
        public async void PathExistence_Line2_BetweenShoubraAlKhaimahAndRodElFarag_ReturnsIsPathExist()
        {
            // Arrange
            int ShoubraAlKhaimahId = await GetStationIdByName(StationConstants.SHUBRA_AL_KHAIMAH);
            int RodElFaragId = await GetStationIdByName(StationConstants.ROD_EL_FARAG);

            // Act
            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimahId, RodElFaragId);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async void PathExistence_Line2_BetweenShoubraAlKhaimahAndElMonib_ReturnsIsPathExist()
        {
            // Arrange
            int ShoubraAlKhaimahId = await GetStationIdByName(StationConstants.SHUBRA_AL_KHAIMAH);
            int ElMonibId = await GetStationIdByName(StationConstants.EL_MONIB);

            // Act
            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimahId, ElMonibId);

            // Assert
            Assert.True(result.IsSuccess);
        }
        #endregion


        #region Line 3
        [Fact]
        public async void PathExistence_Line3_BetweenAdlyMansourAndAlfMasken_ReturnsIsPathExist()
        {
            // Arrange
            int AdlyMansourId = await GetStationIdByName(StationConstants.ADLY_MANSOUR);
            int AlfMaskenId = await GetStationIdByName(StationConstants.ALF_MASKEN);

            // Act
            Result<int> result = _graph.GetShortestPath(AdlyMansourId, AlfMaskenId);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async void PathExistence_Line3_BetweenAdlyMansourAndRodElFaragCorridor_ReturnsIsPathExist()
        {
            // Arrange
            int AdlyMansourId = await GetStationIdByName(StationConstants.ADLY_MANSOUR);
            int RodElFaragCorridorId = await GetStationIdByName(StationConstants.ROD_EL_FARAG_CORRIDOR);

            // Act
            Result<int> result = _graph.GetShortestPath(AdlyMansourId, RodElFaragCorridorId);

            // Assert
            Assert.True(result.IsSuccess);
        }
        #endregion

        #region Intersections
        [Fact]
        public async void PathExistence_LinesIntersection_BetweenSaadZaghloulAndElGeish_ReturnsIsPathExist()
        {
            // Arrange
            int SaadZaghloulId = await GetStationIdByName(StationConstants.SAADZAGHLOUL);
            int ElGeishId = await GetStationIdByName(StationConstants.EL_GEISH);

            // Act
            Result<int> result = _graph.GetShortestPath(SaadZaghloulId, ElGeishId);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async void PathExistence_LinesIntersection_BetweenOperaAndOrabi_ReturnsIsPathExist()
        {
            // Arrange
            int OperaId = await GetStationIdByName(StationConstants.OPERA);
            int OrabiId = await GetStationIdByName(StationConstants.ORABI);

            // Act
            Result<int> result = _graph.GetShortestPath(OperaId, OrabiId);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async void PathExistence_LinesIntersection_BetweenElMonibAndKitKat_ReturnsIsPathExist()
        {
            // Arrange
            int ElMonibId = await GetStationIdByName(StationConstants.EL_MONIB);
            int KIT_KATId = await GetStationIdByName(StationConstants.KIT_KAT);

            // Act
            Result<int> result = _graph.GetShortestPath(ElMonibId, KIT_KATId);

            // Assert
            Assert.True(result.IsSuccess);
        }
        #endregion
    }
}
