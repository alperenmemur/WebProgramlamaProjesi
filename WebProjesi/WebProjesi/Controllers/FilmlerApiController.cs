using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProjesi.Data;
using WebProjesi.Models;

namespace WebProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmlerApiController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public FilmlerApiController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/FilmlerApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilmler()
        {
            return await _context.Filmler.ToListAsync();
        }

        // GET: api/FilmlerApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilm(int id)
        {
            var film = await _context.Filmler.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return film;
        }

        // PUT: api/FilmlerApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilm(int id, Film film)
        {
            if (id != film.Id)
            {
                return BadRequest();
            }

            _context.Entry(film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FilmlerApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Film>> PostFilm(Film film)
        {
            _context.Filmler.Add(film);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilm", new { id = film.Id }, film);
        }

        // DELETE: api/FilmlerApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilm(int id)
        {
            var film = await _context.Filmler.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }

            _context.Filmler.Remove(film);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmExists(int id)
        {
            return _context.Filmler.Any(e => e.Id == id);
        }
    }
}
