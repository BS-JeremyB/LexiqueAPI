using Lexique.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lexique.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LexiqueController : ControllerBase
    {
        private readonly DataContext _context;

        public LexiqueController(DataContext context)
        {
            _context = context;
        }

        // GET: api/lexique/randomword
        [HttpGet("randomword")]
        public async Task<ActionResult<string>> GetRandomWord()
        {
            var word = await _context.Lexiques
                .Where(l => l.Nblettres <= 8 && l.Cgram == "NOM")
                .OrderBy(r => Guid.NewGuid())
                .Select(l => l.Ortho)
                .FirstOrDefaultAsync();

            if (word == null)
            {
                return NotFound("Aucun mot ne correspond aux critères.");
            }

            return Ok(word.ToUpper());
        }

        // GET: api/lexique/verify?word=mot
        [HttpGet("verify")]
        public async Task<ActionResult<bool>> VerifyWord([FromQuery] string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return BadRequest("Le paramètre 'word' est requis.");
            }

            bool exists = await _context.Lexiques
                .AnyAsync(l => l.Ortho == word);

            return Ok(exists);
        }
    }
}

