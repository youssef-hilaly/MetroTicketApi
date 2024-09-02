using MetroTicket.Entities.DbSet;
using MetroTicket.Helpers;
using Microsoft.EntityFrameworkCore;

namespace MetroTicket.DataService.Data
{
    //add-migration "init" -StartupProject MetroTicket.Api
    //update-database -StartupProject MetroTicket.Api
    public class AppDbContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Edge> Edges { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            GraphConstructionToDB graphHelper = new GraphConstructionToDB();
            modelBuilder.Entity<Station>().HasData(graphHelper.stationsArray);
            modelBuilder.Entity<Edge>().HasData(graphHelper.edgesArray);
        }
    }
}
