using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public EquipeController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEquipe()
        {
            return Ok(_context.Equipes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEquipePorId(Guid id)
        {
            Equipe equipe = _context.Equipes.FirstOrDefault(x => x.Id == id);

            return equipe != null ? Ok(equipe) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaEquipe([FromBody] CreateEquipe EquipeDto)
        {
            Equipe equipe = _mapper.Map<Equipe>(EquipeDto);

            _context.Equipes.Add(equipe);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEquipePorId), new { id = equipe.Id }, new { id = equipe.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEquipe(Guid id, [FromBody] UpdataEquipe NovoEquipe)
        {
            Equipe equipe = _context.Equipes.FirstOrDefault(x => x.Id == id);

            if (equipe == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoEquipe, equipe);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
