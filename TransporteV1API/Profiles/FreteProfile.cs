using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class FreteProfile : Profile
    {
        public FreteProfile()
        {
            CreateMap<CreateFrete, Frete>();
            CreateMap<UpdataFrete, Frete>();
        }
    }
}
