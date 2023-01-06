using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public FuncionarioController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFuncionario()
        {
            return Ok(_context.Funcionarios);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFuncionarioPorId([FromQuery] Guid id)
        {
            Funcionario funcionario = _context.Funcionarios.FirstOrDefault(x => x.Id == id);

            return funcionario != null ? Ok(funcionario) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaFuncionario([FromBody] CreateFuncionario FuncionarioDto)
        {
            Funcionario funcionario = _mapper.Map<Funcionario>(FuncionarioDto);

            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFuncionarioPorId), new { id = funcionario.Id }, new { id = funcionario.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFuncionario(Guid id, [FromBody] UpdataFuncionario NovoFuncionario)
        {
            Funcionario financiamento = _context.Funcionarios.FirstOrDefault(x => x.Id == id);

            if (financiamento == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoFuncionario, financiamento);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
