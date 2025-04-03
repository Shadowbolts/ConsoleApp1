namespace ConsoleApp1
{
    public class Laptop : Device
    {
        public Laptop(string name, string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
            : base(name, brand, model, battery, maxBattery, software, network, printer, speaker) { }

        public override void PlayGame(Action<Device> returnToMenu)
        {
            Notify("Запуск гри");
            PlayGameBase(returnToMenu, 500);
        }
        public override void WatchVideo(Action<Device> returnToMenu)
        {
            Notify("Запуск відео");
            WatchVideoBase(returnToMenu, 250);
        }
        
        public override void UsePrinter(Action<Device> returnToMenu)
        {
            Notify("Запуск принтера");
            UsePrinterBase(returnToMenu, 250);
        }
    }
}
