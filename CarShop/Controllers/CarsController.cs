using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService carsService;

        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await carsService.GetAll());
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await carsService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{orderBy:alpha}")]
        public async Task<IActionResult> GetOrder([FromRoute] string orderBy)
        {   
            if(orderBy.Split(' ').Length > 1)
            {
                string[] orderByStr = orderBy.Split(' ');
                orderBy = "";
                for (int i = 0; i < orderByStr.Length; i++)
                {
                    orderBy += orderByStr[i];
                }
            }
            var item = await carsService.Order(orderBy.ToLower());
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CarDto car)
        {
            if (!ModelState.IsValid) return BadRequest();

            await carsService.Create(car);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] CarDto car)
        {
            if (!ModelState.IsValid) return BadRequest();

            await carsService.Edit(car);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await carsService.Delete(id);

            return Ok();
        }
    }
}
