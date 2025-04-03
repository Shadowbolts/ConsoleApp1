namespace ConsoleApp1
{
    public static class DeviceMenu
    {
        public static void Menu(BasicDevice device)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Меню для: {device.Name}");
                Console.WriteLine("1 - Показати інформацію");
                Console.WriteLine("2 - Пограти");
                Console.WriteLine("3 - Дивитись відео");
                Console.WriteLine("4 - Використати принтер");
                Console.WriteLine("8 - Контроль");
                Console.WriteLine("9 - Вихід");

                if (Enum.TryParse(Console.ReadLine(), out DeviceMenuOption choice))
                {
                    switch (choice)
                    {
                        case DeviceMenuOption.Info:
                            {
                                device.ShowInfo();
                                break;
                            }
                        case DeviceMenuOption.Play:
                            {
                                device.PlayGame(Menu);
                                break;
                            }
                        case DeviceMenuOption.Watch:
                            {
                                device.WatchVideo(Menu);
                                break;
                            }
                        case DeviceMenuOption.Printer:
                            {
                                device.UsePrinter(Menu);
                                break;
                            }
                        case DeviceMenuOption.Control:
                            {
                                DeviceControlMenu.Control(device);
                                break;
                            }
                        case DeviceMenuOption.Exit:
                            {
                                return;
                            }
                    }
                }
            }
        }
    }
}
