using AutoMapper;
using TransporteV1API.Data.Dtos;
using TransporteV1API.Modals;

namespace TransporteV1API.Profiles
{
    public class FuncionarioProfile : Profile
    {
        public FuncionarioProfile() {
            CreateMap<CreateFuncionario, Funcionario>();
            CreateMap<UpdataFuncionario, Funcionario>();
        }
    }
}
