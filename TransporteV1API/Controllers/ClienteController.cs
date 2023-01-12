using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public ClienteController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] CreateCliente ClienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(ClienteDto);

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaClientePorId), new { id = cliente.Id }, new { id = cliente.Id });
        }

        [HttpGet]
        public IActionResult GetCliente()
        {
            return Ok(_context.Clientes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClientePorId(Guid id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);

            return cliente != null ? Ok(cliente) : NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(Guid id, [FromBody] UpdataCliente NovoCliente)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoCliente, cliente);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
