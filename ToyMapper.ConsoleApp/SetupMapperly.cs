using Riok.Mapperly.Abstractions;
using System.Text.Json;
using ToyMapper.Models;

namespace ToyMapper
{
    [Mapper]
    public partial class MapperlyMapper // this should auto generate a mapper based on the models
    {
        public partial Country Map(CountryDto countryDto); // you can F12 into this to see the mapping method
    }

    public class SetupMapperly
    {
        private readonly MapperlyMapper _mapper;
        private readonly CountryDto _countryDto = TestData.CountryDto;

        public SetupMapperly()
        {
            _mapper = new MapperlyMapper();
        }

        public void Run()
        {
            Console.WriteLine("Mapperly");
            var obj = _mapper.Map(_countryDto);
            Console.WriteLine(JsonSerializer.Serialize(obj));
        }
    }
}
