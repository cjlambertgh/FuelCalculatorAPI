namespace FuelCalculator.Services
{
    public interface IFuelService
    {
        double FuelCost(int miles, double mpg, int cost);
        double LitresUsed(int miles, double mpg);
        double NumberOfTanks(int miles, double mpg, int tankSizeLitres);
    }
}