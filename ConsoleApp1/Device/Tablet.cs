
namespace ConsoleApp1
{
    public class Tablet : BasicDevice
    {
        public Tablet(string name, string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
            : base(name, brand, model, battery, maxBattery, software, network, printer, speaker) { }

        public override void PlayGame(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск гри");
            PlayGameBase(returnToMenu, 400);
        }

        public override void UsePrinter(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск принтера");
            UsePrinterBase(returnToMenu, 200);
        }

        public override void WatchVideo(Action<BasicDevice> returnToMenu)
        {
            Notify("Запуск відео");
            WatchVideoBase(returnToMenu, 200);
        }
    }
}
