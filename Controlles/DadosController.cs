using ApiLaboratorial.appDbContext;
using ApiLaboratorial.Models;
using Microsoft.AspNetCore.Mvc;

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
        [Route("usuarios")]
        [HttpGet]
        public IActionResult Usuarios()
        {
            var usuarios = new List<object>
            { 
                new { Id = 1, Nome = "João Silva", Email = "joao@example.com" },
                new { Id = 2, Nome = "Maria Oliveira", Email = "maria@example.com" },
                new { Id = 3, Nome = "Carlos Souza", Email = "carlos@example.com" }
            };

            return Ok(usuarios);
        }

    }
}
