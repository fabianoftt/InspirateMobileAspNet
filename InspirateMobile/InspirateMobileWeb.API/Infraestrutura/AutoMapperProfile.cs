using AutoMapper;
using InspirateMobile.Infrastructure.Entidades;

namespace InspirateMobileWeb.API.Infraestrutura
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<InspirateMobileWeb.API.Model.Oferta, Oferta>();
            CreateMap<Oferta, InspirateMobileWeb.API.Model.Oferta>();

            CreateMap<InspirateMobileWeb.API.Model.Interesse, Interesse>();
            CreateMap<Interesse, InspirateMobileWeb.API.Model.Interesse>();
        }
    }
}
