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
    public class MakesController : ControllerBase
    {
        private readonly IMakesService makesService;

        public MakesController(IMakesService makesService)
        {
            this.makesService = makesService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await makesService.GetAll());
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await makesService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("order")]
        public async Task<IActionResult> GetOrder()
        {
            var item = await makesService.Order();
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MakeDto make)
        {
            if (!ModelState.IsValid) return BadRequest();

            await makesService.Create(make);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] MakeDto make)
        {
            if (!ModelState.IsValid) return BadRequest();

            await makesService.Edit(make);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await makesService.Delete(id);

            return Ok();
        }
    }
}
