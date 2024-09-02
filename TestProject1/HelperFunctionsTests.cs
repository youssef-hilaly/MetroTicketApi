using MetroTicket.Entities.Constants;
using MetroTickets.Helpers;
using TestProject1.Constants;
namespace MetroTickets.Tests
{
    public class HelperFunctionsTests
    {
        //  Invalid Distance
        [Fact]
        public void CalcPrice_NegativeDistance_ThrowArgumentException()
        {
            int distance = HelperFunctionsConstants.NEGATIVE_DISTANCE;

            Func<int, int> func = (d) => HelperFunctions.CalcPrice(d);

            Assert.Throws<ArgumentException>(() => HelperFunctions.CalcPrice(distance));
        }

        [Fact]
        public void CalcPrice_ZeroDistance_ThrowArgumentException()
        {
            int distance = HelperFunctionsConstants.ZERO_DISTANCE;

            Func<int, int> func = (d) => HelperFunctions.CalcPrice(d);

            Assert.Throws<ArgumentException>(() => HelperFunctions.CalcPrice(distance));
        }

        // First Ticket
        [Fact]
        public void CalcPrice_MinFirstTicketDistance_FirstTicketPrice()
        {
            int distance = HelperFunctionsConstants.MINIMUM_DISTANCE;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.FIRST_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalcPrice_MaxFirstTicketDistance_FirstTicketPrice()
        {
            int distance = Constats.FIRST_TICKET_LIMIT;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.FIRST_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        // Second Ticket
        [Fact]
        public void CalcPrice_MinSecondTicketDistance_SecondTicketPrice()
        {
            int distance = Constats.FIRST_TICKET_LIMIT + HelperFunctionsConstants.MINIMUM_DISTANCE;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.SECOND_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalcPrice_MaxSecondTicketDistance_SecondTicketPrice()
        {
            int distance = Constats.SECOND_TICKET_LIMIT;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.SECOND_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        // Third Ticket
        [Fact]
        public void CalcPrice_MinThirdTicketDistance_ThirdTicketPrice()
        {
            int distance = Constats.SECOND_TICKET_LIMIT + HelperFunctionsConstants.MINIMUM_DISTANCE;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.THIRD_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalcPrice_MaxThirdTicketDistance_ThirdTicketPrice()
        {
            int distance = Constats.THIRD_TICKET_LIMIT;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.THIRD_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        // Fourth Ticket
        [Fact]
        public void CalcPrice_MinFourthTicketDistance_FourthTicketPrice()
        {
            int distance = Constats.THIRD_TICKET_LIMIT + HelperFunctionsConstants.MINIMUM_DISTANCE;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.FOURTH_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalcPrice_MaxFourthTicketDistance_FourthTicketPrice()
        {
            int distance = Constats.FOURTH_TICKET_LIMIT;

            int actual = HelperFunctions.CalcPrice(distance);

            int expected = Constats.FOURTH_TICKET_PRICE;

            Assert.Equal(expected, actual);
        }
    }
}