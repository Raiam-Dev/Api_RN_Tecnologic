using ApiLaboratorial.appDbContext;
using ApiLaboratorial.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiLaboratorial.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ValuesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post(TabelaTeste tabela)
        {
            try
            {
                await _context.TabelaTestes.AddAsync(tabela);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception erro)
            {
                return NotFound(erro);
            }
        }
    }
}
