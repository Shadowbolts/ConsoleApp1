namespace ConsoleApp1
{
    public class SubMenuLaptop
    {
        static Laptop laptop = new Laptop("Lenovo", "ThinkPad X1 Carbon", 5000, 5000, true, true, true, true);
        public static void MenuLaptop()
        {
            Console.Clear();
            Console.WriteLine("1 - Показати інформацію");
            Console.WriteLine("2 - Пограти");
            Console.WriteLine("3 - Дивитись відео");
            Console.WriteLine("4 - Використати принтер");
            Console.WriteLine("8 - Контроль");
            Console.WriteLine("9 - Вихід");
            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out LaptopMenu choice))
                {
                    switch (choice)
                    {
                        case LaptopMenu.Info:
                            {
                                laptop.ShowInfo("Ноутбук");
                                break;
                            }
                        case LaptopMenu.Play:
                            {
                                laptop.PlayGame();
                                break;
                            }
                        case LaptopMenu.Watch:
                            {
                                laptop.WatchVideo();
                                break;
                            }
                        case LaptopMenu.Printer:
                            {
                                laptop.UsePrinter();
                                break;
                            }
                        case LaptopMenu.Control:
                            {
                                break;
                            }
                        case LaptopMenu.Exit:
                            {
                                return;
                            }
                    }
                }
            }
        }
    }
}
