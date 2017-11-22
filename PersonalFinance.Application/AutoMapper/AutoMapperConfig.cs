using AutoMapper;

namespace PersonalFinance.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper IMap { get; private set; }

        public static void RegisterMappings()
        {
            var registerMapper = new MapperConfiguration((map) => 
            {
                map.AddProfile<DomainToDTO>();
                map.AddProfile<DTOToDomain>();
            });

            IMap = registerMapper.CreateMapper(); 
        }
    }
}