namespace ConsoleApp1
{
    public static class DeviceController
    {
        public static void ChangeBattery(Device device)
        {
            Console.Clear();
            Console.Write("Введіть значення: ");
            string value = Console.ReadLine()!;
            if (Int32.TryParse(value, out int number) && number <= device.MaxBattery)
            {
                device.Battery = number;
                Console.WriteLine($"Батарея змінена на {value}мАг");
            }
            else
            {
                Console.WriteLine("Невірні введені дані");
            }
            Console.ReadLine();
        }
        public static void ChangeSettings(Device device, string settingName)
        {
            Console.Clear();
            bool currentValue = settingName switch
            {
                "Програмне забезпечення" => device.Software,
                "Мережу" => device.Network,
                "Принтер" => device.Printer,
                "Колонки" => device.Speaker,
                _ => throw new ArgumentException("Невідоме налаштування")
            };

            string action = currentValue ? "Вимкнути" : "Увімкнути";
            Console.Write($"{action} {settingName.ToLower()}? (так/ні): ");
            string userValue = Console.ReadLine()!.Trim().ToLower();

            if (userValue == "так")
            {
                switch (settingName)
                {
                    case "Програмне забезпечення":
                        {
                            device.Software = !device.Software;
                            break;
                        }
                    case "Мережу":
                        {
                            device.Network = !device.Network;
                            break;
                        }
                    case "Принтер":
                        {
                            device.Printer = !device.Printer;
                            break;
                        }
                    case "Колонки":
                        {
                            device.Speaker = !device.Speaker;
                            break;
                        }
                }
                Console.WriteLine($"Операція виконана.");
            }
            else if (userValue == "ні")
            {
                Console.WriteLine("Операція скасована.");
            }
            else
            {
                Console.WriteLine("Невідоме значення. Спробуйте ще раз.");
            }
            Console.ReadLine();
        }
    }
}
