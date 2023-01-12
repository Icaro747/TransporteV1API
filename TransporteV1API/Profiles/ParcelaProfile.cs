using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class ParcelaProfile : Profile
    {
        public ParcelaProfile() 
        {
            CreateMap<CreateParcela, Parcela>();
            CreateMap<UpdataParcela, Parcela>();
        }
    }
}
