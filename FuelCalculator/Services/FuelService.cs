using FuelCalculator.Application;
using System;

namespace FuelCalculator.Services
{
    public class FuelService : IFuelService
    {
        private static double GallonsUsed(int miles, double mpg) => miles / mpg;
        public double FuelCost(int miles, double mpg, int cost)
        {
            if (miles < 0) throw new ArgumentOutOfRangeException(nameof(miles), miles, "Miles must be 0 or greater");
            if (mpg <= 0) throw new ArgumentOutOfRangeException(nameof(mpg), mpg, "mpg must be greter than 0");
            if (cost < 0) throw new ArgumentOutOfRangeException(nameof(cost), cost, "Miles must be 0 or greater");

            var gallons = GallonsUsed(miles, mpg);
            return (MetricConverter.GallonsToLitres(gallons) * cost) / 100;
        }

        public double LitresUsed(int miles, double mpg)
        {
            if (miles < 0) throw new ArgumentOutOfRangeException(nameof(miles), miles, "Miles must be 0 or greater");
            if (mpg <= 0) throw new ArgumentOutOfRangeException(nameof(mpg), mpg, "mpg must be greter than 0");

            var gallons = GallonsUsed(miles, mpg);
            return MetricConverter.GallonsToLitres(gallons);
        }

        public double NumberOfTanks(int miles, double mpg, int tankSizeLitres)
        {
            if (miles < 0) throw new ArgumentOutOfRangeException(nameof(miles), miles, "Miles must be 0 or greater");
            if (mpg <= 0) throw new ArgumentOutOfRangeException(nameof(mpg), mpg, "mpg must be greter than 0");
            if (tankSizeLitres <= 0) throw new ArgumentOutOfRangeException(nameof(tankSizeLitres), tankSizeLitres, "tankSizeLitres must be greter than 0");

            var gallons = GallonsUsed(miles, mpg);
            var tanks = MetricConverter.GallonsToLitres(gallons) / tankSizeLitres;
            return tanks;
        }
    }
}
