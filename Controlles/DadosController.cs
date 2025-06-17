using ApiLaboratorial.appDbContext;
using ApiLaboratorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiLaboratorial.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DadosController(AppDbContext context)
        {
            _context = context;
        }
        [Route("sensores/temperaturas")]
        [HttpGet]
        public async Task<IActionResult> listarDados()
        {
            try
            {
                var dados = _context.Sensor.ToList();
                return Ok(dados);
            }
            catch (Exception)
            {
                return NotFound();
            }
;
        }

        [Route("sensor")]
        [HttpPost]
        public async Task<IActionResult> adicionarDados (Sensor sensor)
        {
            try
            {
                await _context.Sensor.AddAsync(sensor);
                await _context.SaveChangesAsync();

                return Ok(sensor);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
