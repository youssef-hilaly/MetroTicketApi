using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.Entities.Data
{
    public class Metro
    {
        public static Dictionary<string, List<string>> lines = new Dictionary<string, List<string>> {
            {
                "Line 1",
                [
                    "Helwan",
                    "Ain Helwan",
                    "Helwan University",
                    "Wadi Hof",
                    "Hadayek Helwan",
                    "Elmasraa",
                    "ura El-Esmant",
                    "Kozzika",
                    "Tora El-Balad",
                    "Sakanat El-Maadi",
                    "Maadi",
                    "Hadayeq El-Maadi",
                    "Dar El-Salam",
                    "El-Zahraa",
                    "Mar Girgis",
                    "El-Malek El-Saleh",
                    "Al-Sayeda Zeinab",
                    "Saad Zaghloul",
                    "Sadat",
                    "Nasser",
                    "Orabi",
                    "Al-Shohadaa",
                    "Ghamra",
                    "El-Demerdash",
                    "Manshiet El-Sadr",
                    "Kobri El-Qobba",
                    "Hammamat El-Qobba",
                    "Saray El-Qobba",
                    "Hadayeq El-Zaitoun",
                    "elmeyet El-Zaitoun",
                    "El-Matareyya",
                    "Ain Shams",
                    "Ezbet El-Nakhl",
                    "El-Marg",
                    "New Marg"
                ]
            },
            {
                "Line2",
                [
                    "Shubra Al Khaimah",
                    "Koliet El-Zeraa",
                    "Mezallat",
                    "Khalafawy",
                    "St. Teresa",
                    "Rod El-Farag",
                    "Masarra",
                    "Al-Shohadaa",
                    "Attaba",
                    "Mohamed Naguib",
                    "Sadat",
                    "Opera",
                    "Dokki",
                    "El Bohoth",
                    "Cairo University",
                    "Faisal",
                    "Giza",
                    "Omm El-Masryeen",
                    "Sakiat Mekky",
                    "El Monib"
                    ]
            },
            {
                "Line3",
                [
                    "Adly Mansour",
                    "Haykestep",
                    "Omar Ibn El Khattab",
                    "Qubaa",
                    "Hesham Barakat",
                    "El Nozha",
                    "El Shams Club",
                    "Alf Masken",
                    "Heliopolis",
                    "Haroun",
                    "Al-Ahram",
                    "Koleyet El-Banat",
                    "Stadium",
                    "Abbassiya",
                    "Fair Zone",
                    "Abdou Pasha",
                    "El-Geish",
                    "Bab El Shaariya",
                    "Attaba",
                    "Nasser",
                    "Maspero",
                    "Safaa Hijazy",
                    "Kit-Kat",
                    "Sudan",
                    "Imbaba",
                    "El-Bohy",
                    "El-Qawmia",
                    "Ring Road",
                    "Rod El Farag Corridor",
                ]
            },
            {
                "Line 3 Cairo University branch",
                [
                    "Kit-Kat",
                    "Tawfikia",
                    "Wadi El Nile",
                    "Gamet El Dowal",
                    "Boulak El Dakrour",
                    "Cairo University",
                ]
            },
        };
    }
}
