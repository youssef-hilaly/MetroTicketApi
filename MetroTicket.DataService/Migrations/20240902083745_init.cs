using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MetroTicket.DataService.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstId = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Edges_Stations_FirstId",
                        column: x => x.FirstId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Edges_Stations_SecondId",
                        column: x => x.SecondId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Helwan" },
                    { 2, "Ain Helwan" },
                    { 3, "Helwan University" },
                    { 4, "Wadi Hof" },
                    { 5, "Hadayek Helwan" },
                    { 6, "Elmasraa" },
                    { 7, "ura El-Esmant" },
                    { 8, "Kozzika" },
                    { 9, "Tora El-Balad" },
                    { 10, "Sakanat El-Maadi" },
                    { 11, "Maadi" },
                    { 12, "Hadayeq El-Maadi" },
                    { 13, "Dar El-Salam" },
                    { 14, "El-Zahraa" },
                    { 15, "Mar Girgis" },
                    { 16, "El-Malek El-Saleh" },
                    { 17, "Al-Sayeda Zeinab" },
                    { 18, "Saad Zaghloul" },
                    { 19, "Sadat" },
                    { 20, "Nasser" },
                    { 21, "Orabi" },
                    { 22, "Al-Shohadaa" },
                    { 23, "Ghamra" },
                    { 24, "El-Demerdash" },
                    { 25, "Manshiet El-Sadr" },
                    { 26, "Kobri El-Qobba" },
                    { 27, "Hammamat El-Qobba" },
                    { 28, "Saray El-Qobba" },
                    { 29, "Hadayeq El-Zaitoun" },
                    { 30, "elmeyet El-Zaitoun" },
                    { 31, "El-Matareyya" },
                    { 32, "Ain Shams" },
                    { 33, "Ezbet El-Nakhl" },
                    { 34, "El-Marg" },
                    { 35, "New Marg" },
                    { 36, "Shubra Al Khaimah" },
                    { 37, "Koliet El-Zeraa" },
                    { 38, "Mezallat" },
                    { 39, "Khalafawy" },
                    { 40, "St. Teresa" },
                    { 41, "Rod El-Farag" },
                    { 42, "Masarra" },
                    { 43, "Attaba" },
                    { 44, "Mohamed Naguib" },
                    { 45, "Opera" },
                    { 46, "Dokki" },
                    { 47, "El Bohoth" },
                    { 48, "Cairo University" },
                    { 49, "Faisal" },
                    { 50, "Giza" },
                    { 51, "Omm El-Masryeen" },
                    { 52, "Sakiat Mekky" },
                    { 53, "El Monib" },
                    { 54, "Adly Mansour" },
                    { 55, "Haykestep" },
                    { 56, "Omar Ibn El Khattab" },
                    { 57, "Qubaa" },
                    { 58, "Hesham Barakat" },
                    { 59, "El Nozha" },
                    { 60, "El Shams Club" },
                    { 61, "Alf Masken" },
                    { 62, "Heliopolis" },
                    { 63, "Haroun" },
                    { 64, "Al-Ahram" },
                    { 65, "Koleyet El-Banat" },
                    { 66, "Stadium" },
                    { 67, "Abbassiya" },
                    { 68, "Fair Zone" },
                    { 69, "Abdou Pasha" },
                    { 70, "El-Geish" },
                    { 71, "Bab El Shaariya" },
                    { 72, "Maspero" },
                    { 73, "Safaa Hijazy" },
                    { 74, "Kit-Kat" },
                    { 75, "Sudan" },
                    { 76, "Imbaba" },
                    { 77, "El-Bohy" },
                    { 78, "El-Qawmia" },
                    { 79, "Ring Road" },
                    { 80, "Rod El Farag Corridor" },
                    { 81, "Tawfikia" },
                    { 82, "Wadi El Nile" },
                    { 83, "Gamet El Dowal" },
                    { 84, "Boulak El Dakrour" }
                });

            migrationBuilder.InsertData(
                table: "Edges",
                columns: new[] { "Id", "Cost", "FirstId", "SecondId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 3 },
                    { 3, 1, 3, 4 },
                    { 4, 1, 4, 5 },
                    { 5, 1, 5, 6 },
                    { 6, 1, 6, 7 },
                    { 7, 1, 7, 8 },
                    { 8, 1, 8, 9 },
                    { 9, 1, 9, 10 },
                    { 10, 1, 10, 11 },
                    { 11, 1, 11, 12 },
                    { 12, 1, 12, 13 },
                    { 13, 1, 13, 14 },
                    { 14, 1, 14, 15 },
                    { 15, 1, 15, 16 },
                    { 16, 1, 16, 17 },
                    { 17, 1, 17, 18 },
                    { 18, 1, 18, 19 },
                    { 19, 1, 19, 20 },
                    { 20, 1, 20, 21 },
                    { 21, 1, 21, 22 },
                    { 22, 1, 22, 23 },
                    { 23, 1, 23, 24 },
                    { 24, 1, 24, 25 },
                    { 25, 1, 25, 26 },
                    { 26, 1, 26, 27 },
                    { 27, 1, 27, 28 },
                    { 28, 1, 28, 29 },
                    { 29, 1, 29, 30 },
                    { 30, 1, 30, 31 },
                    { 31, 1, 31, 32 },
                    { 32, 1, 32, 33 },
                    { 33, 1, 33, 34 },
                    { 34, 1, 34, 35 },
                    { 35, 1, 36, 37 },
                    { 36, 1, 37, 38 },
                    { 37, 1, 38, 39 },
                    { 38, 1, 39, 40 },
                    { 39, 1, 40, 41 },
                    { 40, 1, 41, 42 },
                    { 41, 1, 42, 22 },
                    { 42, 1, 22, 43 },
                    { 43, 1, 43, 44 },
                    { 44, 1, 44, 19 },
                    { 45, 1, 19, 45 },
                    { 46, 1, 45, 46 },
                    { 47, 1, 46, 47 },
                    { 48, 1, 47, 48 },
                    { 49, 1, 48, 49 },
                    { 50, 1, 49, 50 },
                    { 51, 1, 50, 51 },
                    { 52, 1, 51, 52 },
                    { 53, 1, 52, 53 },
                    { 54, 1, 54, 55 },
                    { 55, 1, 55, 56 },
                    { 56, 1, 56, 57 },
                    { 57, 1, 57, 58 },
                    { 58, 1, 58, 59 },
                    { 59, 1, 59, 60 },
                    { 60, 1, 60, 61 },
                    { 61, 1, 61, 62 },
                    { 62, 1, 62, 63 },
                    { 63, 1, 63, 64 },
                    { 64, 1, 64, 65 },
                    { 65, 1, 65, 66 },
                    { 66, 1, 66, 67 },
                    { 67, 1, 67, 68 },
                    { 68, 1, 68, 69 },
                    { 69, 1, 69, 70 },
                    { 70, 1, 70, 71 },
                    { 71, 1, 71, 43 },
                    { 72, 1, 43, 20 },
                    { 73, 1, 20, 72 },
                    { 74, 1, 72, 73 },
                    { 75, 1, 73, 74 },
                    { 76, 1, 74, 75 },
                    { 77, 1, 75, 76 },
                    { 78, 1, 76, 77 },
                    { 79, 1, 77, 78 },
                    { 80, 1, 78, 79 },
                    { 81, 1, 79, 80 },
                    { 82, 1, 74, 81 },
                    { 83, 1, 81, 82 },
                    { 84, 1, 82, 83 },
                    { 85, 1, 83, 84 },
                    { 86, 1, 84, 48 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Edges_FirstId",
                table: "Edges",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_Edges_SecondId",
                table: "Edges",
                column: "SecondId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edges");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
