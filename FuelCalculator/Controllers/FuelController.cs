using System;
using FuelCalculator.Model;
using FuelCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace FuelCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService _fuelService;

        public FuelController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }

        [HttpGet]
        public ActionResult Cost(int miles, int mpg, int litreCost)
        {
            try
            {
                var cost = _fuelService.FuelCost(miles, mpg, litreCost);
                return Ok(cost.ToString("C2"));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        public ActionResult Cost([FromBody]CostRequest request)
        {
            try
            {
                var cost = _fuelService.FuelCost(request.Miles, request.MilesPerGallon, request.LitreCostPence);
                return Ok(cost.ToString("C2"));
            }
            catch (ArgumentOutOfRangeException ex)
            {

                return BadRequest(ex.Message);
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
            
        }
    }
}