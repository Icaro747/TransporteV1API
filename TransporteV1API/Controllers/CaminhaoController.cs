using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Modals;
using TransporteV1API.Data;
using TransporteV1API.Data.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public CaminhaoController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaCaminhao([FromBody] CreateCaminhao CaminhaoDto)
        {
            Caminhao caminhao = _mapper.Map<Caminhao>(CaminhaoDto);

            _context.Caminhaos.Add(caminhao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCaminhaoPorId), new { id = caminhao.Id }, new { id = caminhao.Id });
        }

        [HttpGet]
        public IActionResult GetCamias() {
            return Ok(_context.Caminhaos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCaminhaoPorId(Guid id)
        {
            Caminhao caminhao = _context.Caminhaos
                .Include(x => x.Financiamento)
                .Include(x => x.Seguro)
                .SingleOrDefault(x => x.Id == id);

            return caminhao != null ? Ok(caminhao) : NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCaminhao(Guid id, [FromBody] UpdataCaminhao NovoCaminhao)
        {
            Caminhao caminhao = _context.Caminhaos.FirstOrDefault(x => x.Id == id);

            if (caminhao == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoCaminhao, caminhao);
                _context.SaveChanges();
                return NoContent();
            }
        }

        //[HttpDelete("{id}")]
        //public IActionResult DeletaCaminhao(int id)
        //{
        //    Camiao camiao = _context.Camiaos.FirstOrDefault(camiao => camiao.Id == id);
        //    if (camiao == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _context.Remove(camiao);
        //        _context.SaveChanges();
        //        return NoContent();
        //    }
        //}
    }
}
