using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class EquipeProfile : Profile
    {
        public EquipeProfile() 
        {
            CreateMap<CreateEquipe, Equipe>();
            CreateMap<UpdataEquipe, Equipe>();  
        }
    }
}
