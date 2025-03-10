namespace ConsoleApp1
{
    public class Laptop : Device
    {
        public Laptop(string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
            : base(brand, model, battery, maxBattery, software, network, printer, speaker) { }

        public override void PlayGame()
        {
            UseBattery("граєте", 500);
        }
        public override void WatchVideo()
        {
            UseBattery("дивитесь відео", 250);
        }
        public override void UsePrinter()
        {
            if (Printer)
            {
                UseBattery("використовуєте принтер", 250);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Принтер не знайдено");
            }
        }
    }
}
