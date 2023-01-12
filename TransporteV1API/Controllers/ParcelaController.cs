using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParcelaController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public ParcelaController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetParcela()
        {
            return Ok(_context.Parcelas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaParcelaPorId(Guid id)
        {
            Parcela parcela = _context.Parcelas.FirstOrDefault(x => x.Id == id);

            return parcela != null ? Ok(parcela) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaParcela([FromBody] CreateParcela ParcelaDto)
        {
            Parcela parcela = _mapper.Map<Parcela>(ParcelaDto);

            _context.Parcelas.Add(parcela);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaParcelaPorId), new { id = parcela.Id }, new { id = parcela.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaParcela(Guid id, [FromBody] UpdataParcela NovoParcela)
        {
            Parcela parcela = _context.Parcelas.FirstOrDefault(x => x.Id == id);

            if (parcela == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoParcela, parcela);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
