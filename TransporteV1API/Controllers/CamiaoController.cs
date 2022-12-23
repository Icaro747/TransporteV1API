using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Modals;
using TransporteV1API.Data;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CamiaoController: ControllerBase
    {
        private TransporteContext _context;

        public CamiaoController(TransporteContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarCamiao([FromBody] Camiao camiaoDto)
        {
            Camiao camiao = new Camiao
            {
                Name = camiaoDto.Name,
                Placa = camiaoDto.Placa,
                Tipo = camiaoDto.Tipo,
                Discricao = camiaoDto.Discricao,
            };

            _context.Camiaos.Add(camiao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCamiaoPorId), new { Id = camiao.Id }, camiao);
        }

        [HttpGet]
        public IActionResult GetCamias() {
            return Ok(_context.Camiaos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCamiaoPorId(int id)
        {
            Camiao camiao = _context.Camiaos.FirstOrDefault(camiao => camiao.Id == id);
            
            return camiao != null ? Ok(camiao) : NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCamiao(int id, [FromBody] Camiao NovoCamiao)
        {
            Camiao camiao = _context.Camiaos.FirstOrDefault(camiao => camiao.Id == id);
            if(camiao == null)
            {
                return NotFound();
            }
            else
            {
                camiao.Name= NovoCamiao.Name;
                camiao.Placa= NovoCamiao.Placa;
                camiao.Tipo= NovoCamiao.Tipo;
                camiao.Discricao= NovoCamiao.Discricao;
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCamiao(int id)
        {
            Camiao camiao = _context.Camiaos.FirstOrDefault(camiao => camiao.Id == id);
            if (camiao == null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(camiao);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
