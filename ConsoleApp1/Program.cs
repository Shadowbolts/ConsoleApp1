namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Device device = SelectDeviceMenu.DeviceSelection();
                DeviceMenu.Menu(device);
            }
        }
    }
}
