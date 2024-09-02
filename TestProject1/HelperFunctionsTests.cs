using MetroTicket.Entities.Constants;
using MetroTickets.Helpers;
using TestProject1.Constants;
namespace MetroTickets.Tests
{
    public class HelperFunctionsTests
    {

        [Theory]
        [InlineData(Constats.NEGATIVE_DISTANCE)]
        [InlineData(Constats.ZERO_DISTANCE)]
        public void CalcPrice_Exeption(int distance)
        {
                Assert.Throws<ArgumentException>(() => HelperFunctions.CalcPrice(distance));
        }

        [Theory]
        [InlineData(Constats.MINIMUM_DISTANCE, Constats.FIRST_TICKET_PRICE)]
        [InlineData(Constats.FIRST_TICKET_LIMIT, Constats.FIRST_TICKET_PRICE)]

        [InlineData(Constats.FIRST_TICKET_LIMIT + Constats.MINIMUM_DISTANCE, Constats.SECOND_TICKET_PRICE)]
        [InlineData(Constats.SECOND_TICKET_LIMIT, Constats.SECOND_TICKET_PRICE)]
        
        [InlineData(Constats.SECOND_TICKET_LIMIT + Constats.MINIMUM_DISTANCE, Constats.THIRD_TICKET_PRICE)]
        [InlineData(Constats.THIRD_TICKET_LIMIT, Constats.THIRD_TICKET_PRICE)]
        
        [InlineData(Constats.THIRD_TICKET_LIMIT + Constats.MINIMUM_DISTANCE, Constats.FOURTH_TICKET_PRICE)]
        [InlineData(Constats.FOURTH_TICKET_LIMIT, Constats.FOURTH_TICKET_PRICE)]
        public void CalcPrice_Distance(int distance, int expected)
        {
                int actual = HelperFunctions.CalcPrice(distance);
                Assert.Equal(expected, actual);
        }
    }
}