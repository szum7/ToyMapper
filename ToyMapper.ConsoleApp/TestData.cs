using ToyMapper.Models;

namespace ToyMapper
{
    public class TestData
    {
        public static CountryDto CountryDto = new CountryDto
        {
            Id = Guid.NewGuid(),
            Age = 1,
            Name = "Country",
            Regions = new[]
            {
                new RegionDto { Name = "region1", Size = 100 },
                new RegionDto { Name = "region1", Size = 100 }
            }
        };
    }
}
