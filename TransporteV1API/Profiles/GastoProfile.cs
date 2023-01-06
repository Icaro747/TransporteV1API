using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles;

public class GastoProfile : Profile
{
    public GastoProfile() {
        CreateMap<CreateGasto, Gasto>();
        CreateMap<UpdataGasto, Gasto>();
    }
}
