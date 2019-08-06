using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuelCalculator.Model
{
    public class CostRequest
    {
        public int Miles { get; set; }
        public int MilesPerGallon { get; set; }
        public int LitreCostPence { get; set; }
    }
}
