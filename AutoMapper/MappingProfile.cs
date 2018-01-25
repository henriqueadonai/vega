using AutoMapper;
using vega.Controllers.Resources;
using vega.Core.Models;


namespace vega.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            //CreateMap<Make, KeyValuePairResource>();
        }
        
    }
}