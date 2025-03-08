namespace ConsoleApp1
{
    public static class ConsoleMenu
    {
        public static void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("1 - Ноутбук");
                Console.WriteLine("9 - Вихід");
                if (Enum.TryParse(Console.ReadLine(), out MainMenuChoice choice))
                {
                    switch (choice)
                    {
                        case MainMenuChoice.Laptop:
                            {
                                SubMenuLaptop.MenuLaptop();
                                break;
                            }
                        case MainMenuChoice.Exit:
                            {
                                running = false;
                                break;
                            }
                    }
                }
            }
        }
    }
}
