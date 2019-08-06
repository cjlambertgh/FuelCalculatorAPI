using FuelCalculator.Services;

namespace FuelCalculator.Tests
{
    public class FuelServiceTestBase
    {
        protected readonly FuelService fuelService;
        public FuelServiceTestBase()
        {
            fuelService = new FuelService();
        }
    }
}
