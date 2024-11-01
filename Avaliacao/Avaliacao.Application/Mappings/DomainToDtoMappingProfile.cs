using AutoMapper;
using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;

namespace Avaliacao.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile() 
        { 
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();

        }
    }
}
