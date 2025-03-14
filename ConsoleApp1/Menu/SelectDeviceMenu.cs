namespace ConsoleApp1
{
    public static class SelectDeviceMenu
    {
        public static Device DeviceSelection()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Оберіть девайс:");
                Console.WriteLine("1 - Ноутбук");
                Console.WriteLine("2 - Телефон");
                Console.WriteLine("3 - Планшет");
                Console.WriteLine("9 - Вихід");
                if (Enum.TryParse(Console.ReadLine(), out MainMenuChoice choice))
                {
                    switch (choice)
                    {
                        case MainMenuChoice.Laptop:
                            {
                                return new Laptop("Ноутбук", "Lenovo", "ThinkPad X1 Carbon", 7000, 7000, true, true, true, true);
                            }
                        case MainMenuChoice.Tablet:
                            {
                                return new Tablet("Планшет", "Apple", "iPad Pro", 5000, 5000, true, false, false, true);
                            }
                        case MainMenuChoice.Phone:
                            {
                                return new Phone("Телефон", "Samsung", "Galaxy S23", 3000, 3000, true, true, false, false);
                            }
                        case MainMenuChoice.Exit:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }
        }
    }
}
