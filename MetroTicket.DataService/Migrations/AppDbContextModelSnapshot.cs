﻿// <auto-generated />
using MetroTicket.DataService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MetroTicket.DataService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MetroTicket.Entities.DbSet.Edge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FirstId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecondId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FirstId");

                    b.HasIndex("SecondId");

                    b.ToTable("Edges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 1,
                            FirstId = 1,
                            SecondId = 2
                        },
                        new
                        {
                            Id = 2,
                            Cost = 1,
                            FirstId = 2,
                            SecondId = 3
                        },
                        new
                        {
                            Id = 3,
                            Cost = 1,
                            FirstId = 3,
                            SecondId = 4
                        },
                        new
                        {
                            Id = 4,
                            Cost = 1,
                            FirstId = 4,
                            SecondId = 5
                        },
                        new
                        {
                            Id = 5,
                            Cost = 1,
                            FirstId = 5,
                            SecondId = 6
                        },
                        new
                        {
                            Id = 6,
                            Cost = 1,
                            FirstId = 6,
                            SecondId = 7
                        },
                        new
                        {
                            Id = 7,
                            Cost = 1,
                            FirstId = 7,
                            SecondId = 8
                        },
                        new
                        {
                            Id = 8,
                            Cost = 1,
                            FirstId = 8,
                            SecondId = 9
                        },
                        new
                        {
                            Id = 9,
                            Cost = 1,
                            FirstId = 9,
                            SecondId = 10
                        },
                        new
                        {
                            Id = 10,
                            Cost = 1,
                            FirstId = 10,
                            SecondId = 11
                        },
                        new
                        {
                            Id = 11,
                            Cost = 1,
                            FirstId = 11,
                            SecondId = 12
                        },
                        new
                        {
                            Id = 12,
                            Cost = 1,
                            FirstId = 12,
                            SecondId = 13
                        },
                        new
                        {
                            Id = 13,
                            Cost = 1,
                            FirstId = 13,
                            SecondId = 14
                        },
                        new
                        {
                            Id = 14,
                            Cost = 1,
                            FirstId = 14,
                            SecondId = 15
                        },
                        new
                        {
                            Id = 15,
                            Cost = 1,
                            FirstId = 15,
                            SecondId = 16
                        },
                        new
                        {
                            Id = 16,
                            Cost = 1,
                            FirstId = 16,
                            SecondId = 17
                        },
                        new
                        {
                            Id = 17,
                            Cost = 1,
                            FirstId = 17,
                            SecondId = 18
                        },
                        new
                        {
                            Id = 18,
                            Cost = 1,
                            FirstId = 18,
                            SecondId = 19
                        },
                        new
                        {
                            Id = 19,
                            Cost = 1,
                            FirstId = 19,
                            SecondId = 20
                        },
                        new
                        {
                            Id = 20,
                            Cost = 1,
                            FirstId = 20,
                            SecondId = 21
                        },
                        new
                        {
                            Id = 21,
                            Cost = 1,
                            FirstId = 21,
                            SecondId = 22
                        },
                        new
                        {
                            Id = 22,
                            Cost = 1,
                            FirstId = 22,
                            SecondId = 23
                        },
                        new
                        {
                            Id = 23,
                            Cost = 1,
                            FirstId = 23,
                            SecondId = 24
                        },
                        new
                        {
                            Id = 24,
                            Cost = 1,
                            FirstId = 24,
                            SecondId = 25
                        },
                        new
                        {
                            Id = 25,
                            Cost = 1,
                            FirstId = 25,
                            SecondId = 26
                        },
                        new
                        {
                            Id = 26,
                            Cost = 1,
                            FirstId = 26,
                            SecondId = 27
                        },
                        new
                        {
                            Id = 27,
                            Cost = 1,
                            FirstId = 27,
                            SecondId = 28
                        },
                        new
                        {
                            Id = 28,
                            Cost = 1,
                            FirstId = 28,
                            SecondId = 29
                        },
                        new
                        {
                            Id = 29,
                            Cost = 1,
                            FirstId = 29,
                            SecondId = 30
                        },
                        new
                        {
                            Id = 30,
                            Cost = 1,
                            FirstId = 30,
                            SecondId = 31
                        },
                        new
                        {
                            Id = 31,
                            Cost = 1,
                            FirstId = 31,
                            SecondId = 32
                        },
                        new
                        {
                            Id = 32,
                            Cost = 1,
                            FirstId = 32,
                            SecondId = 33
                        },
                        new
                        {
                            Id = 33,
                            Cost = 1,
                            FirstId = 33,
                            SecondId = 34
                        },
                        new
                        {
                            Id = 34,
                            Cost = 1,
                            FirstId = 34,
                            SecondId = 35
                        },
                        new
                        {
                            Id = 35,
                            Cost = 1,
                            FirstId = 36,
                            SecondId = 37
                        },
                        new
                        {
                            Id = 36,
                            Cost = 1,
                            FirstId = 37,
                            SecondId = 38
                        },
                        new
                        {
                            Id = 37,
                            Cost = 1,
                            FirstId = 38,
                            SecondId = 39
                        },
                        new
                        {
                            Id = 38,
                            Cost = 1,
                            FirstId = 39,
                            SecondId = 40
                        },
                        new
                        {
                            Id = 39,
                            Cost = 1,
                            FirstId = 40,
                            SecondId = 41
                        },
                        new
                        {
                            Id = 40,
                            Cost = 1,
                            FirstId = 41,
                            SecondId = 42
                        },
                        new
                        {
                            Id = 41,
                            Cost = 1,
                            FirstId = 42,
                            SecondId = 22
                        },
                        new
                        {
                            Id = 42,
                            Cost = 1,
                            FirstId = 22,
                            SecondId = 43
                        },
                        new
                        {
                            Id = 43,
                            Cost = 1,
                            FirstId = 43,
                            SecondId = 44
                        },
                        new
                        {
                            Id = 44,
                            Cost = 1,
                            FirstId = 44,
                            SecondId = 19
                        },
                        new
                        {
                            Id = 45,
                            Cost = 1,
                            FirstId = 19,
                            SecondId = 45
                        },
                        new
                        {
                            Id = 46,
                            Cost = 1,
                            FirstId = 45,
                            SecondId = 46
                        },
                        new
                        {
                            Id = 47,
                            Cost = 1,
                            FirstId = 46,
                            SecondId = 47
                        },
                        new
                        {
                            Id = 48,
                            Cost = 1,
                            FirstId = 47,
                            SecondId = 48
                        },
                        new
                        {
                            Id = 49,
                            Cost = 1,
                            FirstId = 48,
                            SecondId = 49
                        },
                        new
                        {
                            Id = 50,
                            Cost = 1,
                            FirstId = 49,
                            SecondId = 50
                        },
                        new
                        {
                            Id = 51,
                            Cost = 1,
                            FirstId = 50,
                            SecondId = 51
                        },
                        new
                        {
                            Id = 52,
                            Cost = 1,
                            FirstId = 51,
                            SecondId = 52
                        },
                        new
                        {
                            Id = 53,
                            Cost = 1,
                            FirstId = 52,
                            SecondId = 53
                        },
                        new
                        {
                            Id = 54,
                            Cost = 1,
                            FirstId = 54,
                            SecondId = 55
                        },
                        new
                        {
                            Id = 55,
                            Cost = 1,
                            FirstId = 55,
                            SecondId = 56
                        },
                        new
                        {
                            Id = 56,
                            Cost = 1,
                            FirstId = 56,
                            SecondId = 57
                        },
                        new
                        {
                            Id = 57,
                            Cost = 1,
                            FirstId = 57,
                            SecondId = 58
                        },
                        new
                        {
                            Id = 58,
                            Cost = 1,
                            FirstId = 58,
                            SecondId = 59
                        },
                        new
                        {
                            Id = 59,
                            Cost = 1,
                            FirstId = 59,
                            SecondId = 60
                        },
                        new
                        {
                            Id = 60,
                            Cost = 1,
                            FirstId = 60,
                            SecondId = 61
                        },
                        new
                        {
                            Id = 61,
                            Cost = 1,
                            FirstId = 61,
                            SecondId = 62
                        },
                        new
                        {
                            Id = 62,
                            Cost = 1,
                            FirstId = 62,
                            SecondId = 63
                        },
                        new
                        {
                            Id = 63,
                            Cost = 1,
                            FirstId = 63,
                            SecondId = 64
                        },
                        new
                        {
                            Id = 64,
                            Cost = 1,
                            FirstId = 64,
                            SecondId = 65
                        },
                        new
                        {
                            Id = 65,
                            Cost = 1,
                            FirstId = 65,
                            SecondId = 66
                        },
                        new
                        {
                            Id = 66,
                            Cost = 1,
                            FirstId = 66,
                            SecondId = 67
                        },
                        new
                        {
                            Id = 67,
                            Cost = 1,
                            FirstId = 67,
                            SecondId = 68
                        },
                        new
                        {
                            Id = 68,
                            Cost = 1,
                            FirstId = 68,
                            SecondId = 69
                        },
                        new
                        {
                            Id = 69,
                            Cost = 1,
                            FirstId = 69,
                            SecondId = 70
                        },
                        new
                        {
                            Id = 70,
                            Cost = 1,
                            FirstId = 70,
                            SecondId = 71
                        },
                        new
                        {
                            Id = 71,
                            Cost = 1,
                            FirstId = 71,
                            SecondId = 43
                        },
                        new
                        {
                            Id = 72,
                            Cost = 1,
                            FirstId = 43,
                            SecondId = 20
                        },
                        new
                        {
                            Id = 73,
                            Cost = 1,
                            FirstId = 20,
                            SecondId = 72
                        },
                        new
                        {
                            Id = 74,
                            Cost = 1,
                            FirstId = 72,
                            SecondId = 73
                        },
                        new
                        {
                            Id = 75,
                            Cost = 1,
                            FirstId = 73,
                            SecondId = 74
                        },
                        new
                        {
                            Id = 76,
                            Cost = 1,
                            FirstId = 74,
                            SecondId = 75
                        },
                        new
                        {
                            Id = 77,
                            Cost = 1,
                            FirstId = 75,
                            SecondId = 76
                        },
                        new
                        {
                            Id = 78,
                            Cost = 1,
                            FirstId = 76,
                            SecondId = 77
                        },
                        new
                        {
                            Id = 79,
                            Cost = 1,
                            FirstId = 77,
                            SecondId = 78
                        },
                        new
                        {
                            Id = 80,
                            Cost = 1,
                            FirstId = 78,
                            SecondId = 79
                        },
                        new
                        {
                            Id = 81,
                            Cost = 1,
                            FirstId = 79,
                            SecondId = 80
                        },
                        new
                        {
                            Id = 82,
                            Cost = 1,
                            FirstId = 74,
                            SecondId = 81
                        },
                        new
                        {
                            Id = 83,
                            Cost = 1,
                            FirstId = 81,
                            SecondId = 82
                        },
                        new
                        {
                            Id = 84,
                            Cost = 1,
                            FirstId = 82,
                            SecondId = 83
                        },
                        new
                        {
                            Id = 85,
                            Cost = 1,
                            FirstId = 83,
                            SecondId = 84
                        },
                        new
                        {
                            Id = 86,
                            Cost = 1,
                            FirstId = 84,
                            SecondId = 48
                        });
                });

            modelBuilder.Entity("MetroTicket.Entities.DbSet.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Helwan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ain Helwan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Helwan University"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Wadi Hof"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hadayek Helwan"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Elmasraa"
                        },
                        new
                        {
                            Id = 7,
                            Name = "ura El-Esmant"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kozzika"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tora El-Balad"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sakanat El-Maadi"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Maadi"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Hadayeq El-Maadi"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Dar El-Salam"
                        },
                        new
                        {
                            Id = 14,
                            Name = "El-Zahraa"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Mar Girgis"
                        },
                        new
                        {
                            Id = 16,
                            Name = "El-Malek El-Saleh"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Al-Sayeda Zeinab"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Saad Zaghloul"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Sadat"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Nasser"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Orabi"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Al-Shohadaa"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Ghamra"
                        },
                        new
                        {
                            Id = 24,
                            Name = "El-Demerdash"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Manshiet El-Sadr"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Kobri El-Qobba"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Hammamat El-Qobba"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Saray El-Qobba"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Hadayeq El-Zaitoun"
                        },
                        new
                        {
                            Id = 30,
                            Name = "elmeyet El-Zaitoun"
                        },
                        new
                        {
                            Id = 31,
                            Name = "El-Matareyya"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Ain Shams"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Ezbet El-Nakhl"
                        },
                        new
                        {
                            Id = 34,
                            Name = "El-Marg"
                        },
                        new
                        {
                            Id = 35,
                            Name = "New Marg"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Shubra Al Khaimah"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Koliet El-Zeraa"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Mezallat"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Khalafawy"
                        },
                        new
                        {
                            Id = 40,
                            Name = "St. Teresa"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Rod El-Farag"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Masarra"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Attaba"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Mohamed Naguib"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Opera"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Dokki"
                        },
                        new
                        {
                            Id = 47,
                            Name = "El Bohoth"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Cairo University"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Faisal"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Giza"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Omm El-Masryeen"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Sakiat Mekky"
                        },
                        new
                        {
                            Id = 53,
                            Name = "El Monib"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Adly Mansour"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Haykestep"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Omar Ibn El Khattab"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Qubaa"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Hesham Barakat"
                        },
                        new
                        {
                            Id = 59,
                            Name = "El Nozha"
                        },
                        new
                        {
                            Id = 60,
                            Name = "El Shams Club"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Alf Masken"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Heliopolis"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Haroun"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Al-Ahram"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Koleyet El-Banat"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Stadium"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Abbassiya"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Fair Zone"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Abdou Pasha"
                        },
                        new
                        {
                            Id = 70,
                            Name = "El-Geish"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Bab El Shaariya"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Maspero"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Safaa Hijazy"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Kit-Kat"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Sudan"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Imbaba"
                        },
                        new
                        {
                            Id = 77,
                            Name = "El-Bohy"
                        },
                        new
                        {
                            Id = 78,
                            Name = "El-Qawmia"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Ring Road"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Rod El Farag Corridor"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Tawfikia"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Wadi El Nile"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Gamet El Dowal"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Boulak El Dakrour"
                        });
                });

            modelBuilder.Entity("MetroTicket.Entities.DbSet.Edge", b =>
                {
                    b.HasOne("MetroTicket.Entities.DbSet.Station", "FirstStation")
                        .WithMany()
                        .HasForeignKey("FirstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MetroTicket.Entities.DbSet.Station", "SecondStation")
                        .WithMany()
                        .HasForeignKey("SecondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstStation");

                    b.Navigation("SecondStation");
                });
#pragma warning restore 612, 618
        }
    }
}
