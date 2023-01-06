using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class DocumentoFunProfile : Profile
    {
        public DocumentoFunProfile() 
        {
            CreateMap<CreateDocumentoFun, DocumentoFun>();
            CreateMap<UpdataDocumentoFun, DocumentoFun>();
        }
    }
}
