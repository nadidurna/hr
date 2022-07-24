using AutoMapper;
using Circle.Data.Requests.ManagementContracts;
using Circle.Entities.Foundation;
using Circle.Entities.Main;

namespace Circle.Mapper.Profiles
{
    internal class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Lookup, LookupDto>();
            CreateMap<NewLookupRequestDto, Lookup>();
            CreateMap<UpdateLookupRequestDto, Lookup>();
            CreateMap<LookupType, LookupTypeDto>();
            CreateMap<NewLookupTypeRequestDto, LookupType>();
            CreateMap<NewCompanyRequestDto, Company>();
            CreateMap<UpdateLookupTypeRequestDto, LookupType>();
            CreateMap<Company,CompanyDto>();
            CreateMap<UpdateCompanyRequestDto, Company>();
        }
    }
}