﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using szamnegyes3.Models;

namespace szamnegyes3.Controllers
{
    [Route("api/fours")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private AdatbContext context = new();
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await context.Szamnegyes.ToListAsync());
        }
        [HttpGet("/{id}")]
        public async Task<IActionResult> GetByid(Guid id)
        {
            return Ok(await context.Szamnegyes.FirstOrDefaultAsync(s=>s.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromBody] int[] szamok)
        {
            if (szamok.Length!=4)
            {
                return BadRequest("Invalid data");
            }
            if (context.Szamnegyes.Where(s=>s.Szamok==szamok).Count()!=0)
            {
                return BadRequest("Már van");
            }
            Szamnegye szamnegye = new Szamnegye();
            szamnegye.Id = Guid.NewGuid();
            szamnegye.Szamok=szamok;
            await context.Szamnegyes.AddAsync(szamnegye);
            await context.SaveChangesAsync();
            return Ok(szamnegye);
        }
    }
}
