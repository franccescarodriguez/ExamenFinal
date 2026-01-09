using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenFinal.Data;
using ExamenFinal.Models;

namespace ExamenFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagosController : ControllerBase
    {
        private readonly ExamenFinalContext _context;

        public PagosController(ExamenFinalContext context)
        {
            _context = context;
        }

        // GET: api/pagos
        [HttpGet]
        public async Task<IActionResult> GetPagos()
        {
            var pagos = await _context.Pagos.ToListAsync();
            return Ok(pagos);
        }

        // POST: api/pagos
        [HttpPost]
        public async Task<IActionResult> PostPago(Pago pago)
        {
            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();
            return Ok(pago);
        }
    }
}
