namespace ConsoleApp1
{
    public abstract class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Battery { get; set; }
        public bool Software { get; set; }
        public bool Network { get; set; }
        public bool Printer { get; set; }
        public bool Speaker { get; set; }
        public Device(string brand, string model, int battery, bool software, bool network, bool printer, bool speaker)
        {
            Brand = brand;
            Model = model;
            Battery = battery;
            Software = software;
            Network = network;
            Printer = printer;
            Speaker = speaker;
        }
        public virtual void ShowInfo(string device)
        {
            Console.WriteLine($"{device}: {Brand} {Model}\nБатарея: {Battery}мАг\nПрограмне забезпечення: {Software}");
        }
    }
}
