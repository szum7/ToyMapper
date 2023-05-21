namespace ToyMapper.Models
{
    public class CountryDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public RegionDto[] Regions { get; set; }
    }

    public class RegionDto
    {
        public long Size { get; set; }

        public string Name { get; set; }
    }
}
