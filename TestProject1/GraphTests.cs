using MetroTicket.DataService.Data;
using MetroTicket.DataService.Services;
using MetroTicket.Entities.DbSet;
using MetroTicket.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestProject1.Constants;

namespace MetroTickets.Tests
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

        #region Line 1
        [Fact]
        public async void FindDistance_Line1_BetweenHelwanAndMaadi_ReturnsDistance()
        {
            Station? Helwan = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.HELWAN);
            Station? Maadi = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.MAADI);

            Assert.NotNull(Helwan);
            Assert.NotNull(Maadi);

            Result<int> result = _graph.GetShortestPath(Helwan.Id, Maadi.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_HELWAN_MAADI;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public async void FindDistance_Line1_BetweenHelwanAndNewElMarg_ReturnsDistance()
        {
            Station? Helwan = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.HELWAN);
            Station? NewElMarg = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.NEW_MARG);

            Assert.NotNull(Helwan);
            Assert.NotNull(NewElMarg);

            Result<int> result = _graph.GetShortestPath(Helwan.Id, NewElMarg.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_HELWAN_NEW_MARG;

            Assert.Equal(expected, actual);
        }
        #endregion


        #region Line 2
        [Fact]
        public async void FindDistance_Line2_BetweenShoubraAlKhaimahAndRodElFarag_ReturnsDistance()
        {
            Station? ShoubraAlKhaimah = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.SHUBRA_AL_KHAIMAH);
            Station? RodElFarag = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ROD_EL_FARAG);

            Assert.NotNull(ShoubraAlKhaimah);
            Assert.NotNull(RodElFarag);

            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimah.Id, RodElFarag.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_ROD_EL_FARAG;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_Line2_BetweenShoubraAlKhaimahAndElMonib_ReturnsDistance()
        {
            Station? ShoubraAlKhaimah = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.SHUBRA_AL_KHAIMAH);
            Station? ElMonib = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.EL_MONIB);

            Assert.NotNull(ShoubraAlKhaimah);
            Assert.NotNull(ElMonib);

            Result<int> result = _graph.GetShortestPath(ShoubraAlKhaimah.Id, ElMonib.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SHUBRA_AL_KHAIMAH_EL_MONIB;

            Assert.Equal(expected, actual);
        } 
        #endregion


        #region Line 3
        [Fact]
        public async void FindDistance_Line3_BetweenAdlyMansourAndAlfMasken_ReturnsDistance()
        {
            Station? AdlyMansour = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ADLY_MANSOUR);
            Station? AlfMasken = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ALF_MASKEN);

            Assert.NotNull(AdlyMansour);
            Assert.NotNull(AlfMasken);

            Result<int> result = _graph.GetShortestPath(AdlyMansour.Id, AlfMasken.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ADLY_MANSOUR_ALF_MASKEN;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_Line3_BetweenAdlyMansourAndRodElFaragCorridor_ReturnsDistance()
        {
            Station? AdlyMansour = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ADLY_MANSOUR);
            Station? RodElFaragCorridor = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ROD_EL_FARAG_CORRIDOR);

            Assert.NotNull(AdlyMansour);
            Assert.NotNull(RodElFaragCorridor);

            Result<int> result = _graph.GetShortestPath(AdlyMansour.Id, RodElFaragCorridor.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ADLY_MANSOUR_ROD_EL_FARAG_CORRIDOR;

            Assert.Equal(expected, actual);
        }
        #endregion

        #region Intersections
        [Fact]
        public async void FindDistance_LinesIntersection_BetweenSaadZaghloulAndElGeish_ReturnsDistance()
        {
            Station? SaadZaghloul = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.SAADZAGHLOUL);
            Station? ElGeish = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.EL_GEISH);

            Assert.NotNull(SaadZaghloul);
            Assert.NotNull(ElGeish);

            Result<int> result = _graph.GetShortestPath(SaadZaghloul.Id, ElGeish.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_SAADZAGHLOUL_EL_GEISH;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_LinesIntersection_BetweenOperaAndOrabi_ReturnsDistance()
        {
            Station? Opera = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.OPERA);
            Station? Orabi = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.ORABI);

            Assert.NotNull(Opera);
            Assert.NotNull(Orabi);

            Result<int> result = _graph.GetShortestPath(Opera.Id, Orabi.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_OPERA_ORABI;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_LinesIntersection_BetweenElMonibAndKitKat_ReturnsDistance()
        {
            Station? ElMonib = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.EL_MONIB);
            Station? KIT_KAT = await _db.Stations.FirstOrDefaultAsync(s => s.Name == StationConstants.KIT_KAT);

            Assert.NotNull(ElMonib);
            Assert.NotNull(KIT_KAT);

            Result<int> result = _graph.GetShortestPath(ElMonib.Id, KIT_KAT.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = StationConstants.DISTANCE_ElMonib_KIT_KAT;

            Assert.Equal(expected, actual);
        }

        #endregion

    }
}
