using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_com_ASP.NETCore.Data;
using API_com_ASP.NETCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace API_com_ASP.NETCore.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private DataContext dc;

        public PessoasController(DataContext context)
        {
            this.dc = context;
        }
        [HttpPost("api")]
        public async Task<ActionResult> cadastar([FromBody] Pessoas p)
        {
            dc.pessoas?.Add(p);
            await dc.SaveChangesAsync();

            return Created("Objeto pessoa", p);
        }


        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dados = await dc.pessoas.ToListAsync();
            return Ok(dados);
        }        
        
        [HttpGet("api/{id}")]
        public Pessoas filtrar(int? id)
        {
            Pessoas p = dc.pessoas.Find(id);
            return p;
        }

        [HttpPut("api")]
        public async Task<ActionResult> editar([FromBody] Pessoas p)
        {
            dc.pessoas?.Update(p);
            await dc.SaveChangesAsync();

            return Ok(p);
        }        
        
        [HttpDelete("api/{id}")]
        public async Task<ActionResult> remover(int id)
        {
            Pessoas p = filtrar(id);
            if (p == null){
                return NotFound();
            }
            else {
                dc.pessoas?.Remove(p);
                await dc.SaveChangesAsync();
                return Ok(p);
            }
            await dc.SaveChangesAsync();

            return Ok(p);
        }
    }
}