using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISemana9.Model;
using Microsoft.AspNetCore.Mvc;

namespace APISemana9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : ControllerBase
    {
        private readonly SemanaContext _context;

        public SemanaController(SemanaContext context)
        {
            _context = context;
        }
        

        [HttpPost]
        public IActionResult Post(SemanaModel semana)
        {
            if (semana.ID > 0)
            {
                return BadRequest("ID não deve ser definido para um novo item.");
            }

            _context?.Semana?.Add(semana);
            _context?.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = semana.ID }, semana);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var semana = _context?.Semana?.Find(id);

            if (semana == null)
            {
                return NotFound();
            }

            _context?.Semana?.Remove(semana);
            _context?.SaveChanges();

            return NoContent();
        }
        [HttpGet]
        public ActionResult<IEnumerable<SemanaModel>> GetAll()
        {
            var semanas = _context?.Semana?.ToList();
            if (semanas == null)
            {
                return NotFound();
            }
            return semanas;
        }
        [HttpGet("{id}")]
        public ActionResult<SemanaModel> GetById(int id)
        {
            var semana = _context?.Semana?.Find(id);
            if (semana == null)
            {
                return NotFound();
            }
            return semana;
        }



    }
}