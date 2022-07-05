using AutoMapper;
using Circle.Data.Requests.ManagementContracts;
using Circle.Entities.Main;

namespace Circle.Mapper.Profiles
{
    internal class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Lookup, LookupDto>();
        }
    }
}