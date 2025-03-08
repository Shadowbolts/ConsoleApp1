namespace ConsoleApp1
{
    public class SubMenuLaptop
    {
        public static void MenuLaptop()
        {
            Console.Clear();
            bool running = true;
            Laptop laptop = new Laptop("Lenovo", "ThinkPad X1 Carbon", 5000, true, true, false, true);
            while (running)
            {
                if (Enum.TryParse(Console.ReadLine(), out LaptopMenu choice))
                {
                    switch (choice)
                    {
                        case LaptopMenu.Info:
                            {
                                laptop.ShowInfo();
                                break;
                            }
                        case LaptopMenu.Exit:
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
