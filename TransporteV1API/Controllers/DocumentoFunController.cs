using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Data;
using TransporteV1API.Modals;

namespace TransporteV1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentoFunController : ControllerBase
    {
        private TransporteContext _context;
        private IMapper _mapper;

        public DocumentoFunController(TransporteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDocumento()
        {
            return Ok(_context.Documentos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaDocumentoPorId(Guid id)
        {
            DocumentoFun Documento = _context.Documentos.FirstOrDefault(x => x.Id == id);

            return Documento != null ? Ok(Documento) : NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaDocumento([FromBody] CreateDocumentoFun DocumentoDto)
        {
            DocumentoFun Documento = _mapper.Map<DocumentoFun>(DocumentoDto);

            _context.Documentos.Add(Documento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaDocumentoPorId), new { id = Documento.Id }, new { id = Documento.Id });
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaDocumento(Guid id, [FromBody] UpdataDocumentoFun NovoDocumento)
        {
            DocumentoFun Documento = _context.Documentos.FirstOrDefault(x => x.Id == id);

            if (Documento == null)
            {
                return NotFound();
            }
            else
            {
                _mapper.Map(NovoDocumento, Documento);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
