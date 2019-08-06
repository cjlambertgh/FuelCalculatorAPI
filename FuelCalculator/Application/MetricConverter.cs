using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuelCalculator.Application
{
    public static class MetricConverter
    {
        const double _ukLitresPerGallon = 4.54;
        const double _kmsToMiles = 1.60934;
        public static double GallonsToLitres(double gallons) => gallons * _ukLitresPerGallon;
        public static double LitresToGallons(double litres) => litres / _ukLitresPerGallon;
        public static double MilesToKms(double miles) => miles * _kmsToMiles;
        public static double KmsToMiles(double kms) => kms / _kmsToMiles;
    }
}
