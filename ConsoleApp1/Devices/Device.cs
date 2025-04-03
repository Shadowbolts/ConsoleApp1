namespace ConsoleApp1
{
    public abstract class Device : IObservable<string>
    {
        private List<IObserver<string>> observers = new List<IObserver<string>>();

        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Battery { get; set; }
        public int MaxBattery { get; set; }
        public bool Software { get; set; }
        public bool Network { get; set; }
        public bool Printer { get; set; }
        public bool Speaker { get; set; }
        protected Device(string name, string brand, string model, int battery, int maxBattery, bool software, bool network, bool printer, bool speaker)
        {
            Name = name;
            Brand = brand;
            Model = model;
            Battery = battery;
            MaxBattery = maxBattery;
            Software = software;
            Network = network;
            Printer = printer;
            Speaker = speaker;
        }
        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }
        protected void Notify(string state)
        {
            Console.Clear();
            Console.WriteLine($"[{Name}: {Brand} {Model}]: {state}");
            foreach (var observer in observers)
            {
                observer.OnNext($"{Name}: {Brand} {Model}: {state}");
            }
        }
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> _observers;
            private IObserver<string> _observer;
            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
        protected virtual void UseBattery(string activity, int consumption, Action<Device> returnToMenu)
        {
            Console.Clear();
            while (Battery > 0)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    returnToMenu(this);
                    return;
                }

                Console.WriteLine($"Батарея: {(double)Battery / MaxBattery * 100:F1}%");
                Console.WriteLine($"Ви {activity}...");
                Battery -= consumption;
                if (Battery < 0)
                {
                    Battery = 0;
                    returnToMenu(this);
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        public virtual void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine($"{Name}: {Brand} {Model}\n" +
                $"Максимальна ємність батареї: {MaxBattery}мАг\n" +
                $"Поточний заряд батареї: {Battery}мАг\n" +
                $"Програмне забезпечення: {(Software ? "Наявне" : "Відсутнє")}\n" +
                $"Мережа: {(Network ? "Наявна" : "Відсутня")}\n" +
                $"Принтер: {(Printer ? "Наявний" : "Відсутній")}\n" +
                $"Колонки: {(Speaker ? "Наявні" : "Відсутні")}");
            Console.ReadLine();
        }
        protected void WatchVideoBase(Action<Device> returnToMenu, int batteryUsage)
        {
            Console.Clear();
            if (!Software)
            {
                Console.WriteLine("На пристрої не встановлено програмного забезпечення.");
                Console.ReadLine();
            }
            else if (!Network)
            {
                Console.WriteLine("Неможливо завантажити відео, на пристрої відсутня мережа.");
                Console.ReadLine();
            }
            else if (!Speaker)
            {
                Console.WriteLine("На пристрої відсутні колонки. На відео буде відсутній звук.");
                Console.ReadLine();
                UseBattery("дивитесь відео", batteryUsage, returnToMenu);
            }
            else
            {
                UseBattery("дивитесь відео", batteryUsage, returnToMenu);
            }
        }
        protected void PlayGameBase(Action<Device> returnToMenu, int batteryUsage)
        {
            Console.Clear();
            if (!Software)
            {
                Console.WriteLine("На пристрої не встановлено програмного забезпечення.");
                Console.ReadLine();
            }
            else if (!Speaker)
            {
                Console.WriteLine("На пристрої відсутні колонки. У грі буде відсутній звук.");
                Console.ReadLine();
                UseBattery("граєте", batteryUsage, returnToMenu);
            }
            else
            {
                UseBattery("граєте", batteryUsage, returnToMenu);
            }
        }
        protected void UsePrinterBase(Action<Device> returnToMenu, int batteryUsage)
        {
            Console.Clear();
            if (!Software)
            {
                Console.WriteLine("На пристрої не встановлено програмного забезпечення.");
                Console.ReadLine();
            }
            else if (Printer)
            {
                UseBattery("використовуєте принтер", batteryUsage, returnToMenu);
            }
            else
            {
                Console.WriteLine("Принтер не знайдено");
                Console.ReadLine();
            }
        }
        public abstract void PlayGame(Action<Device> returnToMenu);
        public abstract void WatchVideo(Action<Device> returnToMenu);
        public abstract void UsePrinter(Action<Device> returnToMenu);
    }
}
