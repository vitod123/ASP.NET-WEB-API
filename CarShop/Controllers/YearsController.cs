using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Core.Specifications;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IYearsService = Core.Interfaces.IYearsService;

namespace CarShop.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class YearsController : ControllerBase
    {
        private readonly IYearsService years;

        public YearsController(IYearsService years)
        {
            this.years = years;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await years.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await years.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpGet("order")]
        public async Task<IActionResult> GetOrder()
        {
            var item = await years.Order();
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] YearDto yearDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await years.Create(yearDto);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] YearDto yearDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await years.Edit(yearDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await years.Delete(id);

            return Ok();
        }
    }
}
