using AutoMapper;
using Vega.net;
namespace Vega.net;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Model, ModelResource>();
        CreateMap<Make, MakeResource>();
    }

}
