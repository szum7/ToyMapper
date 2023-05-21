using System.Text.Json;
using ToyMapper.Models;

namespace ToyMapper
{
    public class SetupTinyMapper
    {
        private readonly CountryDto _countryDto = TestData.CountryDto;

        public SetupTinyMapper()
        {
            Nelibur.ObjectMapper.TinyMapper.Bind<CountryDto, Country>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Country, CountryDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<RegionDto, Region>();
            Nelibur.ObjectMapper.TinyMapper.Bind<Region, RegionDto>();
        }

        public void Run()
        {
            Console.WriteLine("TinyMapper");
            var obj = Nelibur.ObjectMapper.TinyMapper.Map<Country>(_countryDto);
            Console.WriteLine(JsonSerializer.Serialize(obj));
        }
    }
}
