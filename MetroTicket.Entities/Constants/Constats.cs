using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.Entities.Constants
{
    public class Constats
    {
        public const int STATIONS_COUNT = 35;
        public const int START_STATION = 1;

        public const int FIRST_TICKET_PRICE = 8;
        public const int SECOND_TICKET_PRICE = 10;
        public const int THIRD_TICKET_PRICE = 15;
        public const int FOURTH_TICKET_PRICE = 20;


        public const int FIRST_TICKET_LIMIT = 8;
        public const int SECOND_TICKET_LIMIT = 16;
        public const int THIRD_TICKET_LIMIT = 23;
        public const int FOURTH_TICKET_LIMIT = int.MaxValue;


        public const string ENTER_CURRENT_STATION = "Enter the current station number";
        public const string ENTER_DESTINATION_STATION = "Enter the destination station number";
        public const string ENTER_INVALID_NUMBER = "Enter valid number";
        public const string NO_STATION = "there is no station with number";
        public const string NO_PATH = "there is no path between stations";
        public const string SHOULD_PAY = "you should pay";
        public const string EGP = "EGP";
    }
}
