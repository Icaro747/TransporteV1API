using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreteController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public FreteController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFrete()
        {
            return Ok(_context.Fretes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFretePorId(Guid id)
        {
            Frete frete = _context.Fretes.FirstOrDefault(x => x.Id == id);

            return frete != null ? Ok(frete) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaFrete([FromBody] CreateFrete FreteDto)
        {
            Frete frete = _mapper.Map<Frete>(FreteDto);

            _context.Fretes.Add(frete);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFretePorId), new { id = frete.Id }, new { id = frete.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFrete(Guid id, [FromBody] UpdataFrete NovoFrete)
        {
            Frete frete = _context.Fretes.FirstOrDefault(x => x.Id == id);

            if (frete == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoFrete, frete);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
