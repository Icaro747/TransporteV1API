using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() 
        {
            CreateMap<CreateCliente, Cliente>();
            CreateMap<UpdataCliente, Cliente>();
        }
    }
}
