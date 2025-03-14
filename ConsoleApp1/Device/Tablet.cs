
namespace ConsoleApp1
{
    public class Tablet : Device
    {
        public Tablet(string name, string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
            : base(name, brand, model, battery, maxBattery, software, network, printer, speaker) { }

        public override void PlayGame(Action<Device> returnToMenu)
        {
            PlayGameBase(returnToMenu, 400);
        }

        public override void UsePrinter(Action<Device> returnToMenu)
        {
            UsePrinterBase(returnToMenu, 200);
        }

        public override void WatchVideo(Action<Device> returnToMenu)
        {
            WatchVideoBase(returnToMenu, 200);
        }
    }
}
