using AutoMapper;
using Avaliacao.Application.Dtos;
using Avaliacao.Domain.Entities;

namespace Avaliacao.Domain.Tests.Common
{
    public class GenerateFakerMapper
    {
        public static IMapper AddMapperConfiguration()
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteDto>().ReverseMap();
                cfg.CreateMap<Endereco, EnderecoDto >().ReverseMap();
            });
            IMapper mapper = new Mapper(autoMapperConfig);
            return mapper;
        }
    }
}
