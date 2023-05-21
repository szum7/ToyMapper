using AutoMapper;
using System.Text.Json;
using ToyMapper.Models;

namespace ToyMapper
{
    public class SetupAutoMapper
    {
        private readonly IMapper _mapper;
        private readonly CountryDto _countryDto = TestData.CountryDto;

        public SetupAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CountryDto, Country>();
                cfg.CreateMap<RegionDto, Region>();
                cfg.CreateMap<Country, CountryDto>();
                cfg.CreateMap<Region, RegionDto>();
            });

            _mapper = config.CreateMapper();
        }

        public void Run()
        {
            Console.WriteLine("AutoMapper");
            var obj = _mapper.Map<Country>(_countryDto);
            Console.WriteLine(JsonSerializer.Serialize(obj));
        }
    }
}
