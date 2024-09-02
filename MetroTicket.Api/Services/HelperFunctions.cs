using MetroTicket.Entities.Constants;
using MetroTicket.Entities.DbSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroTicket.DataService.Data;

namespace MetroTickets.Helpers
{
    public class HelperFunctions
    {
        // Get Input
        public static int GetInputStation(string s)
        {
            while (true)
            {
                Console.WriteLine(s);
                string? input = Console.ReadLine();

                if (input == null || !int.TryParse(input, out int stationNumber))
                {
                    Console.WriteLine(Constats.ENTER_INVALID_NUMBER);
                    continue;
                }

                if(!Graph.IsExist(stationNumber))
                {
                    Console.WriteLine(Constats.NO_STATION);
                    continue;
                }
                return stationNumber;
            }
        }

        // Calculate the Price 
        public static int CalcPrice(int distance)
        {
            if(distance <= 0)
            {
                throw new ArgumentException("Negative or Zero Distance", "distance");
            }

            if (distance <= Constats.FIRST_TICKET_LIMIT)
            {
                return Constats.FIRST_TICKET_PRICE;
            }
            else if (distance >= Constats.FIRST_TICKET_LIMIT && distance <= Constats.SECOND_TICKET_LIMIT)
            {
                return Constats.SECOND_TICKET_PRICE;
            }
            else if (distance >= Constats.SECOND_TICKET_LIMIT && distance <= Constats.THIRD_TICKET_LIMIT)
            {
                return Constats.THIRD_TICKET_PRICE;
            }
            else
            {
                return Constats.FOURTH_TICKET_PRICE;
            }
        }


    }
}
