using MetroTicket.DataService.Data;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestProject1.Constants;

namespace TestProject1.GraphTests
{
    public class GraphDistanceTests
    {
        private Graph _graph;
        private AppDbContext _db;

        public GraphDistanceTests()
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
        public async void FindDistance_Line1_BetweenHelwanAndMaadi_ReturnsDistance()
        {
            // Arrange
            int HelwanId = await GetStationIdByName(StationConstants.HELWAN);
            int MaadiId = await GetStationIdByName(StationConstants.MAADI);

            Result<int> result = _graph.GetShortestPath(HelwanId, MaadiId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_HELWAN_MAADI;

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public async void FindDistance_Line1_BetweenHelwanAndNewElMarg_ReturnsDistance()
        {
            // Arrange
            int HelwanId = await GetStationIdByName(StationConstants.HELWAN);
            int NewElMargId = await GetStationIdByName(StationConstants.NEW_MARG);

            Result<int> result = _graph.GetShortestPath(HelwanId, NewElMargId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_HELWAN_NEW_MARG;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion


        #region Line 2
        [Fact]
        public async void FindDistance_Line2_BetweenShoubraAlKhaimahAndRodElFarag_ReturnsDistance()
        {
            // Arrange
            int ShoubraAlKhaimahId = await GetStationIdByName(StationConstants.SHUBRA_AL_KHAIMAH);
            int RodElFaragId = await GetStationIdByName(StationConstants.ROD_EL_FARAG);

            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimahId, RodElFaragId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_ROD_EL_FARAG;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_Line2_BetweenShoubraAlKhaimahAndElMonib_ReturnsDistance()
        {
            // Arrange
            int ShoubraAlKhaimahId = await GetStationIdByName(StationConstants.SHUBRA_AL_KHAIMAH);
            int ElMonibId = await GetStationIdByName(StationConstants.EL_MONIB);

            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimahId, ElMonibId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_EL_MONIB;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion


        #region Line 3
        [Fact]
        public async void FindDistance_Line3_BetweenAdlyMansourAndAlfMasken_ReturnsDistance()
        {
            // Arrange
            int AdlyMansourId = await GetStationIdByName(StationConstants.ADLY_MANSOUR);
            int AlfMaskenId = await GetStationIdByName(StationConstants.ALF_MASKEN);

            Result<int> result = _graph.GetShortestPath(AdlyMansourId, AlfMaskenId);

            // Act  
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ADLY_MANSOUR_ALF_MASKEN;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_Line3_BetweenAdlyMansourAndRodElFaragCorridor_ReturnsDistance()
        {
            // Arrange
            int AdlyMansourId = await GetStationIdByName(StationConstants.ADLY_MANSOUR);
            int RodElFaragCorridorId = await GetStationIdByName(StationConstants.ROD_EL_FARAG_CORRIDOR);

            Result<int> result = _graph.GetShortestPath(AdlyMansourId, RodElFaragCorridorId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ADLY_MANSOUR_ROD_EL_FARAG_CORRIDOR;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Intersections
        [Fact]
        public async void FindDistance_LinesIntersection_BetweenSaadZaghloulAndElGeish_ReturnsDistance()
        {
            // Arrange
            int SaadZaghloulId = await GetStationIdByName(StationConstants.SAADZAGHLOUL);
            int ElGeishId = await GetStationIdByName(StationConstants.EL_GEISH);

            Result<int> result = _graph.GetShortestPath(SaadZaghloulId, ElGeishId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SAADZAGHLOUL_EL_GEISH;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_LinesIntersection_BetweenOperaAndOrabi_ReturnsDistance()
        {
            // Arrange
            int OperaId = await GetStationIdByName(StationConstants.OPERA);
            int OrabiId = await GetStationIdByName(StationConstants.ORABI);

            Result<int> result = _graph.GetShortestPath(OperaId, OrabiId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_OPERA_ORABI;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_LinesIntersection_BetweenElMonibAndKitKat_ReturnsDistance()
        {
            // Arrange
            int ElMonibId = await GetStationIdByName(StationConstants.EL_MONIB);
            int KIT_KATId = await GetStationIdByName(StationConstants.KIT_KAT);

            Result<int> result = _graph.GetShortestPath(ElMonibId, KIT_KATId);

            // Act
            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ElMonib_KIT_KAT;

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

    }
}
