using System;
using Xunit;

namespace FuelCalculator.Tests
{
    public class FuelService_CostShould : FuelServiceTestBase
    {
        [Fact]
        public void CostShould_Input454Mi100Mpg100Pence_Return454()
        {
            var result = fuelService.FuelCost(454, 454, 100);
            Assert.Equal(4.54, result);
        }
        [Fact]
        public void CostShould_Input454Mi100Mpg0Pence_Return0()
        {
            var result = fuelService.FuelCost(454, 454, 0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CostShould_InputMilesLessThan0_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.FuelCost(-1, 454, 0));
        }

        [Fact]
        public void CostShould_InputMpg0_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.FuelCost(88, 0, 0));
        }

        [Fact]
        public void CostShould_InputMpgLessThan0_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.FuelCost(1, -1, 0));
        }

        [Fact]
        public void CostShould_InputCostLessThan0_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.FuelCost(1, 11, -1));
        }
    }
}
