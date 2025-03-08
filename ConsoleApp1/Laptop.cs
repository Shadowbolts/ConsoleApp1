namespace ConsoleApp1
{
    public class Laptop : Device
    {
        public Laptop(string brand, string model, int battery, bool software, bool network, bool printer, bool speaker)
            : base(brand, model, battery, software, network, printer, speaker) { }
        public override void ShowInfo()
        {
            Console.WriteLine($"Ноутбук {Brand} {Model}");
        }
    }
}
