namespace ConsoleApp1
{
    public abstract class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Battery { get; set; }
        public int MaxBattery { get; set; }
        public bool Software { get; set; }
        public bool Network { get; set; }
        public bool Printer { get; set; }
        public bool Speaker { get; set; }
        public Device(string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
        {
            Brand = brand;
            Model = model;
            Battery = battery;
            MaxBattery = maxBattery;
            Software = software;
            Network = network;
            Printer = printer;
            Speaker = speaker;
        }
        public virtual void UseBattery(string activity, int consumption)
        {
            Console.Clear();
            while (Battery > 0)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    SubMenuLaptop.MenuLaptop();
                    return;
                }

                Console.WriteLine($"Батарея: {(double)Battery / MaxBattery * 100:F1}%");
                Console.WriteLine($"Ви {activity}...");
                Battery -= consumption;
                if (Battery < 0) Battery = 0;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        public virtual void ShowInfo(string device)
        {
            Console.WriteLine($"{device}: {Brand} {Model}\n" +
                $"Максимальна ємність батареї: {MaxBattery}мАг\n" +
                $"Поточний заряд батареї: {Battery}мАг\n" +
                $"Програмне забезпечення: {(Software ? "Наявне" : "Відсутнє")}\n" +
                $"Мережа: {(Network ? "Наявна" : "Відсутня")}\n" +
                $"Принтер: {(Printer ? "Наявний" : "Відсутній")}\n" +
                $"Колонки: {(Speaker ? "Наявні" : "Відсутні")}");
        }
        public abstract void PlayGame();
        public abstract void WatchVideo();
        public abstract void UsePrinter();
    }
}
