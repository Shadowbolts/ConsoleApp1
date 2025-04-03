using ConsoleApp1.Device.DeviceObserver;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Technician observer = new Technician();

            while (true)
            {
                BasicDevice device = SelectDeviceMenu.DeviceSelection();
                observer.Subscribe(device);
                DeviceMenu.Menu(device);
            }
        }
    }
}
