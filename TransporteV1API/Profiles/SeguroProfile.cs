using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles;

public class SeguroProfile : Profile
{
    public SeguroProfile() 
    {
        CreateMap<CreateSeguro, Seguro>();
        CreateMap<UpdataSeguro, Seguro>();
    }
}
