using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles;

public class CaminhaoProfile : Profile
{
    public CaminhaoProfile()
    {
        CreateMap<CreateCaminhao, Caminhao>();
        CreateMap<UpdataCaminhao, Caminhao>();
    }
}
