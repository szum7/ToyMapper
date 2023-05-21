namespace ToyMapper.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Region[] Regions { get; set; }
    }

    public class Region
    {
        public long Size { get; set; }

        public string Name { get; set; }
    }
}
