using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles;

public class FinanciamentoProfile : Profile
{
    public FinanciamentoProfile()
    {
        CreateMap<CreateFinanciamento, Financiamento>();
        CreateMap<UpdataCaminhao, Financiamento>();
    }
}
