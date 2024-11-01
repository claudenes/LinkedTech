using AutoMapper;
using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;

namespace Avaliacao.Application.Mappings
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile() 
        {
            CreateMap<ClienteDto, Cliente>().ReverseMap();
            CreateMap<EnderecoDto, Endereco>().ReverseMap();

        }
    }
}
