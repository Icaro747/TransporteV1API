using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeguroController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public SeguroController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSeguro()
        {
            return Ok(_context.Seguros);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSeguroPorId(Guid id)
        {
            Seguro seguro = _context.Seguros.FirstOrDefault(x => x.Id == id);

            return seguro != null ? Ok(seguro) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaSeguro([FromBody] CreateSeguro SeguroDto)
        {
            Seguro seguro = _mapper.Map<Seguro>(SeguroDto);

            _context.Seguros.Add(seguro);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSeguroPorId), new { id = seguro.Id }, new { id = seguro.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaSeguro(Guid id, [FromBody] UpdataSeguro NovoSeguro)
        {
            Seguro seguro = _context.Seguros.FirstOrDefault(x => x.Id == id);

            if (seguro == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoSeguro, seguro);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
