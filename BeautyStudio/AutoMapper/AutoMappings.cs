using AutoMapper;
using BeautyStudio.Models.Models;
using BeautyStudio.Models.Models.Requests;

namespace BeautyStudio.AutoMapper
{
    public class AutoMappings : Profile
    {
        public AutoMappings()
        {
            CreateMap<HairCutRequest, HairCut>();
            
        }
    }
}
