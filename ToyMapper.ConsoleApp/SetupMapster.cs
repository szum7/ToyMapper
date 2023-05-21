using Mapster;
using System.Text.Json;
using ToyMapper.Models;

namespace ToyMapper
{
    public class SetupMapster
    {
        private readonly CountryDto _countryDto = TestData.CountryDto;

        public SetupMapster()
        {
            // Mapster don't need a configuration
        }

        public void Run()
        {
            Console.WriteLine("Mapster");
            var obj = _countryDto.Adapt<Country>();
            Console.WriteLine(JsonSerializer.Serialize(obj));
        }
    }
}
