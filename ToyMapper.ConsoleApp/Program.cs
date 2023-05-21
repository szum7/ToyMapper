namespace ToyMapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            new SetupAutoMapper().Run();
            new SetupTinyMapper().Run();
            new SetupMapperly().Run();
            new SetupMapster().Run();

            Console.WriteLine("END.");
        }
    }
}