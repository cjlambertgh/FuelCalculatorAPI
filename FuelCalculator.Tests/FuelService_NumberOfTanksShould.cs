using System;
using Xunit;

namespace FuelCalculator.Tests
{
    public class FuelService_NumberOfTanksShould : FuelServiceTestBase
    {
        [Fact]
        public void NumberOfTanksShould_Input100Mi100Mpg100Pence_Return454()
        {
            var result = fuelService.NumberOfTanks(100, 100, 1);
            Assert.Equal(4.54, result);
        }

        [Fact]
        public void LitresUsedShould_InputNegativeMiles_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.NumberOfTanks(-1, 10, 1));
        }

        [Fact]
        public void LitresUsedShould_Input0Mpg_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.NumberOfTanks(1, 0, 23));
        }

        [Fact]
        public void LitresUsedShould_InputNegativeTankSize_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.NumberOfTanks(1, 10, -1));
        }
    }
}
