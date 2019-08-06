using System;
using Xunit;

namespace FuelCalculator.Tests
{
    public class FuelService_LitresUsedShould : FuelServiceTestBase
    {
        [Fact]
        public void LitresUsedShould_Input1Mi1Mpg_Return4Point54()
        {
            var result = fuelService.LitresUsed(1,1);
            Assert.Equal(4.54, result);
        }

        [Fact]
        public void LitresUsedShould_InputNegativeMiles_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.LitresUsed(-1, 1));
        }

        [Fact]
        public void LitresUsedShould_Input0Mpg_ThrowsArgException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fuelService.LitresUsed(1, 0));
        }
    }
}
