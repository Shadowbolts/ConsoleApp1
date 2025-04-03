
namespace ConsoleApp1
{
    public class Phone : BasicDevice
    {
        public Phone(string name, string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
            : base(name, brand, model, battery, maxBattery, software, network, printer, speaker) { }

        public override void PlayGame(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск гри");
            PlayGameBase(returnToMenu, 150);
        }

        public override void UsePrinter(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск принтера");
            UsePrinterBase(returnToMenu, 100);
        }

        public override void WatchVideo(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск відео");
            WatchVideoBase(returnToMenu, 100);
        }
    }
}
