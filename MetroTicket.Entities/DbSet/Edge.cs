using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.Entities.DbSet
{
    public class Edge
    {
        public int Id { get; set; }

        [ForeignKey(nameof(FirstStation))]
        public int FirstId { get; set; }
        public Station FirstStation { get; set; }


        [ForeignKey(nameof(SecondStation))]
        public int SecondId { get; set; }
        public Station SecondStation { get; set; }

        public int Cost { get; set; } = 1;

    }
}
