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
    public class EnginesController : ControllerBase
    {
        private readonly IEnginesService enginesService;

        public EnginesController(IEnginesService enginesService)
        {
            this.enginesService = enginesService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await enginesService.GetAll());
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await enginesService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{orderBy:alpha}")]
        public async Task<IActionResult> GetOrder([FromRoute] string orderBy)
        {
            if (orderBy.Split(' ').Length > 1)
            {
                string[] orderByStr = orderBy.Split(' ');
                orderBy = "";
                for (int i = 0; i < orderByStr.Length; i++)
                {
                    orderBy += orderByStr[i];
                }
            }
            var item = await enginesService.Order(orderBy.ToLower());
            if (item == null) return NotFound();

            return Ok(item);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EngineDto engineDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await enginesService.Create(engineDto);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] EngineDto engineDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await enginesService.Edit(engineDto);

            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await enginesService.Delete(id);

            return Ok();
        }
    }
}
