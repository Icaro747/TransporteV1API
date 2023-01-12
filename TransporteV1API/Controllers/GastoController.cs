using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GastoController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public GastoController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetGasto()
        {
            return Ok(_context.Gastos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGastoPorId(Guid id)
        {
            Gasto gasto = _context.Gastos.FirstOrDefault(x => x.Id == id);

            return gasto != null ? Ok(gasto) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaGasto([FromBody] CreateGasto GastoDto)
        {
            Gasto gasto = _mapper.Map<Gasto>(GastoDto);

            _context.Gastos.Add(gasto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGastoPorId), new { id = gasto.Id }, new { id = gasto.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaGasto(Guid id, [FromBody] UpdataGasto NovoGasto)
        {
            Gasto gasto = _context.Gastos.FirstOrDefault(x => x.Id == id);

            if (gasto == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoGasto, gasto);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
