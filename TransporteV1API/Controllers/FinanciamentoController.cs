using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinanciamentoController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public FinanciamentoController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFinanciamento()
        {
            return Ok(_context.Financiamentos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFinanciamentoPorId(Guid id)
        {
            Financiamento financiamento = _context.Financiamentos.FirstOrDefault(x => x.Id == id);

            return financiamento != null ? Ok(financiamento) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaFinanciamento([FromBody] CreateFinanciamento FinanciamentoDto)
        {
            Financiamento financiamento = _mapper.Map<Financiamento>(FinanciamentoDto);

            _context.Financiamentos.Add(financiamento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFinanciamentoPorId), new { id = financiamento.Id }, new { id = financiamento.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFinanciamento(Guid id, [FromBody] UpdataFinanciamento NovoFinanciamento)
        {
            Financiamento financiamento = _context.Financiamentos.FirstOrDefault(x => x.Id == id);

            if (financiamento == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoFinanciamento, financiamento);
                _context.SaveChanges();
                return NoContent();
            }
        }

    }
}
